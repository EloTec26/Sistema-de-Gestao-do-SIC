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
    public class dados_horas_extras : conexao_sql
    {
        public DataTable selecionar_horas_extras()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_horas_extras", connection))
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

        public void inserir_horas_extras(e_comum_horas_extras horas_Extras)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_horas_extras", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_investigador", horas_Extras.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", horas_Extras.id_usuario);
                    cmd.Parameters.AddWithValue("@data_trabalho", horas_Extras.data_trabalho);
                    cmd.Parameters.AddWithValue("@horas_trabalhadas", horas_Extras.horas_trabalhadas);
                    cmd.Parameters.AddWithValue("@tipo_horas", horas_Extras.tipo_horas);
                    cmd.Parameters.AddWithValue("@data_registro", horas_Extras.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", horas_Extras.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_horas_extras (e_comum_horas_extras horas_Extras)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_horas_extras", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@id_hora_extra", horas_Extras.id_hora_extra);
                    cmd.Parameters.AddWithValue("@id_investigador", horas_Extras.id_investigador);
                    cmd.Parameters.AddWithValue("@id_usuario", horas_Extras.id_usuario);
                    cmd.Parameters.AddWithValue("@data_trabalho", horas_Extras.data_trabalho);
                    cmd.Parameters.AddWithValue("@horas_trabalhadas", horas_Extras.horas_trabalhadas);
                    cmd.Parameters.AddWithValue("@tipo_horas", horas_Extras.tipo_horas);
                    cmd.Parameters.AddWithValue("@data_atualizacao", horas_Extras.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_horas_extras (e_comum_horas_extras horas_Extras)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_horas_extras", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_hora_extra", horas_Extras.id_hora_extra);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
