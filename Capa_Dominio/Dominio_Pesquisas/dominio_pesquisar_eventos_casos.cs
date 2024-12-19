using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;


namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_eventos_casos
    {
        dados_pesquisar_eventos_casos P_Eventos_Casos = new dados_pesquisar_eventos_casos();
        public System.Data.DataTable pesquisar_Eventos_Casos(string chave)
        {
            return P_Eventos_Casos.pesquisar_Eventos_Casos(chave);
        }
    }
}
