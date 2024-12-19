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
    public class dados_especialidades : conexao_sql
    {
        public DataTable selecionar_especialidades_combobox_filtro(int IdCurso)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select id_especialidade, nome from especialidade_tbl where id_curso=@IdCurso", connection))
                    {
                        cmd.Parameters.AddWithValue("@IdCurso", IdCurso);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public DataTable selecionar_especialidades_combobox()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from especialidade_tbl", connection))
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
        public DataTable selecionar_especialidades()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_especialidades", connection))
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

        public void inserir_especialidades(e_comum_especialidades especialidades)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_especialidades", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nome", especialidades.nome);
                    cmd.Parameters.AddWithValue("@data_registro", especialidades.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", especialidades.data_atualizacao);
                    cmd.Parameters.AddWithValue("@id_curso", especialidades.id_curso);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_especialidades (e_comum_especialidades especialidades)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_especialidades", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_especialidade", especialidades.id_especialidade);
                    cmd.Parameters.AddWithValue("@nome", especialidades.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", especialidades.data_atualizacao);
                    cmd.Parameters.AddWithValue("@id_curso", especialidades.id_curso);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_especialidades (e_comum_especialidades especialidades)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_especialidade", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_especialidade", especialidades.id_especialidade);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
