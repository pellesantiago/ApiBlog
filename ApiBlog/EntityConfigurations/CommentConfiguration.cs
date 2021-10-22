using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder) {
            builder.HasKey(_ => _.CommentId);
            builder.Property(_ => _.Content).IsRequired();
            builder.Property(_ => _.Articule).IsRequired();
            builder
                .HasOne(_ => _.Articule)
                .WithMany(_ => _.Comments)
                .HasForeignKey(_ => _.ArticuleId);

        }
    }
}
