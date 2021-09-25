﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long TelegramId { get; set; }

        public List<User> Users { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
