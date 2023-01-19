using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackgroundServices.Queues;
using BackgroundServices.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project001_Final.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BackgroundServicesController : ControllerBase
    {
        //private readonly INameQueueService nameQueueService;
        private readonly IBackgroundTask<string> queue;
        public BackgroundServicesController(IBackgroundTask<string> queue)
        {
            // this.nameQueueService = nameQueueService;
            this.queue = queue;
        }

        [HttpPost]
        [Route("AddQueue")]
        public async Task<IActionResult> AddQueue( string[] names)
        {
            foreach (var name in names)
            {
                await queue.AddQueue(name);
            }

            return Ok();
        }
    }
}
