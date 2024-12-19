using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Comum.Entidades;
using Capa_Dados.Conexao;

namespace Capa_Dados
{
    public class dados_continentes : conexao_sql
    {
        #region Selecionar os continentes no banco de dados
        public DataTable selecionar_continentes_comboboxs()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from continente_tbl", connection))
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
        public DataTable selecionar_continentes()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd  = new SqlCommand ("selecionar_continentes", connection))
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

        #region Registrar os continentes no banco de dados
        public void registrar_continentes(e_comum_continentes continentes)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("inserir_continentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", continentes.nome);
                    cmd.Parameters.AddWithValue("@data_registro", continentes.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", continentes.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Atualizar os continentes no banco de dados
        public void atualizar_continentes(e_comum_continentes continentes)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd  = new SqlCommand("atualizar_continentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_continente", continentes.id_continente);
                    cmd.Parameters.AddWithValue("@nome", continentes.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", continentes.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Eliminar os continentes no banco de dados
        public void eliminar_continentes (e_comum_continentes continentes)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("eliminar_continentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_continente", continentes.id_continente);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
