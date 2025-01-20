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
    public class dados_paises : conexao_sql
    {
        #region selecionar os países
        //public DataTable selecionar_paises_comboBox_filtro(int idContinente)
        //{
        //    using (var connection = conectar())
        //    {
        //        connection.Open();
        //        using (DataTable dt = new DataTable())
        //        {
        //            using (SqlCommand cmd = new SqlCommand("SELECT id_pais, nome FROM Pais_tbl WHERE id_continente = @idContinente", connection))
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                cmd.Parameters.AddWithValue("@idContinente", idContinente);
        //                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //                {
        //                    sda.Fill(dt);
        //                    return dt;
        //                }
        //            }
        //        }
        //    }
        //}

        public DataTable selecionar_paises_comboBox()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM pais_tbl", connection))
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

        #endregion
        #region selecionar os países
        public DataTable selecionar_paises()
        {
            using (var connection = conectar())
            {
                connection.Open(); 
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_paises", connection))
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

        #region cadastrar os países
        public void registrar_paises (e_comum_paises paises)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_paises", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_continente", paises.id_continente);
                    cmd.Parameters.AddWithValue("@nome", paises.nome);
                    cmd.Parameters.AddWithValue("@data_registro", paises.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", paises.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region atualizar os países
        public void atualizar_pais(e_comum_paises paises)
        {
            using (var connection = conectar())
            {
                connection.Open();
                //string Query = "update pais_tbl set id_continente=@id_continente, nome=@nome, data_registro=@data_registro, data_atualizacao=@data_atualizacao where id_pais=@id_pais";
                using (SqlCommand cmd = new SqlCommand ("atualizar_paises", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pais", paises.id_pais);
                    cmd.Parameters.AddWithValue("@id_continente", paises.id_continente);
                    cmd.Parameters.AddWithValue("@nome", paises.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", paises.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region eliminar os países
        public void eliminar_paises(e_comum_paises paises)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_paises",connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pais", paises.id_pais);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
