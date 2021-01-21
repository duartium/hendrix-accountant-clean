using HendrixAccountant.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data
{
    /// <summary>
    ///  https://github.com/entityframeworktutorial/EF6-DBFirst-Demo/blob/master/EF6DBFirstDemo/School.Context.cs
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=HendrixAccountant")
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    }
}
