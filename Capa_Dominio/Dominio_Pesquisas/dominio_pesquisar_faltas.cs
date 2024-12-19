using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_faltas
    {
        dados_pesquisar_faltas p_Faltas = new dados_pesquisar_faltas ();
        public DataTable pesquisar_Faltas(string pesquisar)
        {
            return p_Faltas.pesquisar_Faltas_Investigadores(pesquisar);
        }
    }
}
