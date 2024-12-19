using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// importanto bibliotecas
using Capa_Comum.Entidades;
using Capa_Dados.Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados
{
    public class dados_testemunhas : conexao_sql
    {
        public DataTable selecionar_testemunhas_combo_boxs()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select id_testemunha as ID, (primeiro_nome +' '+nome_meio +' '+ultimo_nome) as Nomes from testemunha_tbl", connection))
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
        public DataTable selecionar_testemunhas()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_testemunha", connection))
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

        public void inserir_testemunhas(e_comum_testemunhas testemunhas)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_testemunha", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_caso", testemunhas.id_caso);
                    cmd.Parameters.AddWithValue("@id_continente", testemunhas.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", testemunhas.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", testemunhas.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", testemunhas.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", testemunhas.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", testemunhas.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", testemunhas.id_curso);
                    cmd.Parameters.AddWithValue("@id_usuario", testemunhas.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", testemunhas.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", testemunhas.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", testemunhas.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", testemunhas.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", testemunhas.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", testemunhas.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", testemunhas.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", testemunhas.e_mail);
                    cmd.Parameters.AddWithValue("@declaracao", testemunhas.declaracao);
                    cmd.Parameters.AddWithValue("@data_registro", testemunhas.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", testemunhas.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_testemunhas(e_comum_testemunhas testemunhas)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_testemunhas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_testemunha", testemunhas.id_testemunha);
                    cmd.Parameters.AddWithValue("@id_caso", testemunhas.id_caso);
                    cmd.Parameters.AddWithValue("@id_continente", testemunhas.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", testemunhas.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", testemunhas.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", testemunhas.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", testemunhas.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", testemunhas.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", testemunhas.id_curso);
                    cmd.Parameters.AddWithValue("@id_usuario", testemunhas.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", testemunhas.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", testemunhas.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", testemunhas.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", testemunhas.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", testemunhas.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", testemunhas.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", testemunhas.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", testemunhas.e_mail);
                    cmd.Parameters.AddWithValue("@declaracao", testemunhas.declaracao);
                    cmd.Parameters.AddWithValue("@data_registro", testemunhas.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", testemunhas.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_testemunhas(e_comum_testemunhas testemunhas)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_testemunhas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_testemunha", testemunhas.id_testemunha);


                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
