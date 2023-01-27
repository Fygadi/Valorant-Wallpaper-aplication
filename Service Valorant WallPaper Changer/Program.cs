using Service_Valorant_WallPaper_Changer;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices(services =>
	{
		services.AddHostedService<Worker>();
	})
	.UseWindowsService()
	.Build();

host.Run();