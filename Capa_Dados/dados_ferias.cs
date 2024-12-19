using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importanto bibliotecas
using System.Data;
using System.Data.SqlClient;
using Capa_Dados.Conexao;
using Capa_Comum.Entidades;

namespace Capa_Dados
{
    public class dados_ferias : conexao_sql
    {
        public DataTable selecionar_ferias()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_ferias", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public void inserir_ferias(e_comum_ferias ferias)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_ferias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_investigador", ferias.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", ferias.id_usuario);
                    cmd.Parameters.AddWithValue("@data_inicio", ferias.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", ferias.data_fim);
                    cmd.Parameters.AddWithValue("@estado_feria", ferias.estado_feria);
                    cmd.Parameters.AddWithValue("@descricao", ferias.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", ferias.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", ferias.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_ferias(e_comum_ferias ferias)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_ferias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@id_feria", ferias.id_feria);
                    cmd.Parameters.AddWithValue("@id_investigador", ferias.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", ferias.id_usuario);
                    cmd.Parameters.AddWithValue("@data_inicio", ferias.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", ferias.data_fim);
                    cmd.Parameters.AddWithValue("@estado_feria", ferias.estado_feria);
                    cmd.Parameters.AddWithValue("@descricao", ferias.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", ferias.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_ferias (e_comum_ferias ferias)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_ferias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_feria", ferias.id_feria);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
