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
            return new SqlConnection("Data Source=SERAFIIM;Initial Catalog=sic_menongue;Integrated Security=True;") ;
        }
    }
}
