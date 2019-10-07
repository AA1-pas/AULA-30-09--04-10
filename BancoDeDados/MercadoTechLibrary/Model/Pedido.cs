namespace MercadoTechLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedidos")]
    public partial class Pedido
    {
        public int Id { get; set; }

        public int FuncionarioId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public bool Ativo { get; set; }

        public int UsuarioCriacao { get; set; }

        public int UsuarioAlteracao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
