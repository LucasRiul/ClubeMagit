using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube.Controller
{
    internal class SocioDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public SocioDAO()
        {

        }
        public SocioDAO(Socio soc)
        {
            //comando banco
            cmd.CommandText = "insert into socio (nome,endereco,telefone,email, id_categoria) values (@nome,@endereco,@telefone,@email,@id_categoria)";

            //parâmetros
            cmd.Parameters.AddWithValue("@nome", soc.Nome);
            cmd.Parameters.AddWithValue("@endereco", soc.Endereco);
            cmd.Parameters.AddWithValue("@telefone", soc.Telefone);
            cmd.Parameters.AddWithValue("@email", soc.Email);
            cmd.Parameters.AddWithValue("@id_categoria", soc.Categoria.Id);

            try
            {
                //conectar
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT MAX(id) FROM socio";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    soc.Id = dr.GetInt32(0);
                }

                //desconectar
                conexao.desconectar();

                //mensagem
                this.mensagem = "Sócio cadastrado com sucesso!" + "\n";
                this.mensagem += "Número do Cartão: " + soc.Id ;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro : " + e.Message;
            }
        }
        
        public DataTable ListarCategoria()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select nome from categoria order by id";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, conexao.conectar());                
                adapter.Fill(dt);
                return dt;
            }
            catch(SqlException e)
            {
                Console.WriteLine("Erro: " + e.Message);
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }

    }
}
