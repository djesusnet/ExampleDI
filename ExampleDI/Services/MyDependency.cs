using ExampleDI.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace ExampleDI.Services
{
    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> _logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            _logger = logger;
        }

        public void WriteMessage(string message)
        {
            _logger.LogInformation( $"MyDependency.WriteMessage Message: {message}");
        }
    }
}