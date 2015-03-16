using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("OracleDbContext") 
        {
        }

        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Configure domain classes using modelBuilder here
            modelBuilder.Entity<User>().ToTable("USERS", "OVI");
            modelBuilder.Entity<User>().Property(user => user.ID).HasColumnName("ID").HasColumnType("NUMBER");
            modelBuilder.Entity<User>().Property(user => user.NAME).HasColumnName("NAME").HasColumnType("VARCHAR2");
            base.OnModelCreating(modelBuilder);

        }
    }


    internal class User
    {
        public long ID { get; set; }
        public string NAME { get; set; }


    }
}
