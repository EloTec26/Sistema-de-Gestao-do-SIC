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
    public class dados_niveis_academicos : conexao_sql
    {
        #region Selecionar os niveis academicos
        public DataTable selecionar_niveis_academicos_Combo_Box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from nivel_academico_tbl", connection))
                    {
                        //cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable selecionar_niveis_academicos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_nivel_academicos", connection))
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

        #region Registrar os niveis academicos
        public void inserir_nivel_academicos (e_comum_nivel_academicos nivel_Academicos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("inserir_nivel_academicos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nome", nivel_Academicos.nome);
                    cmd.Parameters.AddWithValue("@data_registro", nivel_Academicos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", nivel_Academicos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Atualizar os niveis academicos
        public void atualizar_nivel_academicos (e_comum_nivel_academicos nivel_Academicos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_nivel_academicos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_nivel_academico", nivel_Academicos.id_nivel_academico);
                    cmd.Parameters.AddWithValue("@nome", nivel_Academicos.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", nivel_Academicos.data_atualizacao);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Eliminar os niveis academicos
        public void eliminar_nivel_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_nivel_academico", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_nivel_academico", nivel_Academicos.id_nivel_academico);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
