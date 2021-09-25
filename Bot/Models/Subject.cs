using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class Subject
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string GroupId { get; set; }
        public Group Group { get; set; }

        public List<Record> Records { get; set; }
    }
}
