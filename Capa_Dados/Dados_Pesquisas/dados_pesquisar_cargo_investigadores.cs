using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Dados.Conexao;

namespace Capa_Dados.Dados_Pesquisas
{
    public class dados_pesquisar_cargo_investigadores : conexao_sql
    {
        public DataTable pesquisar_Cargos_Investigadores(string pesquisar)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("pesquisar_cargos_investigadores", connection))
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
