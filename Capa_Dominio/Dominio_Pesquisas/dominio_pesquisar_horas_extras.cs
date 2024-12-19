using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_horas_extras
    {
        dados_pesquisar_horas_extras p_h_Extras = new dados_pesquisar_horas_extras();
        public System.Data.DataTable pesquisar_Horas_Extras(string chave)
        {
            return p_h_Extras.pesquisar_Horas_Extras(chave);
        }
    }
}
