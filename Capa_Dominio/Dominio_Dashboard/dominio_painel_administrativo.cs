using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.dados_Dashboard;

namespace Capa_Dominio.Dominio_Dashboard
{
    public class dominio_painel_administrativo
    {
        private dados_painel_administrativo repositorio = new dados_painel_administrativo();

        public int ObterContagem(string tabela, string periodo)
        {
            return repositorio.ObterContagem(tabela, periodo);
        }
        public int ObterContagemPersonalizada(string tabela, DateTime dataInicial, DateTime dataFinal)
        {
            return repositorio.ObterContagemPersonalizada(tabela, dataInicial, dataFinal);
        }
    }
}
