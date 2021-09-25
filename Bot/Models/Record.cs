using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class Record
    {
        public string Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public string GroupId { get; set; }
        public Group Group { get; set; }

        public string SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int NumberInQueue { get; set; }
    }
}
