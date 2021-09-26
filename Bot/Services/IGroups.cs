using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public interface IGroups
    {
        bool Register(Group group);
        List<User> GetUsers();
        bool Delete(string name);
        Group GetGroupByTelegramId(long telegramId);
    }
}
