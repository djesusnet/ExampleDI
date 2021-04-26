using ExampleDI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExampleDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DIController : ControllerBase
    {
        private readonly IOperationSingleton _operationSingleton;
        private readonly IOperationTransient _operationTransient;
        private readonly IOperationScoped _operationScoped;


        public DIController(IOperationSingleton operationSingleton,
                                         IOperationTransient operationTransient,
                                         IOperationScoped operationScoped)
        {
            _operationSingleton = operationSingleton;
            _operationTransient = operationTransient;
            _operationScoped = operationScoped;
        }


        [HttpGet]
        [Route("/getservices")]
        public string GetServicesS()
        {
            return
                $"Singleton - {_operationSingleton.OperationId} / Transient - {_operationTransient.OperationId} / Scoped - {_operationScoped.OperationId}";
        }
    }
}