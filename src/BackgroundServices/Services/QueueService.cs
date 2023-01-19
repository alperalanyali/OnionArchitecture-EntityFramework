using System;
using System.Threading;
using System.Threading.Tasks;
using BackgroundServices.Queues;
using BackgroundServices.Service;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BackgroundServices.Services
{
    public class QueueService : BackgroundService
    {
        private readonly ILogger<QueueService> _logger;
        //private readonly INameQueueService _nameQueueService;
        private readonly IBackgroundTask<string> _queue;
        public QueueService(ILogger<QueueService> logger, /*INameQueueService nameQueueService*/ IBackgroundTask<string> queue)
        {
            _logger = logger;
            this._queue = queue;
          //  _nameQueueService = nameQueueService;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //await Task.Delay(3000);
                //while (_nameQueueService.HasNext())
                //{
                //    var name = _nameQueueService.DeQueue();
                //    _logger.LogInformation($"ExecuteAsync worked for {name}");
                //}

                var name = await _queue.DeQueue(stoppingToken);
                await Task.Delay(1000);
                _logger.LogInformation($"ExecuteAsnyc worked for {name}");
                //_logger.LogInformation($"ExecuteAsnyc worked for EMPTY result set {DateTime.Now.ToLongTimeString()}");
            }
        }
    }
}
