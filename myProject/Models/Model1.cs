using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace myProject.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<C0RDER_DETAIL_tbl> C0RDER_DETAIL_tbl { get; set; }
        public virtual DbSet<ADMIN_tbl> ADMIN_tbl { get; set; }
        public virtual DbSet<C_FEEDBACK_tbl> C_FEEDBACK_tbl { get; set; }
        public virtual DbSet<CATEGORY_tbl> CATEGORY_tbl { get; set; }
        public virtual DbSet<CITY_tbl> CITY_tbl { get; set; }
        public virtual DbSet<CUSTOMER_tbl> CUSTOMER_tbl { get; set; }
        public virtual DbSet<FLOOR_tbl> FLOOR_tbl { get; set; }
        public virtual DbSet<ORDER_tbl> ORDER_tbl { get; set; }
        public virtual DbSet<PRODUCT_tbl> PRODUCT_tbl { get; set; }
        public virtual DbSet<S_FEEDBACK_tbl> S_FEEDBACK_tbl { get; set; }
        public virtual DbSet<SHOP_tbl> SHOP_tbl { get; set; }
        public virtual DbSet<SHOPKEEPER_tbl> SHOPKEEPER_tbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORY_tbl>()
                .HasMany(e => e.PRODUCT_tbl)
                .WithRequired(e => e.CATEGORY_tbl)
                .HasForeignKey(e => e.CATEGORY_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CITY_tbl>()
                .HasMany(e => e.SHOP_tbl)
                .WithRequired(e => e.CITY_tbl)
                .HasForeignKey(e => e.CITY_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CUSTOMER_tbl>()
                .HasMany(e => e.C_FEEDBACK_tbl)
                .WithRequired(e => e.CUSTOMER_tbl)
                .HasForeignKey(e => e.CUSTOMER_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CUSTOMER_tbl>()
                .HasMany(e => e.ORDER_tbl)
                .WithRequired(e => e.CUSTOMER_tbl)
                .HasForeignKey(e => e.CUSTOMER_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FLOOR_tbl>()
                .HasMany(e => e.SHOP_tbl)
                .WithRequired(e => e.FLOOR_tbl)
                .HasForeignKey(e => e.FLOOR_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_tbl>()
                .HasMany(e => e.C0RDER_DETAIL_tbl)
                .WithRequired(e => e.ORDER_tbl)
                .HasForeignKey(e => e.ORDER_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT_tbl>()
                .HasMany(e => e.C0RDER_DETAIL_tbl)
                .WithRequired(e => e.PRODUCT_tbl)
                .HasForeignKey(e => e.PRODUCT_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SHOP_tbl>()
                .HasMany(e => e.CATEGORY_tbl)
                .WithRequired(e => e.SHOP_tbl)
                .HasForeignKey(e => e.SHOP_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SHOP_tbl>()
                .HasMany(e => e.ORDER_tbl)
                .WithRequired(e => e.SHOP_tbl)
                .HasForeignKey(e => e.SHOP_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SHOPKEEPER_tbl>()
                .HasMany(e => e.S_FEEDBACK_tbl)
                .WithRequired(e => e.SHOPKEEPER_tbl)
                .HasForeignKey(e => e.SHOPKEEPER_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SHOPKEEPER_tbl>()
                .HasMany(e => e.SHOP_tbl)
                .WithRequired(e => e.SHOPKEEPER_tbl)
                .HasForeignKey(e => e.SHOPKEEPER_FID)
                .WillCascadeOnDelete(false);
        }
    }
}
