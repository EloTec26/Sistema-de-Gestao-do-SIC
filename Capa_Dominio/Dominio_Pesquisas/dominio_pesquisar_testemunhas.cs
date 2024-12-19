using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_testemunhas
    {
        dados_pesquisar_testemunhas p_Testemunhas = new dados_pesquisar_testemunhas();
        public DataTable pesquisar_Testemunha(string chave)
        {
            return p_Testemunhas.pesquisar_Testemunhas(chave);
        }
    }
}
