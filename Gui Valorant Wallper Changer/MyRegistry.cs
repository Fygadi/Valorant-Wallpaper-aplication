using Microsoft.Win32;

public static class MyRegistry
{
	public const string MyHive = "HKEY_CURRENT_USER";
	public const string MyPath = @"SOFTWARE\Valorant Wallpaper Changer";
	public const string MyHiveAndPath = MyHive + @"\" + MyPath;
	public const string MyKeyNewWallPaper = "NewWallpaper";
	public const string MyKeyTimerDelay = "TimerDelay";

	//Key for GUI
	public const string MyGUILastPosition = "GUILastLocation";

	//Key For SERVICE
	public const string MyKeyValorantDefaultWallPapers = "ValorantDefaultWallPapers";
	public const string MyQueryPath = @"\\SOFTWARE\\ValorantWallPaper";

	/// <summary>
	/// Save the file or folder path given in the registry
	/// </summary>
	public static void SetWallPaperPath(string value)
	{
		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyRegistry.MyPath, true);
		key.SetValue(MyRegistry.MyKeyNewWallPaper, value);
		key.Close();
	}

	/// <summary>Get the the path of the file or folder selected</summary>
	/// <returns>True if the key data has been retrieve successfully, otherwise false</returns>
	public static bool GetWallPaperPath(out string WallPaperPath)
	{
		bool successful = false;
		WallPaperPath = "";
		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyPath, false);
			var keyValue = key.GetValue(MyKeyNewWallPaper);
		if (keyValue != null)
		{
			WallPaperPath = keyValue.ToString();
			successful = true;
		}
		key.Close();

		return successful;
	}

	public static void SetTimerDelay(int value)
	{
		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyRegistry.MyPath, true);
		key.SetValue(MyRegistry.MyKeyTimerDelay, value);
		key.Close();
	}


	/// <summary>Get the the timer delay</summary>
	/// <returns>In ms the delay selected or null if there's no delay"</returns>
	public static int GetTimerDelay()
	{
		int timerDelay;
		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyPath, false);
		timerDelay = Convert.ToInt32(key.GetValue(MyKeyTimerDelay));
		key.Close();

		
		return (timerDelay <= 99000)? timerDelay/1000: timerDelay/60000;
	}

	//SERVICE
	public static void SetDefaultValorantWallPapers(string[] wallpapers = null)
	{
		string value = "";

		if (wallpapers != null)
		{
			for (int i = 0; i < wallpapers.Length; i++)
			{
				value += Path.GetFileNameWithoutExtension(wallpapers[i]);

				if (i < wallpapers.Length - 1)
					value += "|";
			}
		}

		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyPath, true);
		key = Registry.CurrentUser.CreateSubKey(MyPath);
		key.SetValue(MyKeyValorantDefaultWallPapers, value);
		key.Close();
	}

	public static string[] GetDefaultValorantWallPapers()
	{
		string[] result = null;
		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyPath, true);
		key = Registry.CurrentUser.CreateSubKey(MyPath);
		try
		{
			result = key.GetValue(MyKeyValorantDefaultWallPapers).ToString().Split('|');
		}
		catch { }
		key.Close();

		foreach (string value in result)
			Console.WriteLine(value);

		return result;
	}

	//GUI
	public static void SetGUILastPosition(Point point)
	{
		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyRegistry.MyPath, true);
		key.SetValue(MyRegistry.MyGUILastPosition, point.X + ", " + point.Y);
		key.Close();

	}

	public static Point GetGUILastPosition(Size formSize)
	{
		Point lastPosition = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - formSize.Width / 2,
									   Screen.PrimaryScreen.Bounds.Height / 2 - formSize.Height / 2);

		RegistryKey key = Registry.CurrentUser.CreateSubKey(MyPath, true);
		object keyValue = key.GetValue(MyGUILastPosition);
		if (keyValue != null)
		{
			string[] value = keyValue.ToString().Split(',');
			lastPosition = new Point(int.Parse(value[0]), int.Parse(value[1]));
		}
		
		key.Close();

		return lastPosition;
	}
}