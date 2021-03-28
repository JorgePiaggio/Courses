using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsEntityFramework.Data
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
            : base("name=PubsContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Titleauthor> Titleauthors { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.titleauthors)
                .WithRequired(e => e.author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_name)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Titleauthor>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Titleauthor>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.title1)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.advance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.titleauthors)
                .WithRequired(e => e.title)
                .WillCascadeOnDelete(false);
        }
    }
}
