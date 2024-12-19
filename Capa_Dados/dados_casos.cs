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
    public class dados_casos : conexao_sql
    {
        public DataTable selecionar_casos_Combo_Box()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from caso_tbl", connection))
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
        public DataTable selecionar_casos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_casos", connection))
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
        public void inserir_casos(e_comum_casos casos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand ("inserir_casos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_investigador", casos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_departamento", casos.id_departamento);
                    cmd.Parameters.AddWithValue("@id_usuario", casos.id_usuario);
                    cmd.Parameters.AddWithValue("@titulo", casos.titulo);
                    cmd.Parameters.AddWithValue("@data_abertura", casos.data_abertura);
                    cmd.Parameters.AddWithValue("@data_fechamento", casos.data_fechamento);
                    cmd.Parameters.AddWithValue("@estado", casos.estado);
                    cmd.Parameters.AddWithValue("@descricao", casos.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", casos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", casos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_casos(e_comum_casos casos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("atualizar_casos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_caso", casos.id_caso);
                    cmd.Parameters.AddWithValue("@id_investigador", casos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_departamento", casos.id_departamento);
                    cmd.Parameters.AddWithValue("@id_usuario", casos.id_usuario);
                    cmd.Parameters.AddWithValue("@titulo", casos.titulo);
                    cmd.Parameters.AddWithValue("@data_abertura", casos.data_abertura);
                    cmd.Parameters.AddWithValue("@data_fechamento", casos.data_fechamento);
                    cmd.Parameters.AddWithValue("@estado", casos.estado);
                    cmd.Parameters.AddWithValue("@descricao", casos.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", casos.data_atualizacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminar_casos(e_comum_casos casos)
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("eliminar_casos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_caso", casos.id_caso);
                  
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
