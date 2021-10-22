using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.EntityConfigurations
{
    public class ArticuleConfiguration : IEntityTypeConfiguration<Articule>
    {
        public void Configure(EntityTypeBuilder<Articule> builder) {
            builder.HasKey(_ => _.ArticuleId);
            builder.Property(_ => _.Content).IsRequired();
            builder.Property(_ => _.Keyword).IsRequired();
            builder.Property(_ => _.Title).IsRequired();
            builder
                .HasOne(_ => _.User)
                .WithMany(_ => _.Articules)
                .HasForeignKey(_ => _.UserId);
        }
    }
}
