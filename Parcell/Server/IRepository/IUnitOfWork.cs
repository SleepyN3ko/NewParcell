using Parcell.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcell.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Balance> Balances { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Swap> Swaps { get; }
        IGenericRepository<WishList> WishLists { get; }
        IGenericRepository<WishListItem> WishListItems { get; }

        IGenericRepository<Cart> Carts { get; }
        IGenericRepository<CartItem> CartItems { get; }


    }
}