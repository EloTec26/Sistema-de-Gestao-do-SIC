using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_afastamentos
    {
        dados_pesquisar_afastamentos pesquisar_Afastamentos = new dados_pesquisar_afastamentos();
        public DataTable pesquisar_Afastamento (string chave)
        {
            return pesquisar_Afastamentos.pesquisar_Afastamentos(chave);
        }
    }
}
