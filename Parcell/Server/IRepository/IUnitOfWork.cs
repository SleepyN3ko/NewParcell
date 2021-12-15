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
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderDetail> OrderDetails { get; }
        IGenericRepository<PaymentDetail> PaymentDetails { get; }
        IGenericRepository<ProductCategory> ProductCategories { get; }
        IGenericRepository<Swap> Swaps { get; }
        IGenericRepository<SwapProduct> SwapProducts { get; }
        IGenericRepository<WishList> WishLists { get; }
        IGenericRepository<WishListItem> WishListItems { get; }


    }
}