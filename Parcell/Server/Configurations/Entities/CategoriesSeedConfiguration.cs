using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcell.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcell.Server.Configurations.Entities
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
             new Category
             {
                 Id = 1,
                 Name = "Others",
                 Description = "Other things you might want to get"
             },
             new Category
             {
                 Id = 2,
                 Name = "Household",
                 Description = "Things you need to have in your house"
             },

            new Category
            {
                Id = 3,
                Name = "Office",
                Description = "Things you would have in an office"
            }

            );

        }
    }
}
