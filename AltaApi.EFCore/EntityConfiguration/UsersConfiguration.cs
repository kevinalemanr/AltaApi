using AltaApi.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.EFCore.EntityConfiguration
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.Property(prop => prop.Id).UseIdentityColumn();
            builder.Property(prop => prop.UserName).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Password).HasMaxLength(50).IsRequired();
            builder.Property(prop => prop.Active).IsRequired().HasDefaultValue(false);
            
        }
    }
}
