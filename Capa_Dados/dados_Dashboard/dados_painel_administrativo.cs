using Capa_Dados.Conexao;
using System;
using System.Data.SqlClient;

namespace Capa_Dados.dados_Dashboard
{
    public class dados_painel_administrativo : conexao_sql
    {
        public int ObterContagem(string tabela, string periodo)
        {
            int count = 0;
            string query = "";

            switch (periodo)
            {
                case "Hoje":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE CAST(data_registro AS DATE) = CAST(GETDATE() AS DATE)";
                    break;
                case "Há 7 dias":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro >= DATEADD(DAY, -7, GETDATE())";
                    break;
                case "Há 14 dias":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro >= DATEADD(DAY, -14, GETDATE())";
                    break;
                case "Há 1 mês":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro >= DATEADD(MONTH, -1, GETDATE())";
                    break;
                case "Há 2 meses":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro >= DATEADD(MONTH, -2, GETDATE())";
                    break;
                case "Há 6 meses":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro >= DATEADD(MONTH, -6, GETDATE())";
                    break;
                case "Há 1 ano":
                    query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro >= DATEADD(YEAR, -1, GETDATE())";
                    break;
                    // Adicionar mais casos conforme necessário
            }

            using (var connection = conectar())
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    count = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
            }
            return count;
        }

        public int ObterContagemPersonalizada(string tabela, DateTime dataInicial, DateTime dataFinal)
        {
            string query = $"SELECT COUNT(*) FROM {tabela} WHERE data_registro BETWEEN @DataInicial AND @DataFinal";
            int count = 0;

            using (var connection = conectar())
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                    cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                    connection.Open();
                    count = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
            }
            return count;
        }
    }
}

