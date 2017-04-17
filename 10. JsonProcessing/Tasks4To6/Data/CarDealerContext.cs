namespace Tasks4To6.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarDealerContext : DbContext
    {
        public CarDealerContext()
            : base("name=CarDealerContext")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Supplier> Suppliers{ get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
    }
}