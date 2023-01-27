using System;
using System.Management;
using System.Threading;

namespace Service_Valorant_WallPaper_Changer
{
	public class ProcessWatch
	{
		Action ValorantStartCallback;
		Action ValorantStopCallback;

		ManagementEventWatcher processStartEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
		ManagementEventWatcher processStopEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");

		public ProcessWatch(Action tmp_ValorantStartCallback, Action tmp_ValorantStopCallback)
		{
			ValorantStartCallback = tmp_ValorantStartCallback;
			ValorantStopCallback = tmp_ValorantStopCallback;

			processStartEvent.EventArrived += new EventArrivedEventHandler(processStartEvent_EventArrived);
			processStartEvent.Start();

			processStopEvent.EventArrived += new EventArrivedEventHandler(processStopEvent_EventArrived);
			processStopEvent.Start();

			AutoResetEvent autoEvent = new AutoResetEvent(false);
		}

		void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
		{
			string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
			string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

			if (processName == "VALORANT.exe")
			{
				//Console.ForegroundColor = ConsoleColor.Blue;
				//Console.WriteLine("\nProcess started. Name: " + processName + " | ID: " + processID + "\n");
				//Console.ForegroundColor = ConsoleColor.White;

				ValorantStartCallback();
			}
		}

		void processStopEvent_EventArrived(object sender, EventArrivedEventArgs e)
		{
			string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
			string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();

			if (processName == "VALORANT.exe")
			{
				//Console.ForegroundColor = ConsoleColor.Red;
				//Console.WriteLine("\nProcess stopped. Name: " + processName + " | ID: " + processID + "\n");
				//Console.ForegroundColor = ConsoleColor.White;

				ValorantStopCallback();
			}
		}
	}
}