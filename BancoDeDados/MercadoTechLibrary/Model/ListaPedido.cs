using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTechLibrary.Model
{
   public  class ListaPedido
    {
        
      
        
            public int Id { get; set; }
            public decimal Valor { get; set; }
             public decimal Total { get; set; }

            public string Funcionario { get; set; }

            public string Produto { get; set; }

            public int Quantidade { get; set; }

            public bool Ativo { get; set; }

            public int UsuarioCriacao { get; set; }

            public int UsuarioAlteracao { get; set; }

            public DateTime DataCriacao { get; set; }

            public DateTime DataAlteracao { get; set; }

      
        
    }

}

