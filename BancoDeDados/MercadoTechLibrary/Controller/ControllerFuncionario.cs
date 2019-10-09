using MercadoTechLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTechLibrary.Controller
{
    public class ControllerFuncionario
    {
        //Realizo minha conexão com o banco de dados
        MercadoTechBD contextDB = new MercadoTechBD();

        //Aqui temos a primeira interface com a classe IQueryable, essa classe contem varias funcionalidades prontas
        //para usar igual ao banco de dados como os selects 
        public IQueryable<Funcionario> GetPessoa()
        {
            return contextDB.Funcionarios;
        }
    }
}
