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
    internal class ApiKeyConfiguration : IEntityTypeConfiguration<ApiKeys>
    {
        public void Configure(EntityTypeBuilder<ApiKeys> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.KeyValue).IsRequired().HasMaxLength(100);
            builder.Property(prop => prop.ApiName).IsRequired().HasMaxLength(100);
            builder.Property(prop => prop.ApplicationAccess).IsRequired().HasMaxLength(100);    
            builder.Property(prop => prop.Active).IsRequired().HasDefaultValue(false);
            builder.Property(prop => prop.CreationDate).HasColumnType("date");
        }
    }
}
