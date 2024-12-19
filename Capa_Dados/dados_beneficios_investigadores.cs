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
    public class dados_beneficios_investigadores : conexao_sql
    {
        #region Método para selecionar
        public DataTable selecionar_beneficios_investigadores()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_beneficios_investigadores", connection))
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

        #region Método para inserir
        public void registrar_beneficios_investigadores(e_comum_beneficios_investigadores beneficios_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_beneficios_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@id_beneficio", beneficios_Investigadores.id_beneficio);
                    cmd.Parameters.AddWithValue("@id_investigador", beneficios_Investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", beneficios_Investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@data_inicio", beneficios_Investigadores.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", beneficios_Investigadores.data_fim);
                    cmd.Parameters.AddWithValue("@data_registro", beneficios_Investigadores.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", beneficios_Investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Método para atualizar
        public void atualizar_beneficios_investigadores(e_comum_beneficios_investigadores beneficios_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_beneficios_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_beneficio_investigador", beneficios_Investigadores.id_beneficio_investigador);
                    cmd.Parameters.AddWithValue("@id_beneficio", beneficios_Investigadores.id_beneficio);
                    cmd.Parameters.AddWithValue("@id_investigador", beneficios_Investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", beneficios_Investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@data_inicio", beneficios_Investigadores.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", beneficios_Investigadores.data_fim);
                    cmd.Parameters.AddWithValue("@data_atualizacao", beneficios_Investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Método para eliminar
        public void eliminar_beneficios_investigadores(e_comum_beneficios_investigadores beneficios_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_beneficios_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_beneficio_investigador", beneficios_Investigadores.id_beneficio_investigador);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
