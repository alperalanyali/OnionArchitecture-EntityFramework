using System;
using System.Collections.Generic;
using System.Linq;
using BackgroundServices.Service;

namespace BackgroundServices.Services
{
    public class NameQueueService: INameQueueService
    {

        private List<string> queue;
        public NameQueueService()
        {
            queue = new List<string>();
        }
        public void AddQueue(string name)
        {
            queue.Add(name);
        }

        public string DeQueue()
        {
            var result = queue.First();
            queue.RemoveAt(0);

            return result;
        }

        public bool HasNext()
        {
            return queue?.Count > 0;
        }
    }
}
