using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados.Dados_Relatorios
{
    public class dados_relatorios_piquete : conexao_sql
    {
        public DataTable relatorioPiquete (DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            using (DataTable dt = new DataTable())
            {
                using (var connection = conectar())
                {
                    connection.Open();
                    string query = "relatorio_piquete";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@data_inicial", dataInicial);
                        cmd.Parameters.AddWithValue("@data_final", dataFinal);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                        return dt;
                    }
                }
            }
        }
    }
}
