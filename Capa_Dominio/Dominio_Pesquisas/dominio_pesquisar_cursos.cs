using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_cursos
    {
        dados_pesquisar_cursos P_Cursos = new dados_pesquisar_cursos();
        public System.Data.DataTable pesquisar_Cursos(string chave)
        {
            return P_Cursos.pesquisar_Cursos(chave);
        }
    }
}
