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
    public class dados_cargos_investigadores : conexao_sql
    {
        #region  Método para selecionar
       
        public DataTable selecionar_cargos_investigadores()
        {
            using (var connection  = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_cargos_investigadores", connection))
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

        #region  Método para inserir
        public void inserir_cargos_investigadores(e_comum_cargos_investigadores cargos_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_cargos_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cargo", cargos_Investigadores.id_cargo);
                    cmd.Parameters.AddWithValue("@id_investigador", cargos_Investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", cargos_Investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@data_registro", cargos_Investigadores.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", cargos_Investigadores.data_atualizacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region  Método para atualizar
        public void atualizar_cargos_investigadores(e_comum_cargos_investigadores cargos_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_cargos_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cargo_investigador", cargos_Investigadores.id_cargo_investigador);
                    cmd.Parameters.AddWithValue("@id_cargo", cargos_Investigadores.id_cargo);
                    cmd.Parameters.AddWithValue("@id_investigador", cargos_Investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", cargos_Investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@data_atualizacao", cargos_Investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region  Método para eliminar
        public void eliminar_cargos_investigadores(e_comum_cargos_investigadores cargos_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_cargo_investigador", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_cargo_investigador", cargos_Investigadores.id_cargo_investigador);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
