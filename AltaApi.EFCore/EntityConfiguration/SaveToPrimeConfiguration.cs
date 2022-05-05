using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltaApi.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AltaApi.EFCore.EntityConfiguration
{
    public class SaveToPrimeConfiguration : IEntityTypeConfiguration<SaveToPrime>
    {
        public void Configure(EntityTypeBuilder<SaveToPrime> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(prop => prop.TranId).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Endpoint).HasMaxLength(50).IsRequired();  
            builder.Property(prop => prop.Application).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Date).HasColumnType("date");
    }
    }
}
