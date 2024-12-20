using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas; 

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_treinamentos
    {
        dados_pesquisar_treinamentos p_Treinamento = new dados_pesquisar_treinamentos();
        public System.Data.DataTable pesquisar_Treinamentos (string chave)
        {
            return p_Treinamento.pesquisar_Treinamento(chave);
        }
    }
}
