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
    public class HeartBeatInitiateConfiguration : IEntityTypeConfiguration<HeartBeatInitiate>
    {
        public void Configure(EntityTypeBuilder<HeartBeatInitiate> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(prop => prop.TranId).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.TranDt).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Wcs_Id).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Wh_Id).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.ResponseTime).HasColumnType("date");
        }
    }
}
