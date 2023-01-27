using Microsoft.Win32;
using System.Management;
using System.Security.Principal;
using System;
using System.IO;

namespace Service_Valorant_WallPaper_Changer
{
	public class WmiKeyChange
	{
		Action<object, EventArrivedEventArgs> KeyWallPaperChangeCallback;
		Action<object, EventArrivedEventArgs> KeyTimerDelayChangeCallback;
		public WmiKeyChange(Action<object, EventArrivedEventArgs> tmp_KeyWallPaperChangeCallback,
							Action<object, EventArrivedEventArgs> tmp_KeyTimerDelayChangeCallback)
		{
			KeyWallPaperChangeCallback = tmp_KeyWallPaperChangeCallback;
			KeyTimerDelayChangeCallback = tmp_KeyTimerDelayChangeCallback;

			StartQueryWallPaper();
			StartQueryTimerDelay();
		}

		private void StartQueryWallPaper()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nQuery WallPaper");
			try
			{
				WqlEventQuery query = new WqlEventQuery(
					"SELECT * FROM RegistryValueChangeEvent WHERE " +
					"Hive = 'HKEY_USERS'" + "AND KeyPath = '" + Path.Join(GetCurentUserSID(), MyRegistry.MyQueryPath) + "'" +
					"AND ValueName= '" + MyRegistry.MyKeyNewWallPaper + "'");

				ManagementEventWatcher watcher = new ManagementEventWatcher(query);
				watcher.EventArrived += new EventArrivedEventHandler(KeyWallPaperChangeCallback);
				watcher.Start();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Start");
				//Console.WriteLine("Waiting for an event...");
			}
			catch (ManagementException managementException)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("An error occurred: " + managementException.Message);
			}
			Console.ForegroundColor = ConsoleColor.White;
		}

		private void StartQueryTimerDelay()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\nQuery TimerDelay");
			try
			{
				WqlEventQuery query = new WqlEventQuery(
					"SELECT * FROM RegistryValueChangeEvent WHERE " +
					"Hive = 'HKEY_USERS'" + "AND KeyPath = '" + Path.Join(GetCurentUserSID(), MyRegistry.MyQueryPath) + "'" +
					"AND ValueName= '" + MyRegistry.MyKeyTimerDelay + "'");

				ManagementEventWatcher watcher = new ManagementEventWatcher(query);
				watcher.EventArrived += new EventArrivedEventHandler(KeyTimerDelayChangeCallback);
				watcher.Start();

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Start\n");
				//Console.WriteLine("Waiting for an event...");
			}
			catch (ManagementException managementException)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("An error occurred: " + managementException.Message);
			}
			Console.ForegroundColor = ConsoleColor.White;
		}


		///<summary>
		///Get the current user SID
		///(Require administrator permission)
		///</summary>
		private string GetCurentUserSID()
		{
			var user = WindowsIdentity.GetCurrent().User;
			return user.ToString();
		}
	}
}