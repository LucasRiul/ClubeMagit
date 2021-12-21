using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube.Controller
{
    public class CategoriaDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem = "";

        public CategoriaDAO(Categoria cat)
        {
            //comando banco
            cmd.CommandText = "insert into categoria (nome) values (@nome)";

            //parâmetros
            cmd.Parameters.AddWithValue("@nome", cat.Nome);

            try
            {
                //conectar
                cmd.Connection = conexao.conectar();
                                
                //executar comando
                cmd.ExecuteNonQuery();

                
                cmd.CommandText = "SELECT MAX(id) FROM categoria";

                SqlDataReader  dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cat.Id = dr.GetInt32(0);
                }

                //desconectar
                conexao.desconectar();

                //mensagem
                this.mensagem = "Categoria criada com sucesso!" +"\n" ;
                this.mensagem += "ID: " + cat.Id;
                

                
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro: " + e.Message;
            }
        }
    }
}
