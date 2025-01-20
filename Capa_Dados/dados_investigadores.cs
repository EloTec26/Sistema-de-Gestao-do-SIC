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
    public class dados_investigadores : conexao_sql
    {
        public DataTable selecionar_investigadores_combobox()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    string Query = @"select id_investigador as ID, (primeiro_nome +' '+nome_meio +' '+ ultimo_nome) as Nomes
	                                from investigador_tbl";

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
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
        public DataTable selecionar_investigadores()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_investigadores", connection))
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

        public void inserir_investigadores(e_comum_investigadores investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_investigadoes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_continente", investigadores.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", investigadores.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", investigadores.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", investigadores.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", investigadores.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", investigadores.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", investigadores.id_curso);
                    cmd.Parameters.AddWithValue("@id_especialidade", investigadores.id_especialidade);
                    cmd.Parameters.AddWithValue("@id_patente", investigadores.id_patente);
                    cmd.Parameters.AddWithValue("@id_usuario", investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", investigadores.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", investigadores.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", investigadores.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", investigadores.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", investigadores.sexo);
                    cmd.Parameters.AddWithValue("@bi", investigadores.bi);
                    cmd.Parameters.AddWithValue("@telefone1", investigadores.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", investigadores.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", investigadores.e_mail);
                    cmd.Parameters.AddWithValue("@data_inicio_contrato", investigadores.data_inicio_contrato);
                    cmd.Parameters.AddWithValue("@data_fim_contrato", investigadores.data_fim_contrato);
                    cmd.Parameters.AddWithValue("@data_registro", investigadores.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_investigadores(e_comum_investigadores investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_investigador", investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_continente", investigadores.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", investigadores.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", investigadores.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", investigadores.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", investigadores.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", investigadores.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", investigadores.id_curso);
                    cmd.Parameters.AddWithValue("@id_especialidade", investigadores.id_especialidade);
                    cmd.Parameters.AddWithValue("@id_patente", investigadores.id_patente);
                    cmd.Parameters.AddWithValue("@id_usuario", investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", investigadores.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", investigadores.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", investigadores.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", investigadores.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", investigadores.sexo);
                    cmd.Parameters.AddWithValue("@bi", investigadores.bi);
                    cmd.Parameters.AddWithValue("@telefone1", investigadores.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", investigadores.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", investigadores.e_mail);
                    cmd.Parameters.AddWithValue("@data_inicio_contrato", investigadores.data_inicio_contrato);
                    cmd.Parameters.AddWithValue("@data_fim_contrato", investigadores.data_fim_contrato);
                    cmd.Parameters.AddWithValue("@data_atualizacao", investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_investigadores (e_comum_investigadores investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_investigador", investigadores.id_investigador);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
