using PersonalBookstore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DataContext") { }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<ContributorType> ContributorTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<BookContributor> BookContributors { get; set; }
        public DbSet<BookImage> BookImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            MapModels(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        private void MapModels(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasRequired(b => b.BookType)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.BookTypeID);

            modelBuilder.Entity<Book>()
                .HasRequired(b => b.Publisher)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.PublisherID);

            modelBuilder.Entity<BookImage>()
                .HasRequired(b => b.Book)
                .WithMany(b => b.Images)
                .HasForeignKey(b => b.BookID);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Contributors)
                .WithMany(c => c.Books)
                .Map(m =>
                    {
                        m.MapLeftKey("BookID");
                        m.MapRightKey("ContributorID");
                        m.ToTable("BookContributor");
                    }
                );
            //modelBuilder.Entity<Contributor>()
            //    .HasMany(b => b.ContributorTypes)
            //    .WithMany(c => c.Contributors)
            //    .Map(m =>
            //    {
            //        m.MapLeftKey("ContributorID");
            //        m.MapRightKey("ContributorTypeID");
            //        m.ToTable("BookContributor");
            //    }
            //    );
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Categories)
                .WithMany(c => c.Books)
                .Map(m =>
                {
                    m.MapLeftKey("BookID");
                    m.MapRightKey("CategoryID");
                    m.ToTable("BookCategory");
                }
                );
        }
    }
}
