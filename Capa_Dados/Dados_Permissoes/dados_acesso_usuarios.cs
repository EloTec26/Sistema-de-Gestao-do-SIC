using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Dados.Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados.Dados_Permissoes
{
    public class dados_acesso_usuarios : conexao_sql
    {
        public void AtualizarPerfilUsuario(int id, string firstName, string middleName, string lastName, string bi, string telefone, string email, string password)
        {
            using (var conn = conectar())
            {
                conn.Open();
                string Query = "update usuario_tbl set primeiro_nome=@firstName, nome_meio=@middleName, ultimo_nome=@lastName, bi=@bi, telefone1=@telefone, e_mail=@email, palavra_passe=@password where id_usuario=@id";
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@primeiro_nome", firstName);
                    cmd.Parameters.AddWithValue("@nome_meio", middleName);
                    cmd.Parameters.AddWithValue("@ultimo_nome", lastName);
                    cmd.Parameters.AddWithValue("@bi", bi);
                    cmd.Parameters.AddWithValue("@telefone1", telefone);
                    cmd.Parameters.AddWithValue("@e_mail", email);
                    cmd.Parameters.AddWithValue("@palavra_passe", password);
                    cmd.Parameters.AddWithValue("@id_usuario", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool Verificar_Login(string senha)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("iniciar_Sessao", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@palavra_passe", senha);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario = sdr.GetInt32(0);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome = sdr.GetString(1);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio = sdr.GetString(2);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome = sdr.GetString(3);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.bi = sdr.GetString(4);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo = sdr.GetString(5);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1 = sdr.GetString(6);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail = sdr.GetString(7);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario = sdr.GetString(8);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe = sdr.GetString(9);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
