using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BackgroundServices.Queues
{
    public class NamesQueue : IBackgroundTask<string>
    {
        private readonly Channel<string> queue;
        public NamesQueue(IConfiguration configuration)
        {

            int.TryParse(configuration["QueueCapacity"], out int capacity);

            BoundedChannelOptions options =  new BoundedChannelOptions((capacity))
            {
                FullMode = BoundedChannelFullMode.Wait
            };

            queue = Channel.CreateBounded<string>(options);
        }
        public async ValueTask AddQueue(string workItem)
        {
            await queue.Writer.WriteAsync(workItem);

        }

        public ValueTask<string> DeQueue(CancellationToken cancelletionToken)
        {
            var workItem = queue.Reader.ReadAsync(cancelletionToken);

            return workItem;
        }
    }
}
