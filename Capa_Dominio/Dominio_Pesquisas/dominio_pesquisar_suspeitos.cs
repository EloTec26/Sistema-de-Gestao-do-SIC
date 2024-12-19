using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_suspeitos
    {
        dados_pesquisar_suspeitos p_suspeitos = new dados_pesquisar_suspeitos();
        public System.Data.DataTable pesquisar_Suspeito(string pesquisar)
        {
            return p_suspeitos.pesquisar_Suspeitos(pesquisar);
        }
    }
}
