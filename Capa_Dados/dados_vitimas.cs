using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Dados.Conexao;
using Capa_Comum.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados
{
    public class dados_vitimas : conexao_sql
    {
        #region Método para selecionar 
        public DataTable selecionar_vitimas_combo_box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select id_vitima as ID, (primeiro_nome +' '+nome_meio +' '+ultimo_nome) as Nomes from vitima_tbl", connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable selecionar_vitimas()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_vitimas", connection))
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
        #endregion

        #region Método para registrar 
        public void registrar_vitimas (e_comum_vitimas vitimas)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("inserir_vitimas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_caso", vitimas.id_caso);
                    cmd.Parameters.AddWithValue("@id_continente", vitimas.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", vitimas.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", vitimas.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", vitimas.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", vitimas.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", vitimas.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", vitimas.id_curso);
                    cmd.Parameters.AddWithValue("@id_usuario", vitimas.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", vitimas.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", vitimas.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", vitimas.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", vitimas.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", vitimas.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", vitimas.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", vitimas.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", vitimas.e_mail);
                    cmd.Parameters.AddWithValue("@descricao", vitimas.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", vitimas.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", vitimas.data_atualizacao);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion

        #region Método para atualizar 
        public void atualizar_vitimas (e_comum_vitimas vitimas)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_vitimas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_vitima", vitimas.id_vitima);
                    cmd.Parameters.AddWithValue("@id_caso", vitimas.id_caso);
                    cmd.Parameters.AddWithValue("@id_continente", vitimas.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", vitimas.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", vitimas.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", vitimas.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", vitimas.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", vitimas.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", vitimas.id_curso);
                    cmd.Parameters.AddWithValue("@id_usuario", vitimas.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", vitimas.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", vitimas.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", vitimas.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", vitimas.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", vitimas.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", vitimas.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", vitimas.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", vitimas.e_mail);
                    cmd.Parameters.AddWithValue("@descricao", vitimas.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", vitimas.data_atualizacao);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion

        #region Método para eliminar 
        public void eliminar_vitimas (e_comum_vitimas vitimas)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_vitimas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_vitima", vitimas.id_vitima);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
