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
    public class dados_bairro_rua : conexao_sql
    {

        #region Selecionar os bairros_ruas
        //public DataTable selecionar_bairro_ruas_combobox_filtro(int IdMunicipio)
        //{
        //    using (var connection = conectar())
        //    {
        //        connection.Open();
        //        using (DataTable dt = new DataTable())
        //        {
        //            using (SqlCommand cmd = new SqlCommand("select id_bairro_rua, nome from bairro_rua_tbl where id_municipio=@IdMunicipio", connection))
        //            {
        //                cmd.Parameters.AddWithValue("@IdMunicipio", IdMunicipio);
        //                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //                {
        //                    sda.Fill(dt);
        //                    return dt;
        //                }
        //            }
        //        }
        //    }
        //}
        public DataTable selecionar_bairro_ruas_combobox()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from bairro_rua_tbl", connection))
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
        public DataTable selecionar_bairro_ruas()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_bairros_ruas", connection))
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

        #region Registrar os bairros_ruas
        public void registrar_bairros_ruas(e_comum_bairro_rua bairro_rua)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd  = new SqlCommand ("inserir_bairros_ruas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_municipio", bairro_rua.id_municipio);
                    cmd.Parameters.AddWithValue("@nome", bairro_rua.nome);
                    cmd.Parameters.AddWithValue("@data_registro", bairro_rua.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", bairro_rua.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion


        #region Atualizar os bairros_ruas
        public void atualizar_bairros_ruas(e_comum_bairro_rua bairro_rua)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_bairros_ruas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_bairro_rua", bairro_rua.id_bairro_rua);
                    cmd.Parameters.AddWithValue("@id_municipio", bairro_rua.id_municipio);
                    cmd.Parameters.AddWithValue("@nome", bairro_rua.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", bairro_rua.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Eliminar os bairros_ruas
        public void eliminar_bairro_rua(e_comum_bairro_rua bairro_rua)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_bairros_ruas", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_bairro_rua", bairro_rua.id_bairro_rua);
                   
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
