﻿using IdentityServer4.EntityFramework.Options;
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
        //set db for these models
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Swap> Swaps { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<WishListItem> WishListItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //add seedconfiguration to database
            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new WishListItemSeedConfiguration());
            builder.ApplyConfiguration(new WishListSeedConfiguration());
            builder.ApplyConfiguration(new CartItemSeedConfiguration());
            builder.ApplyConfiguration(new CartSeedConfiguration());
            builder.ApplyConfiguration(new BalanceSeedConfiguration());
        }



    }
}