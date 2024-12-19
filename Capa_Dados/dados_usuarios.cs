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
    public class dados_usuarios : conexao_sql
    {
        #region Método para selecionar os usuários no banco de dados
        public DataTable selecionar_usuarios()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_usuarios", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter sda  = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                                return dt;
                        }
                    }
                }
            }
        }
        #endregion

        #region Método para registrar os usuários no banco de dados
        public void registrar_usuarios (e_comum_usuarios usuarios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_usuarios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_continente", usuarios.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", usuarios.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", usuarios.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", usuarios.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", usuarios.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@primeiro_nome", usuarios.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", usuarios.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", usuarios.ultimo_nome);
                    //cmd.Parameters.AddWithValue("@data_nascimento", usuarios.data_nascimento);
                    cmd.Parameters.AddWithValue("@bi", usuarios.bi);
                    cmd.Parameters.AddWithValue("@sexo", usuarios.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", usuarios.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", usuarios.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", usuarios.e_mail);
                    cmd.Parameters.AddWithValue("@tipo_usuario", usuarios.tipo_usuario);
                    cmd.Parameters.AddWithValue("@palavra_passe", usuarios.palavra_passe);
                    //cmd.Parameters.AddWithValue("@data_registro", usuarios.data_registro);
                    //cmd.Parameters.AddWithValue("@data_atualizacao", usuarios.data_atualizacao);

                    cmd.ExecuteNonQuery();
                    
                }
            }
        }
        #endregion

        #region Método para atualizar os usuários no banco de dados
        public void atualizar_usuarios(e_comum_usuarios usuarios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_usuarios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", usuarios.id_usuario);
                    cmd.Parameters.AddWithValue("@id_continente", usuarios.id_continente);
                    cmd.Parameters.AddWithValue("@id_pais", usuarios.id_pais);
                    cmd.Parameters.AddWithValue("@id_provincia", usuarios.id_provincia);
                    cmd.Parameters.AddWithValue("@id_municipio", usuarios.id_municipio);
                    cmd.Parameters.AddWithValue("@id_bairro_rua", usuarios.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@primeiro_nome", usuarios.primeiro_nome);
                    cmd.Parameters.AddWithValue("@nome_meio", usuarios.nome_meio);
                    cmd.Parameters.AddWithValue("@ultimo_nome", usuarios.ultimo_nome);
                    //cmd.Parameters.AddWithValue("@data_nascimento", usuarios.data_nascimento);
                    cmd.Parameters.AddWithValue("@bi", usuarios.bi);
                    cmd.Parameters.AddWithValue("@sexo", usuarios.sexo);
                    cmd.Parameters.AddWithValue("@telefone1", usuarios.telefone1);
                    cmd.Parameters.AddWithValue("@telefone2", usuarios.telefone2);
                    cmd.Parameters.AddWithValue("@e_mail", usuarios.e_mail);
                    cmd.Parameters.AddWithValue("@tipo_usuario", usuarios.tipo_usuario);
                    cmd.Parameters.AddWithValue("@palavra_passe", usuarios.palavra_passe);
                    //cmd.Parameters.AddWithValue("@data_registro", usuarios.data_registro);
                    //cmd.Parameters.AddWithValue("@data_atualizacao", usuarios.data_atualizacao);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion

        #region Método para eliminar os usuários no banco de dados
        public void eliminar_usuarios(e_comum_usuarios usuarios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_usuarios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", usuarios.id_usuario);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

    }
}
