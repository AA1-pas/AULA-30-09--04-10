namespace Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Canco
    {
        public int Id { get; set; }

        public int ArtistaId { get; set; }

        [Column("Nome ")]
        [Required]
        [StringLength(30)]
        public string Nome_ { get; set; }

        public virtual Artista Artista { get; set; }
    }
}
