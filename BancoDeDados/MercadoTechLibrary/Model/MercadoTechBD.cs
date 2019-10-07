namespace MercadoTechLibrary.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class MercadoTechBD : DbContext
    {


        public MercadoTechBD()
            : base("name=MercadoTechBD")
        {
            
        }

        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.Pedidos)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.Pedidos)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(false);
        }
     
   
      
    }
}
