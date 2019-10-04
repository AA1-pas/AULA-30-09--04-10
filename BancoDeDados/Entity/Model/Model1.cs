namespace Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Artista> Artistas { get; set; }
        public virtual DbSet<Canco> Cancoes { get; set; }
        public virtual DbSet<Genero> Generoes { get; set; }
        public virtual DbSet<Genero1> Generos { get; set; }
        public virtual DbSet<PlayList> PlayLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artista>()
                .HasMany(e => e.Cancoes)
                .WithRequired(e => e.Artista)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genero1>()
                .HasMany(e => e.Artistas)
                .WithRequired(e => e.Genero)
                .HasForeignKey(e => e.GeneroId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlayList>()
                .Property(e => e.Genero)
                .IsFixedLength();
        }
    }
}
