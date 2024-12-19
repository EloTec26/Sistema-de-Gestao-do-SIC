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
    public class dados_faltas : conexao_sql
    {
        public DataTable selecionar_faltas()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_faltas", connection))
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

        public void inserir_faltas(e_comum_faltas faltas)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_faltas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_investigador", faltas.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", faltas.id_usuario);
                    cmd.Parameters.AddWithValue("@data_falta", faltas.data_falta);
                    cmd.Parameters.AddWithValue("@estado_falta", faltas.estado_falta);
                    cmd.Parameters.AddWithValue("@descricao", faltas.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", faltas.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", faltas.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_faltas(e_comum_faltas faltas)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_faltas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_falta", faltas.id_falta);
                    cmd.Parameters.AddWithValue("@id_investigador", faltas.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", faltas.id_usuario);
                    cmd.Parameters.AddWithValue("@data_falta", faltas.data_falta);
                    cmd.Parameters.AddWithValue("@estado_falta", faltas.estado_falta);
                    cmd.Parameters.AddWithValue("@descricao", faltas.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", faltas.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_faltas(e_comum_faltas faltas)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_faltas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_falta", faltas.id_falta);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
