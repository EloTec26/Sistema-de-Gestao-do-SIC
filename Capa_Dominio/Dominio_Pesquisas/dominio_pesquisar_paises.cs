using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_paises
    {
        dados_pesquisar_paises pesquisar_Paises = new dados_pesquisar_paises();
        public DataTable pesquisar_paises(string pesquisar)
        {
            return pesquisar_Paises.pesquisar_paises(pesquisar);
        }
    }
}
