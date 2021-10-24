using ApiBlog.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBlog.Repository.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder) {
            builder.HasKey(c => c.CommentId);
            builder.Property(c => c.Content).IsRequired();
            builder.Property(c => c.ArticleId).IsRequired();

            builder.HasOne(c => c.User).WithMany(u => u.Comments).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(a => a.Article).WithMany(c => c.Comments).HasForeignKey(a => a.ArticleId); // No hace daño colocarla, pero ya está en Article
        }
    }
}
