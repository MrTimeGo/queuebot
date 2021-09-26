using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot.Types;
using TelegramBot.Models;
using TelegramBot.Services;

namespace TelegramBot.Controllers
{
    public class MessageController : Controller
    {
        private readonly IQueue queue;
        public MessageController(IQueue queue)
        {
            this.queue = queue;
        }
        [Route(@"api/message/update")]
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Name == message.Text.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries).FirstOrDefault())
                {
                    command.Execute(message, client, queue);
                    break;
                }
            }

            return Ok();
        }
    }
}
