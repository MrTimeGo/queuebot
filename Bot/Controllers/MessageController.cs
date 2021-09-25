using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot.Types;
using TelegramBot.Models;

namespace TelegramBot.Controllers
{
    public class MessageController : Controller
    {
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
                    command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}
