using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://queuekpbot.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "QueueKPBot";

        public static string Key { get; set; } 
    }
}
