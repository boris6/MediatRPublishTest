using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRPublishTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<ServiceFactory>(p => p.GetService);

            services.AddSingleton<Pub>()
        }
    }
}
