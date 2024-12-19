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
    public class dados_provincias: conexao_sql
    {

        #region Selecionar os dados no banco de dados
        #region Selecionar os dados no banco de dados comboBox
        public DataTable selecionar_provincia_comboBox_filtro(int idPaises)
        {
            DataTable dt = new DataTable();
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("select id_provincia, nome from provincia_tbl where id_pais=@idPaises", connection))
                {
                    cmd.Parameters.AddWithValue("@idPaises", idPaises);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
        public DataTable selecionar_provincia_comboBox()
        {
            DataTable dt = new DataTable();
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(" select* from provincia_tbl", connection))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
        #endregion
        public DataTable selecionar_provincia()
        {
            DataTable dt = new DataTable();
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("selecionar_provincias", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
        #endregion
        #region Registrar os dados no banco de dados
        public void registrar_provincia(e_comum_provincias provincias)
        {
            using (var connection = conectar())
            {
                connection.Open();
                string Query = "inserir_provincias";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_pais", provincias.id_pais);
                    cmd.Parameters.AddWithValue("@nome", provincias.nome);
                    cmd.Parameters.AddWithValue("@data_registro", provincias.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", provincias.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region Atualizar os registros no banco de dados
        public void atualizar_provincias(e_comum_provincias provincias)
        {
            using (var connection = conectar())
            {
                connection.Open();
                string Query = "atualizar_provincias";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_provincia", provincias.id_provincia);
                    cmd.Parameters.AddWithValue("@id_pais", provincias.id_pais);
                    cmd.Parameters.AddWithValue("@nome", provincias.nome);
                    cmd.Parameters.AddWithValue("@data_registro", provincias.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", provincias.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region Eliminar os registro no banco de dados
        public void eliminar_provincia(e_comum_provincias provincias)
        {
            using (var connection = conectar())
            {
                connection.Open();
                string Query = "eliminar_provincias";
                using (SqlCommand cmd = new SqlCommand (Query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_provincia", provincias.id_provincia);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
