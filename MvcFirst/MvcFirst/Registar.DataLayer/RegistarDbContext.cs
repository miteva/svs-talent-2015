using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
   public class RegistarDbContext : DbContext
    {
     public   DbSet<Bike> Bikes { set; get; }


     public RegistarDbContext()
         : base("RegistarDb")
        {
            Bikes = this.Set<Bike>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
        }

    }
}
