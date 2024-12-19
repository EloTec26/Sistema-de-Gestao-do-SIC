using Capa_Comum.Entidades;
using Capa_Dados.Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados
{
    public class dados_treinamentos : conexao_sql
    {
        #region Cadastrar treinementos
        public void Cadastrar_Treinamentos(e_comum_treinamentos treinamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("inserir_treinamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_departamento", treinamentos.id_departamento);
                    cmd.Parameters.AddWithValue("@id_investigador", treinamentos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", treinamentos.id_usuario);
                    cmd.Parameters.AddWithValue("@titulo", treinamentos.titulo);
                    cmd.Parameters.AddWithValue("@descricao", treinamentos.descricao);
                    cmd.Parameters.AddWithValue("@data_inicio", treinamentos.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", treinamentos.data_fim);
                    cmd.Parameters.AddWithValue("@data_registro", treinamentos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", treinamentos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion fim

        #region Selecionar treinamentos
        public DataTable Selecionar_Treinamentos()
        {
            using (var connection = conectar())
            {
                using (DataTable dt = new DataTable())
                {
                    string Query = "selecionar_treinamentos";
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
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
        #endregion fim

        #region Atualizar treinamentos
        public void Atualizar_Treinamentos(e_comum_treinamentos treinamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_treinamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_treinamento", treinamentos.id_treinamento);
                    cmd.Parameters.AddWithValue("@id_departamento", treinamentos.id_departamento);
                    cmd.Parameters.AddWithValue("@id_investigador", treinamentos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", treinamentos.id_usuario);
                    cmd.Parameters.AddWithValue("@titulo", treinamentos.titulo);
                    cmd.Parameters.AddWithValue("@descricao", treinamentos.descricao);
                    cmd.Parameters.AddWithValue("@data_inicio", treinamentos.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", treinamentos.data_fim);
                    cmd.Parameters.AddWithValue("@data_atualizacao", treinamentos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion fim

        #region Eliminar treinamentos
        public void Eliminar_Treinamentos(e_comum_treinamentos treinamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_treinamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_treinamento", treinamentos.id_treinamento);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion fim
    }
}
