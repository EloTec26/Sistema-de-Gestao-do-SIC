using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;


namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_evidencias
    {
        dados_pesquisar_evidencias p_Evidencias = new dados_pesquisar_evidencias();
        public System.Data.DataTable pesquisar_Envidencia(string pesquisar)
        {
            return p_Evidencias.pesquisar_Evidencias(pesquisar);
        }
    }
}
