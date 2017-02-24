using SimpleMVC.App.Models;

namespace SimpleMVC.App.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SharpStoreContex : DbContext
    {
        
        public SharpStoreContex()
            : base("name=SharpStoreContex")
        {
        }
        public virtual DbSet<Knive> Knives { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }

    }

    
}