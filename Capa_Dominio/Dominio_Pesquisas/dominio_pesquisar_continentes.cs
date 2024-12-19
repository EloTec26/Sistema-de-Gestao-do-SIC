using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_continentes
    {
        dados_pesquisar_continentes pesquisar_Continentes = new dados_pesquisar_continentes();
        public DataTable pesquisar_continentes(string chave)
        {
            return pesquisar_Continentes.dados_pesquisar_continetes(chave);
        }
    }
}
