using System;
using BackgroundServices.Queues;
using BackgroundServices.Service;
using BackgroundServices.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BackgroundServices
{
    public static class ServiceRegistration
    {
      public static void AddBackgroundServices(this IServiceCollection services)
        {
            services.AddHostedService<QueueService>();
            services.AddLogging(i =>
            {
                i.AddConsole();
                i.AddDebug();
            });

            //services.AddSingleton<INameQueueService, NameQueueService>();
            services.AddSingleton(typeof(IBackgroundTask<string>), typeof(NamesQueue));
        }
    }
}
