namespace ProductDemoApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Api.Service;
    using SQLite.CodeFirst;
    public partial class DataModel : DbContext
    {
        public DataModel() : base("name=DataModel")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var initializer = new ProductDemoAppDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }
    }
}
