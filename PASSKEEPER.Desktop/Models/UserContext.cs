using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace PASSKEEPER.Desktop.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {
            Database.CreateIfNotExists();
        }
     
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
