using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parcell.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcell.Server.Configurations.Entities
{
    public class SwapSeedConfiguration : IEntityTypeConfiguration<Swap>
    {
        public void Configure(EntityTypeBuilder<Swap> builder)
        {
            //seed to prevent null error
            builder.HasData(
             new Swap
             {
                 Id = 1,
                 SStatus = true,
                 PStatus = false,
                 SProduct_id = 1,
                 SProduct_quantity = 1,
                 PProduct_id = 1,
                 PProduct_quantity = 1
             }
            ) ;
        }
    }
}
