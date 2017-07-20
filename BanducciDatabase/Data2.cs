namespace BanducciDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Data2 : DbContext
    {
        public Data2()
            : base("name=Data2")
        {
        }

        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.phone)
                .IsUnicode(false);
        }
    }
}
