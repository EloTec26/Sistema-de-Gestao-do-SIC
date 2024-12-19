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
    public class dados_evidencias : conexao_sql
    { 
        public DataTable selecionar_evidencias()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_evidencias", connection))
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

        public void inserir_evidencias(e_comum_evidencias evidencias)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_evidencias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_investigador", evidencias.id_investigador);
                    cmd.Parameters.AddWithValue("@id_caso", evidencias.id_caso);
                    cmd.Parameters.AddWithValue("@id_usuario", evidencias.id_usuario);
                    cmd.Parameters.AddWithValue("@tipo", evidencias.tipo);
                    cmd.Parameters.AddWithValue("@descricao", evidencias.descricao);
                    cmd.Parameters.AddWithValue("@data_coleta", evidencias.data_coleta);
                    cmd.Parameters.AddWithValue("@local_armazenamento", evidencias.local_armazenamento);
                    cmd.Parameters.AddWithValue("@data_registro", evidencias.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", evidencias.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_evidencias(e_comum_evidencias evidencias)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_evidencias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_evidencia", evidencias.id_evidencia);
                    cmd.Parameters.AddWithValue("@id_investigador", evidencias.id_investigador);
                    cmd.Parameters.AddWithValue("@id_caso", evidencias.id_caso);
                    cmd.Parameters.AddWithValue("@id_usuario", evidencias.id_usuario);
                    cmd.Parameters.AddWithValue("@tipo", evidencias.tipo);
                    cmd.Parameters.AddWithValue("@descricao", evidencias.descricao);
                    cmd.Parameters.AddWithValue("@data_coleta", evidencias.data_coleta);
                    cmd.Parameters.AddWithValue("@local_armazenamento", evidencias.local_armazenamento);
                    cmd.Parameters.AddWithValue("@data_atualizacao", evidencias.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_evidencias(e_comum_evidencias evidencias)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_evidencias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_evidencia", evidencias.id_evidencia);


                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
