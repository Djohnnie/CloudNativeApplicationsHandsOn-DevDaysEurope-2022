namespace WorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://webapi");
            _logger.LogInformation($"{response}");
            await Task.Delay(5000, stoppingToken);
        }
    }
}