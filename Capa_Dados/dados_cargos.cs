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
    public class dados_cargos : conexao_sql
    {

        public DataTable selecionar_Cargos__Combo_Box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from cargo_tbl", connection))
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
        public DataTable selecionar_cargos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_cargos", connection))
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
        public void registrar_cargos(e_comum_cargos cargos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("inserir_cargos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", cargos.nome);
                    cmd.Parameters.AddWithValue("@data_registro", cargos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", cargos.data_atualizacao);
                    cmd.Parameters.AddWithValue("@id_usuario", cargos.id_usuario);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_cargos(e_comum_cargos cargos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_cargos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cargo", cargos.id_cargo);
                    cmd.Parameters.AddWithValue("@nome", cargos.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", cargos.data_atualizacao);
                    cmd.Parameters.AddWithValue("@id_usuario", cargos.id_usuario);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_cargos(e_comum_cargos cargos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_cargos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cargo", cargos.id_cargo);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
