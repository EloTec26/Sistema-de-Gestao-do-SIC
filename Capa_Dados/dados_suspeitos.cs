// importanto bibliotecas
using Capa_Comum.Entidades;
using Capa_Dados.Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados
{
    public class dados_suspeitos : conexao_sql
    {
        public DataTable selecionar_suspeitos_combo_box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select id_suspeito as ID, (primeiro_nome +' '+nome_meio +' '+ultimo_nome) as Nomes from suspeito_tbl", connection))
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
        public DataTable selecionar_suspeitos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_suspeitos", connection))
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

        public void inserir_suspeitos(e_comum_suspeitos suspeitos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_suspeitos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_caso", suspeitos.id_caso);
                    cmd.Parameters.AddWithValue("@id_continente", suspeitos.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", suspeitos.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", suspeitos.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", suspeitos.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", suspeitos.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", suspeitos.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", suspeitos.id_curso);
                    cmd.Parameters.AddWithValue("@id_usuario", suspeitos.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", suspeitos.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", suspeitos.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", suspeitos.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", suspeitos.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", suspeitos.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", suspeitos.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", suspeitos.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", suspeitos.e_mail);
                    cmd.Parameters.AddWithValue("@descricao", suspeitos.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", suspeitos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", suspeitos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_suspeitos(e_comum_suspeitos suspeitos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_suspeitos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_suspeito", suspeitos.id_suspeito);
                    cmd.Parameters.AddWithValue("@id_caso", suspeitos.id_caso);
                    cmd.Parameters.AddWithValue("@id_continente", suspeitos.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", suspeitos.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", suspeitos.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", suspeitos.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", suspeitos.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_nivel_academico", suspeitos.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@id_curso", suspeitos.id_curso);
                    cmd.Parameters.AddWithValue("@id_usuario", suspeitos.id_usuario);
                    cmd.Parameters.AddWithValue("@primeiro_nome", suspeitos.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", suspeitos.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", suspeitos.ultimo_nome);
                    cmd.Parameters.AddWithValue("@data_nascimento", suspeitos.data_nascimento);
                    cmd.Parameters.AddWithValue("@sexo", suspeitos.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", suspeitos.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", suspeitos.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", suspeitos.e_mail);
                    cmd.Parameters.AddWithValue("@descricao", suspeitos.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", suspeitos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", suspeitos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_suspeitos(e_comum_suspeitos suspeitos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_suspeitos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_suspeito", suspeitos.id_suspeito);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
