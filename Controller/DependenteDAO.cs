using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube.Controller
{
    public class DependenteDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public DependenteDAO()
        {

        }

        public DependenteDAO(Dependente dep)
        {
            //comando banco
            cmd.CommandText = "insert into dependente (nome,email,id_socio,parentesco) values (@nome,@email,@id_socio,@parentesco)";

            //parâmetros
            cmd.Parameters.AddWithValue("@nome", dep.Nome);
            cmd.Parameters.AddWithValue("@email", dep.Email);
            cmd.Parameters.AddWithValue("@id_socio", dep.Socio.Id);
            cmd.Parameters.AddWithValue("@parentesco", dep.Parentesco);

            try
            {
                //conectar
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT MAX(id) FROM dependente";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dep.Id = dr.GetInt32(0);
                }

                //desconectar
                conexao.desconectar();

                //mensagem
                this.mensagem = "Dependente cadastrado com sucesso!" + "\n";
                this.mensagem += "Número do cartão: " + dep.Id;
                //this.mensagem += "Nome do Sócio: " + dep.Socio.Nome;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro : " + e.Message;
            }
        }

        public DataTable ListarSocio()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select nome from socio order by id";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, conexao.conectar());
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException e)
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
