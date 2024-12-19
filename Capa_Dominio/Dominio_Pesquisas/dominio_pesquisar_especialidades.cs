using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_especialidades
    {
        dados_pesquisar_especialidades p_Especialidades = new dados_pesquisar_especialidades();
        public System.Data.DataTable pesquisar_Especialidades(string chave)
        {
            return p_Especialidades.pesquisar_Especialidades(chave);
        }
    }
}
