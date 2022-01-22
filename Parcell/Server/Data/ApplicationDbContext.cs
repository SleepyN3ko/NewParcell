using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Parcell.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcell.Shared.Domain;
using Parcell.Server.Configurations.Entities;

namespace Parcell.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Swap> Swaps { get; set; }
        public DbSet<SwapCategory> SwapCategories { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<WishListItem> WishListItems { get; set; }
        public DbSet<WishList> Carts { get; set; }
        public DbSet<WishListItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new WishListItemSeedConfiguration());
            builder.ApplyConfiguration(new WishListSeedConfiguration());
            builder.ApplyConfiguration(new CartItemSeedConfiguration());
            builder.ApplyConfiguration(new CartSeedConfiguration());
        }


    }
}