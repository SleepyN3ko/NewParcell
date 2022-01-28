﻿using Parcell.Server.Data;
using Parcell.Server.IRepository;
using Parcell.Server.Models;
using Parcell.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Parcell.Server.Repository;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Category> _categories;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<OrderItem> _orderitems;
        private IGenericRepository<Product> _products;
        private IGenericRepository<Swap> _swaps;
        private IGenericRepository<WishList> _wishlists;
        private IGenericRepository<WishListItem> _wishlistitems;
        private IGenericRepository<Cart> _carts;
        private IGenericRepository<CartItem> _cartitems;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }



        public IGenericRepository<Category> Categories
            => _categories ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<OrderItem> OrderItems
            => _orderitems ??= new GenericRepository<OrderItem>(_context);
        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<Swap> Swaps
            => _swaps ??= new GenericRepository<Swap>(_context);
        public IGenericRepository<WishList> WishLists
            => _wishlists ??= new GenericRepository<WishList>(_context);
        public IGenericRepository<WishListItem> WishListItems
            => _wishlistitems ??= new GenericRepository<WishListItem>(_context);
        public IGenericRepository<Cart> Carts
            => _carts ??= new GenericRepository<Cart>(_context);
        public IGenericRepository<CartItem> CartItems
            => _cartitems ??= new GenericRepository<CartItem>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);


            await _context.SaveChangesAsync();


        }
    }
}
