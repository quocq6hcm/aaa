using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WCFService_Lab3.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("EAPLab3Conn") { }

        public DbSet<Models.Store> sList { get; set; }
    }
}