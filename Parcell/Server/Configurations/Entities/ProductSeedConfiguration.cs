using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcell.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcell.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
             new Product
             {
                 Id = 1,
                 Name = "Water Bottle",
                 Description = "Green water bottle that has totally not been used before",
                 Stock = 1,
                 Price = 100,
                 P_category = "Household",
                 S_Category = "noswap"
             },

            new Product
            {
                Id = 2,
                Name = "File",
                Description = "Green file that has nothing in it",
                Stock = 10,
                Price = 10,
                P_category = "Office",
                S_Category = "Office"
            }

            );

        }
    }
}
