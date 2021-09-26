using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public class QueueService : IQueue
    {
        public IUsers Users => throw new NotImplementedException();

        public IGroups Groups => throw new NotImplementedException();

        public IRecords Records => throw new NotImplementedException();

        public ISubjects Subjects => throw new NotImplementedException();

        private readonly QueueContext context;

        public QueueService(QueueContext context)
        {
            this.context = context;
        }
    }
}
