using System;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundServices.Queues
{
    public interface IBackgroundTask<T>
    {
        ValueTask AddQueue(T workItem);

        ValueTask<T> DeQueue(CancellationToken cancelletionToken);
    }
}
