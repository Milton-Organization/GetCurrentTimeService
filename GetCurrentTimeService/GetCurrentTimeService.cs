using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace GetCurrentTimeService;

public class GetCurrentTimeService
{
    private readonly ILogger<GetCurrentTimeService> _logger;

    public GetCurrentTimeService(ILogger<GetCurrentTimeService> logger)
    {
        _logger = logger;
    }

    [Function("GetCurrentTimeService")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult(DateTime.UtcNow);
    }
}