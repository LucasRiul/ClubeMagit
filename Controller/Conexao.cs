using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube.Controller
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-D03LR9C;Integrated Security=True";
        }

        //Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Desconectar
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
