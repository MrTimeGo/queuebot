using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Services
{
    public interface IQueue
    {
        IUsers Users { get; }
        IGroups Groups { get; }
        IRecords Records { get; }
        ISubjects Subjects { get; }
    }
}
