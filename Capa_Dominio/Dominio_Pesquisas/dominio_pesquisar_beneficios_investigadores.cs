using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    
    public class dominio_pesquisar_beneficios_investigadores
    {
        dados_pesquisar_beneficos_investigadores p_Pesquisar_Beneficos_Investigadores = new dados_pesquisar_beneficos_investigadores();
        public DataTable pesquisar_Beneficos_Investigadores(string pesquisar)
        {
            return p_Pesquisar_Beneficos_Investigadores.pesquisar_Ieneficios_Investigadores(pesquisar);
        }
    }
}
