using System;
namespace BackgroundServices.Service
{
    public interface INameQueueService
    {
        public void AddQueue(string name);
        public string DeQueue();
        public bool HasNext();
    }
}
