using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public interface IUsers
    {
        bool Register(User user);

        User GetBirthday();
        bool Delete(string fullname);
        User GetUserByTelegramId(long telegramId);
    }
}
