using MercadoTechLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTechLibrary.Controller
{

    public class ControllerMercadoTech
    {
        private SqlCommand command = new SqlCommand();
        SqlConnection connection = new SqlConnection();

        public void ExecutaConexao()
        {
            
            
            connection.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MercadoTechDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            command.Connection = connection;
            try
            {
                connection.Open();
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Favor entrar em conato com o administrador do sistema!");
            }
            
            // finally                            ** com o using nao prescisa fechar 
            // {
            //     connection.Dispose();
            // }


        }
        public void GetAddFuncionario(Funcionario parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"INSERT INTO FUNCIONARIOS(NOME) VALUES ('{parametro.Nome}')");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public void GetDelFuncionario(Funcionario parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"DELETE FROM FUNCIONARIOS WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }
        public void GetDesFuncionario(Funcionario parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"UPDATE FUNCIONARIOS SET ATIVO=0 WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public void GetAtvFuncionario(Funcionario parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"UPDATE FUNCIONARIOS SET ATIVO=1 WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public List<Funcionario> GetListaFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            ExecutaConexao();
            command.CommandText = "SELECT * FROM FUNCIONARIOS";
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                funcionarios.Add(new Funcionario()
                {
                    Ativo = (bool)reader["Ativo"],
                    DataAlteracao = (DateTime)reader["DataAlteracao"],
                    DataCriacao = (DateTime)reader["DataCriacao"],
                    Id = (int)reader["Id"],
                    Nome = (string)reader["Nome"],
                    UsuarioAlteracao = (int)reader["UsuarioAlteracao"],
                    UsuarioCriacao = (int)reader["UsuarioCriacao"]
                });
            }
            connection.Dispose();
            return funcionarios;
        }

        public List<Produto> GetListaProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            ExecutaConexao();
            command.CommandText = "SELECT * FROM PRODUTOS";
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                produtos.Add(new Produto()
                {
                    Ativo = (bool)reader["Ativo"],
                    DataAlteracao = (DateTime)reader["DataAlteracao"],
                    DataCriacao = (DateTime)reader["DataCriacao"],
                    Id = (int)reader["Id"],
                    Nome = (string)reader["Nome"],
                    UsuarioAlteracao = (int)reader["UsuarioAlteracao"],
                    UsuarioCriacao = (int)reader["UsuarioCriacao"],
                    Valor = (decimal)reader["Valor"]
                });
            }
            connection.Dispose();
            return produtos;
        }

        public void GetAtvProduto(Produto parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"UPDATE PRODUTOS SET ATIVO=1 WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public void GetDesProduto(Produto parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"UPDATE PRODUTOS SET ATIVO=0 WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public void GetDelProduto(Produto parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"DELETE FROM PRODUTOS WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public void GetAddProduto(Produto parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"INSERT INTO PRODUTOS(NOME,VALOR) VALUES ('{parametro.Nome}',{(parametro.Valor).ToString().Replace(',', '.')})");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public void GetAltValProduto(Produto parametro)
        {
            ExecutaConexao();
            command.CommandText = ($"UPDATE PRODUTOS SET VALOR={(parametro.Valor).ToString().Replace(',','.')} WHERE ID ={parametro.Id}");
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public List<ListaPedido> GetListaPedidos()
        {
            List<ListaPedido> pedidos = new List<ListaPedido>();
            ExecutaConexao();
            command.CommandText = "SELECT PED.*,FUN.NOME AS FUNCIONARIO,PRO.NOME AS PRODUTO, PRO.VALOR,(PRO.VALOR*PED.QUANTIDADE) AS TOTAL" +
                " FROM PEDIDOS PED LEFT JOIN FUNCIONARIOS FUN ON FUN.ID = PED.FuncionarioId " +
                "LEFT JOIN PRODUTOS PRO ON PRO.ID = PED.ProdutoId";
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pedidos.Add(new ListaPedido()
                {
                    Ativo = (bool)reader["Ativo"],
                    DataAlteracao = (DateTime)reader["DataAlteracao"],
                    DataCriacao = (DateTime)reader["DataCriacao"],
                    Id = (int)reader["Id"],
                    Funcionario = (string)reader["FUNCIONARIO"],
                    UsuarioAlteracao = (int)reader["UsuarioAlteracao"],
                    UsuarioCriacao = (int)reader["UsuarioCriacao"],
                    Produto = (string)reader["PRODUTO"],
                    Quantidade = (int)reader["Quantidade"],
                    Valor = (decimal)reader["VALOR"],
                    Total = (decimal)reader["TOTAL"],
                });
            }
            connection.Dispose();
            return pedidos;
        }

    }

}
