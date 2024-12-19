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
    public class dados_cursos : conexao_sql
    {
        public DataTable selecionar_cursos_combo_box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from curso_tbl", connection))
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

        public DataTable selecionar_cursos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt =new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand ("selecionar_cursos", connection))
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

        public void inserir_cursos(e_comum_cursos cursos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                
                using (SqlCommand cmd = new SqlCommand("inserir_cursos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nome", cursos.nome);
                    cmd.Parameters.AddWithValue("@data_registro", cursos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", cursos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void atualizar_cursos(e_comum_cursos cursos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_cursos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_curso", cursos.id_curso);
                    cmd.Parameters.AddWithValue("@nome", cursos.nome);
                    cmd.Parameters.AddWithValue("@data_atualizacao", cursos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_cursos(e_comum_cursos cursos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_cursos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_curso", cursos.id_curso);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
