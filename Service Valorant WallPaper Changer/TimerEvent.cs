using System;
using System.Threading;

namespace Service_Valorant_WallPaper_Changer
{
	public class TimerWallPaper
	{
		Timer timer = null;
		TimerCallback timerTimeDoneCallback;

		public TimerWallPaper(Action<object> tmp_methodCallBack)
		{
			timerTimeDoneCallback = new(tmp_methodCallBack);
		}

		public void StartTimer()
		{
			int newTimerDelay = MyRegistry.GetTimerDelay();

			if (timer == null)
			{
				//create the timer
				AutoResetEvent autoEvent = new AutoResetEvent(true);

				Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " Creating timer.");
				timer = new Timer(timerTimeDoneCallback, autoEvent, newTimerDelay, newTimerDelay);
			}
			else if (newTimerDelay == 0)
			{
				StopTimer();
				Console.WriteLine("The timer has been stop");
			}
			else if (newTimerDelay > 0)
			{
				timer.Change(newTimerDelay, newTimerDelay);
				Console.WriteLine("The timer has been start with an interval of " + newTimerDelay);
			}
			else
			{
				//that should not happend unless the user change the registry key
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Exception the timer delay is < 0 (" + newTimerDelay + ")");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		public void StopTimer()
		{
			if (timer != null)
			{
				timer.Dispose();
				timer = null;
			}
		}
	}
}
