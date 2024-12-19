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
    public class dados_beneficios : conexao_sql
    {
        #region Método para selecionar
        public DataTable selecionar_beneficios_Combo_Box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from beneficio_tbl", connection))
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
        public DataTable selecionar_beneficios()
        {
            using (var connection  = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_beneficios", connection))
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
        public void registrar_beneficios (e_comum_beneficios beneficios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_beneficios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", beneficios.id_usuario);
                    cmd.Parameters.AddWithValue("@nome", beneficios.nome);
                    cmd.Parameters.AddWithValue("@descricao", beneficios.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", beneficios.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", beneficios.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Método para atualizar
        public void atualizar_beneficios(e_comum_beneficios beneficios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_beneficios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_beneficio", beneficios.id_beneficio);
                    cmd.Parameters.AddWithValue("@id_usuario", beneficios.id_usuario);
                    cmd.Parameters.AddWithValue("@nome", beneficios.nome);
                    cmd.Parameters.AddWithValue("@descricao", beneficios.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", beneficios.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Método para eliminar
        public void eliminar_beneficios(e_comum_beneficios beneficios)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_beneficios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_beneficio", beneficios.id_beneficio);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
