using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.HasKey(_ => _.UserId);
            builder.Property(_ => _.Names).IsRequired();
            builder.Property(_ => _.Surnames).IsRequired();
            builder.Property(_ => _.Email).IsRequired();
            builder.Property(_ => _.Password).IsRequired();
        }
    }
}
