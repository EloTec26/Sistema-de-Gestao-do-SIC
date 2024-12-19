using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
   
    public class dominio_pesquisar_departamentos
    {
        dados_pesquisar_departamentos p_Departamentos = new dados_pesquisar_departamentos();
        public System.Data.DataTable pesquisar_Departamentos (string pesquisar)
        {
            return p_Departamentos.pesquisar_Departamentos(pesquisar);
        }
    }
}
