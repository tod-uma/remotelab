﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RemoteLab.Models
{
    public class RemoteLabContext : DbContext 
    {
        public RemoteLabContext() { }
        public RemoteLabContext(string ConnStr) : base(ConnStr) { }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}