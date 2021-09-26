using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class Record
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int NumberInQueue { get; set; }
    }
}
