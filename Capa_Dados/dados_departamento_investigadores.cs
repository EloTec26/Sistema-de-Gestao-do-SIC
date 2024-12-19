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
    public class dados_departamento_investigadores : conexao_sql
    {
        public DataTable selecionar_departamento_investigadores()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_departamento_investigadores", connection))
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

        public void inserir_departamentos_Investigadores(e_comum_departamentos_investigadores  departamentos_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_departamento_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_investigador", departamentos_Investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_departamento", departamentos_Investigadores.id_departamento);
                    cmd.Parameters.AddWithValue("@id_usuario", departamentos_Investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@data_registro", departamentos_Investigadores.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", departamentos_Investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_departamentos_investigadores(e_comum_departamentos_investigadores departamentos_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_departamento_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_departamento_investigador", departamentos_Investigadores.id_departamento_investigador);
                    cmd.Parameters.AddWithValue("@id_investigador", departamentos_Investigadores.id_investigador);
                    cmd.Parameters.AddWithValue("@id_departamento", departamentos_Investigadores.id_departamento);
                    cmd.Parameters.AddWithValue("@id_usuario", departamentos_Investigadores.id_usuario);
                    cmd.Parameters.AddWithValue("@data_atualizacao", departamentos_Investigadores.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_departamento_investigadores(e_comum_departamentos_investigadores departamentos_Investigadores)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_departamento_investigadores", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_departamento_investigador", departamentos_Investigadores.id_departamento_investigador);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
