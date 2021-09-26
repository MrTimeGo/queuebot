using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public interface IRecords
    {
        int Enqueue(User user, Subject subj);
        bool Dequeue(User user, Subject subj);
        bool Clear(Subject subj);
        List<Record> GetRecordsBySubject(Subject subj);
    }
}
