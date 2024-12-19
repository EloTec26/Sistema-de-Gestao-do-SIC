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
    public class dados_eventos_casos : conexao_sql
    {
        public DataTable selecionar_eventos_casos()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (DataTable dt = new DataTable())
                {
                    using (SqlCommand cmd = new SqlCommand("selecionar_evento_casos", connection))
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

        public void inserir_eventos_casos(e_comum_eventos_casos eventos_Casos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("inserir_enventos_casos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_caso", eventos_Casos.id_caso);
                    cmd.Parameters.AddWithValue("@id_investigador", eventos_Casos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_vitima", eventos_Casos.id_vitima);
                    cmd.Parameters.AddWithValue("@id_testemunha", eventos_Casos.id_testemunha);
                    cmd.Parameters.AddWithValue("@id_usuario", eventos_Casos.id_usuario);
                    cmd.Parameters.AddWithValue("@data_evento", eventos_Casos.data_evento);
                    cmd.Parameters.AddWithValue("@tipo_evento", eventos_Casos.tipo_evento);
                    cmd.Parameters.AddWithValue("@descricao", eventos_Casos.descricao);
                    cmd.Parameters.AddWithValue("@data_registro", eventos_Casos.data_registro);
                    cmd.Parameters.AddWithValue("@data_atualizacao", eventos_Casos.data_atualizacao);
                    cmd.Parameters.AddWithValue("@id_suspeito", eventos_Casos.id_suspeito);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void atualizar_eventos_casos(e_comum_eventos_casos eventos_Casos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("atualizar_enventos_casos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_evento_caso", eventos_Casos.id_evento_caso);
                    cmd.Parameters.AddWithValue("@id_caso", eventos_Casos.id_caso);
                    cmd.Parameters.AddWithValue("@id_investigador", eventos_Casos.id_investigador);
                    cmd.Parameters.AddWithValue("@id_vitima", eventos_Casos.id_vitima);
                    cmd.Parameters.AddWithValue("@id_testemunha", eventos_Casos.id_testemunha);
                    cmd.Parameters.AddWithValue("@id_usuario", eventos_Casos.id_usuario);
                    cmd.Parameters.AddWithValue("@data_evento", eventos_Casos.data_evento);
                    cmd.Parameters.AddWithValue("@tipo_evento", eventos_Casos.tipo_evento);
                    cmd.Parameters.AddWithValue("@descricao", eventos_Casos.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", eventos_Casos.data_atualizacao);
                    cmd.Parameters.AddWithValue("@id_suspeito", eventos_Casos.id_suspeito);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void eliminar_eventos_casos(e_comum_eventos_casos eventos_Casos)
        {
            using (var connection = conectar())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("eliminar_evento_casos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_evento_caso", eventos_Casos.id_evento_caso);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
