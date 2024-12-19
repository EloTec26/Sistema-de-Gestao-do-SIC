using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_casos
    {
        dados_pesquisar_casos P_Casos = new dados_pesquisar_casos();
        public System.Data.DataTable pesquisar_Caso(string chave)
        {
            return P_Casos.pesquisar_Casos(chave);
        }
    }
}
