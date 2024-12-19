using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_patentes
    {
        dados_pesquisar_patentes p_Patentes = new dados_pesquisar_patentes();
        public System.Data.DataTable pesquisar_Patentes(string pesquisar)
        {
            return p_Patentes.pesquisar_Patentes(pesquisar);
        }
    }
}
