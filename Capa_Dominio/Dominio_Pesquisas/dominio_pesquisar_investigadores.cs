using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_investigadores
    {
        dados_pesquisar_investigadores p_Investigadores = new dados_pesquisar_investigadores();
        public DataTable pesquisar_Investigadores(string pesquisar)
        {
            return p_Investigadores.pesquisar_Investigadores(pesquisar);
        }
    }
}
