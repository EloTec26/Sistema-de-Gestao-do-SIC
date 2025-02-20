using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dados.Conexao
{
    public class conexao_sql
    {
        protected SqlConnection conectar()
        {
            //try
            //{
                return new SqlConnection("Data Source=SERAFIIM;Initial Catalog=sic_menongue;Integrated Security=True;");
            //}
            //catch (Exception ex)
            //{

            //    throw new ArgumentException ("Erro ao conectar-se!\nParece que o servidor não foi encontrado\nou está indisponível." +ex.Message);
            //}
        }
    }
}
