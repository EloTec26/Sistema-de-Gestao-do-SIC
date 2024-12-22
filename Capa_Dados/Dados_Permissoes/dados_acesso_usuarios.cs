using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Dados.Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados.Dados_Permissoes
{
    public class dados_acesso_usuarios : conexao_sql
    {
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
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.id_continente = sdr.GetInt32(1);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.id_pais = sdr.GetInt32(2);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.id_provincia = sdr.GetInt32(3);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.id_municipio = sdr.GetInt32(4);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.id_bairro_rua = sdr.GetInt32(5);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome = sdr.GetString(6);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio = sdr.GetString(7);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome = sdr.GetString(8);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.bi = sdr.GetString(9);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo = sdr.GetString(10);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1 = sdr.GetString(11);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone2 = sdr.GetString(12);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail = sdr.GetString(13);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario = sdr.GetString(14);
                            comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe = sdr.GetString(15);
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
