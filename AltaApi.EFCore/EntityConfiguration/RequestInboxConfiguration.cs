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
    public class RequestInboxConfiguration : IEntityTypeConfiguration<RequestInbox>
    {
        public void Configure(EntityTypeBuilder<RequestInbox> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(prop => prop.TranDt).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.TranId).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Wh_Id).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Wcs_Id).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.LodNum).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Req_Contents_Flag).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Req_Stoloc_Flag).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Processing).IsRequired().HasDefaultValue(false);
            builder.Property(prop => prop.Concluded).IsRequired().HasDefaultValue(false);
            builder.Property(prop => prop.failed).IsRequired().HasDefaultValue(false);
            builder.Property(prop => prop.Reprocess).IsRequired().HasDefaultValue(false);
            builder.Property(prop => prop.CreationDate).HasColumnType("date");






        }
    }
}
