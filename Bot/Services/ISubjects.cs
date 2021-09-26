using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public interface ISubjects
    {
        bool Add(Subject subj);
        bool Remove(Subject subj);
        List<Subject> GetByGroup(Group group);
    }
}
