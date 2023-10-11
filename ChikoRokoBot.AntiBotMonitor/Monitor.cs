﻿using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ChikoRokoBot.AntiBotMonitor
{
    public class Monitor
    {
        [FunctionName("Monitor")]
        public void Run([TimerTrigger("0 */3 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
