using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_municipios
    {
        dados_pesquisar_municipios p_Municipios = new dados_pesquisar_municipios();
        public System.Data.DataTable pesquisar_Municipios (string chave)
        {
            return p_Municipios.pesquisar_municipios(chave);
        }
    }
}
