using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Bot.Models
{
    public static class Bot
    {
        private static ITelegramBotClient client;

        public static async Task<ITelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            client = new TelegramBotClient(AppSettings.Key);
            await client.SetWebhookAsync("");

            return client;
        }
    }
}
