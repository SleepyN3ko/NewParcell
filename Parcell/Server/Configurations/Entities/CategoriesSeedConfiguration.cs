using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcell.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcell.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Seed for all the categories the products can ever have
            builder.HasData(
             new Category
             {
                 Id = 1,
                 Name = "noswap",
                 Description = "Products that cannot be swapped"
             },
             new Category
             {
                 Id = 2,
                 Name = "Others",
                 Description = "Other things you might want to get"
             },
             new Category
             {
                 Id = 3,
                 Name = "Household",
                 Description = "Things you need to have in your house"
             },
            new Category
            {
                Id = 4,
                Name = "Office",
                Description = "Things you would have in an office"
            }

            );

        }
    }
}
