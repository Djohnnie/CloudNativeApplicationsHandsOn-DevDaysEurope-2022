using Blazor.Data;

namespace Blazor.Workers;

public class RequestWorker : BackgroundService
{
    private readonly RequestService _requestService;
    private readonly ILogger<RequestWorker> _logger;

    public RequestWorker(
        RequestService requestService, 
        ILogger<RequestWorker> logger)
    {
        _requestService = requestService;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("http://webapi");
                _requestService.Register(response);
              
                await Task.Delay(100, stoppingToken);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
    }
}