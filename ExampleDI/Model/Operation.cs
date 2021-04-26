using System;
using ExampleDI.Services.Interfaces;

namespace ExampleDI.Model
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString();
        }

        public string OperationId { get; }
    }
}