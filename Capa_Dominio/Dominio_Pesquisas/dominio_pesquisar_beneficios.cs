using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_beneficios
    {
        dados_pesquisar_beneficios p_Beneficios = new dados_pesquisar_beneficios();
        public System.Data.DataTable pesquisar_Beneficos(string pesquisar)
        {
            return p_Beneficios.pesquisar_Beneficios(pesquisar);
        }
    }
}
