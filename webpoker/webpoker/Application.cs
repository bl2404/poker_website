﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webpoker.Hubs;
using webpoker.Models;

namespace webpoker
{
    public class Application
    {
        public Application()
        {
            Tables = new List<Table>();
            AllUsers = new List<Models.User>();
            Instance = this;
        }
        public List<Table> Tables { get; set; }
        public List<Models.User> AllUsers { get; set; }

        public ChatHub ChatHub { get; set; }
        public static Application Instance { get; set; }
    }
}
