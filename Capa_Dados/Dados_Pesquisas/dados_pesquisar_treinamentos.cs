using Capa_Dados.Conexao;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados.Dados_Pesquisas
{
    public class dados_pesquisar_treinamentos : conexao_sql
    {
        public DataTable pesquisar_Treinamento(string pesquisar)
        {
            try
            {
                using (var connection = conectar())
                {
                    connection.Open();
                    using (DataTable dt = new DataTable())
                    {
                        using (SqlCommand cmd = new SqlCommand("pesquisar_treinamentos", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@chave", SqlDbType.VarChar).Value = pesquisar;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
