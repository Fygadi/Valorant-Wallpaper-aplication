using System.Threading;

namespace Service_Valorant_WallPaper_Changer
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;

		public Worker(ILogger<Worker> logger)
		{
			_logger = logger;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			WallPaperChanger wallPaper = new("WALLPAPER");
			Thread.Sleep(Timeout.Infinite);
		}
	}
}