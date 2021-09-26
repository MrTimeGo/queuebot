using TelegramBot.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBot.Services;

namespace TelegramBot.Models
{
    public static class Bot
    {
        private static ITelegramBotClient client;

        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<ITelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<Command>()
            {

            };

            var hook = string.Format(AppSettings.Url, "api/message/update");
            client = new TelegramBotClient(AppSettings.Key);
            await client.SetWebhookAsync(hook);

            return client;
        }
    }
}
