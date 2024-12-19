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
    public class dados_departamentos : conexao_sql
    {

        public DataTable selecionar_departamentos_Combo_Box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from departamento_tbl", connection))
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
        public DataTable selecionar_departamentos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_departamentos", connection))
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

        public void inserir_departamentos (e_comum_departamentos departamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_departamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", departamentos.id_usuario);
                    cmd.Parameters.AddWithValue("@nome", departamentos.nome);
                    cmd.Parameters.AddWithValue("@descricao", departamentos.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", departamentos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", departamentos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_departamentos(e_comum_departamentos departamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_departamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_departamento", departamentos.id_departamento);
                    cmd.Parameters.AddWithValue("@id_usuario", departamentos.id_usuario);
                    cmd.Parameters.AddWithValue("@nome", departamentos.nome);
                    cmd.Parameters.AddWithValue("@descricao", departamentos.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", departamentos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_departamentos (e_comum_departamentos departamentos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_departamentos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_departamento", departamentos.id_departamento);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
