using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Conexao;

namespace Capa_Dados.Dados_Pesquisas
{
    public class dados_pesquisar_departamentos : conexao_sql
    {
        public System.Data.DataTable pesquisar_Departamentos(string pesquisar)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("pesquisar_departamentos", connection))
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
