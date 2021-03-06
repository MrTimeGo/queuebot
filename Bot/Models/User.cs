using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin {  get; set; }
        public long TelegramId { get; set; }
        public DateTime BirthdayDate { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public List<Record> Records { get; set; }
    }
}
