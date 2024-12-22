using Capa_Comum.Entidade_Relatorio;
using Capa_Dados.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados.Dados_Relatorios
{
    public class dados_relatorios_eventos_casos : conexao_sql
    {
        public DataTable buscar_relatorios_eventos_casos(DateTime? data_inicial = null, DateTime? data_final = null)
        {
            DataTable dt = new DataTable();
            using (var connection = conectar())
            {
                connection.Open();
                string query = "relatorio_eventos_casos";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@data_inicial", data_inicial);
                    cmd.Parameters.AddWithValue("@data_final", data_final);
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
