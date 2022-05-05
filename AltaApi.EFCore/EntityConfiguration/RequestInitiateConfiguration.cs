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
    public class RequestInitiateConfiguration : IEntityTypeConfiguration<RequestInitiate>
    {
        public void Configure(EntityTypeBuilder<RequestInitiate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(prop => prop.TranId).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Wh_id).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Wcs_id).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.LodNum).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Req_Contents_Flg).HasMaxLength(50);
            builder.Property(prop => prop.Req_Stoloc_flg).HasMaxLength(50);
            builder.Property(prop => prop.LotNum).HasMaxLength(50);
        }
    }
}
