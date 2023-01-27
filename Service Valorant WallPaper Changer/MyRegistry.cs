using Microsoft.Win32;
using System.Security.Principal;

public static class MyRegistry
{
	public const string MyHive = "HKEY_CURRENT_USER";
	public const string MyPath = @"SOFTWARE\Valorant Wallpaper Changer";
	public const string MyHiveAndPath = MyHive + @"\" + MyPath;
	public const string MyKeyNewWallPaper = "NewWallPaper";
	public const string MyKeyTimerDelay = "TimerDelay";
	public const string MyKeyValorantDefaultWallPapers = "ValorantDefaultWallPapers";

	public const string MyQueryPath = @"\\SOFTWARE\\Valorant Wallpaper Changer";

	/// <summary>Get the the path of the file or folder selected</summary>
	/// <returns>The full path or null if the key dosen't exist</returns>
	public static string GetWallPaperPath()
	{
		string WallPaperPath = null;

		RegistryKey key = Registry.CurrentUser.OpenSubKey(MyPath, false);
		if (key != null)
			WallPaperPath = key.GetValue(MyKeyNewWallPaper).ToString();
		return WallPaperPath;
	}

	/// <summary>Get the the timer delay</summary>
	/// <returns>In ms the delay selected or null if there's no delay"/></returns>
	public static int GetTimerDelay()
	{
		int timerDelay;
		RegistryKey key = Registry.CurrentUser.OpenSubKey(MyPath, false);
		timerDelay = Convert.ToInt32(key.GetValue(MyKeyTimerDelay));

		return timerDelay;
	}

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
}
