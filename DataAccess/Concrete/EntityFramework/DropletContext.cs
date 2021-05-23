using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class DropletContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Droplet;Trusted_Connection=true");
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentMeta> CommentMetas { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostMeta> PostMetas { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<TermMeta> TermMetas { get; set; }
        public DbSet<TermRelationship> TermRelationships { get; set; }
        public DbSet<TermTaxonomy> TermTaxonomies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMeta> UserMetas { get; set; }
    }
}
