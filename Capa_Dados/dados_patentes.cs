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
    public class dados_patentes : conexao_sql
    {
        
        public DataTable selecionar_patentes_combobox()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select* from patente_tbl", connection))
                    {
                        
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable selecionar_patentes()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_patentes", connection))
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
        public void inserir_patentes(e_comum_patentes patentes)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("inserir_patentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", patentes.id_usuario);
                    cmd.Parameters.AddWithValue("@nome", patentes.nome);
                    cmd.Parameters.AddWithValue("@descricao", patentes.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", patentes.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", patentes.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_patentes(e_comum_patentes patentes)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_patentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_patente", patentes.id_patente);
                    cmd.Parameters.AddWithValue("@id_usuario", patentes.id_usuario);
                    cmd.Parameters.AddWithValue("@nome", patentes.nome);
                    cmd.Parameters.AddWithValue("@descricao", patentes.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", patentes.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", patentes.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminar_patentes(e_comum_patentes patentes)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_patente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_patente", patentes.id_patente);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
