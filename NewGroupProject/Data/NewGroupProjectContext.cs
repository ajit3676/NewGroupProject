using NewGroupProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewGroupProject.Data
{
    public class NewGroupProjectContext : DbContext
    {
        public NewGroupProjectContext() : base("name=NewGroupProjectContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        // Other DbSets...


    }
}
