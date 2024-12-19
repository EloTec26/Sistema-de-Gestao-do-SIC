using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_cargos
    {
        dados_pesquisar_cargos p_Cargos = new dados_pesquisar_cargos(); 
        public DataTable pesquisar_cargos(string pesquisar)
        {
            return p_Cargos.pesquisar_Cargos(pesquisar);
        }
    }
}
