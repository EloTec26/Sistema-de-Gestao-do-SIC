using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Dados.Conexao;
using Capa_Comum.Entidades;

namespace Capa_Dados
{
    public class dados_municipios : conexao_sql
    {
        #region Selecionar os municipios
        #region Selecionar os municipios para o comboBox
        //public DataTable selecionar_municipios_combobox_filtro(int idProvincia)
        //{
        //    using (var connection = conectar()) 
        //    {
        //        connection.Open();
        //        using (DataTable dt = new DataTable())
        //        {
        //            using (SqlCommand cmd = new SqlCommand("select id_municipio, nome from municipio_tbl where id_provincia=@idProvincia", connection))
        //            {
        //                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
        //                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //                {
        //                    sda.Fill(dt);

        //                    return dt;
        //                }
        //            }
        //        }
        //    }
        //}
        public DataTable selecionar_municipios_combobox()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from municipio_tbl", connection))
                    {
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
        public DataTable selecionar_municipios()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd  = new SqlCommand("selecionar_municipios", connection))
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

        #region Cadastrar os municipios
        public void registrar_municipios(e_comum_municipios municipios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_municipios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_provincia", municipios.id_provincia);
                    cmd.Parameters.AddWithValue("@nome", municipios.nome);
                    cmd.Parameters.AddWithValue("@data_registro", municipios.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", municipios.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Atualizar os municipios
        public void atualizar_municipios (e_comum_municipios municipios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("atualizar_municipios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_municipio", municipios.id_municipio);
                    cmd.Parameters.AddWithValue("@id_provincia", municipios.id_provincia);
                    cmd.Parameters.AddWithValue("@nome", municipios.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", municipios.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Eliminar os municipios
        public void eliminar_municipios (e_comum_municipios municipios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("eliminar_municipios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_municipio", municipios.id_municipio);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
