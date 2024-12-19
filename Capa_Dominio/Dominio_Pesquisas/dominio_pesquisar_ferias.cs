using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_ferias
    {
        dados_pesquisar_ferias p_Ferias = new dados_pesquisar_ferias();
        public DataTable pesquisar_Ferias(string pesquisar)
        {
            return p_Ferias.pesquisar_Ferias(pesquisar);
        }
    }
}
