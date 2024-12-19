using System.Data;
using System.Data.SqlClient;
using Capa_Dados.Conexao;

namespace Capa_Dados.Dados_Pesquisas
{
    public class dados_pesquisar_evidencias : conexao_sql
    {
        public DataTable pesquisar_Evidencias(string pesquisar)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("pesquisar_evidencias", connection))
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
    }
}
