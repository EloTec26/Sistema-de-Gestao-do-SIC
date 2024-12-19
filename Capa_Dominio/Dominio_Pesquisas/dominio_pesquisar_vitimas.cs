using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_vitimas
    {
        dados_pesquisar_vitimas p_Vitimas = new dados_pesquisar_vitimas();
        public System.Data.DataTable pesquisar_Vitimas(string pesquisar)
        {
            return p_Vitimas.pesquisar_Vitimas(pesquisar);
        }
    }
}
