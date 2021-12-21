using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube.Controller
{
    internal class MensalidadeDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem = "";

        public MensalidadeDAO()
        {

        }

        public MensalidadeDAO(Mensalidade men)
        {
            //comando banco
            cmd.CommandText = "insert into mensalidade (valor_mensalidade,data_vencimento,data_pagamento,juros,valor_pago, id_socio) values (@valor_mensalidade, @data_vencimento, @data_pagamento, @juros,@valor_pago, @id_socio)";

            //parâmetros
            cmd.Parameters.AddWithValue("@valor_mensalidade", men.ValorParcela);
            cmd.Parameters.AddWithValue("@data_vencimento", men.DataVencimento);
            cmd.Parameters.AddWithValue("@data_pagamento", men.DataBaixa);
            cmd.Parameters.AddWithValue("@juros", men.Juros);
            cmd.Parameters.AddWithValue("@valor_pago", men.ValorPago);
            cmd.Parameters.AddWithValue("@id_socio", men.Socio.Id);

            try
            {
                //conectar
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT MAX(id) FROM mensalidade";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    men.Id = dr.GetInt32(0);
                }

                //desconectar
                conexao.desconectar();

                //mensagem
                this.mensagem = "Boleto criado com sucesso!" + "\n";
                this.mensagem += "ID da transação: " + men.Id;



            }
            catch (SqlException e)
            {
                this.mensagem = "Erro: " + e.Message;
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
