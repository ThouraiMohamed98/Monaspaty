using Microsoft.EntityFrameworkCore;


#nullable disable

namespace MonaspatyF.Models
{
    public partial class MonaspatyContext : DbContext
    {
        public MonaspatyContext()
        {
        }

        public MonaspatyContext(DbContextOptions<MonaspatyContext> options)
            : base(options)
        {
        }

        //using System;
        //------------------------------ public Guid id { get; set; } ------------------------------
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<HallShopOwner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<HallShop>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Message>().Property(x => x.id).HasDefaultValueSql("NEWID()");

        //    modelBuilder.Entity<HallShopOwner>().HasData(
        //            new HallShopOwner()
        //            {
        //                Id = Guid.NewGuid(),
        //                name = "Thourai"
        //            }
        //        );
        //}

        public virtual DbSet<HallShop> HallShops { get; set; }
        public virtual DbSet<HallShopOwner> HallShopOwners { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
