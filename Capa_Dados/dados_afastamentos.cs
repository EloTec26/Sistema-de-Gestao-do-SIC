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
    public class dados_afastamentos : conexao_sql
    {
        #region Método para selecionar os afastamentos
        public DataTable selecionar_afastamentos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_afastamentos", connection))
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

        #region Método para registrar os afastamentos
        public void registrar_afastamentos(e_comum_afastamentos afastamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_afastamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_investigador", afastamentos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", afastamentos.id_usuario);
                    cmd.Parameters.AddWithValue("@data_inicio", afastamentos.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", afastamentos.data_fim);
                    cmd.Parameters.AddWithValue("@descricao", afastamentos.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", afastamentos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", afastamentos.data_atualizacao);
                    cmd.Parameters.AddWithValue("@estado", afastamentos.estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Método para atualizar os afastamentos
        public void atualizar_afastamentos(e_comum_afastamentos afastamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_afastamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_afastamento", afastamentos.id_afastamento);
                    cmd.Parameters.AddWithValue("@id_investigador", afastamentos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", afastamentos.id_usuario);
                    cmd.Parameters.AddWithValue("@data_inicio", afastamentos.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", afastamentos.data_fim);
                    cmd.Parameters.AddWithValue("@descricao", afastamentos.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", afastamentos.data_atualizacao);
                    cmd.Parameters.AddWithValue("@estado", afastamentos.estado);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Método para eliminar os afastamentos
        public void eliminar_afastamentos(e_comum_afastamentos afastamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_afastamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_afastamento", afastamentos.id_afastamento);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
