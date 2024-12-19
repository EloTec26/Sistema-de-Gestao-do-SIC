using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;


namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_bairro_ruas
    {
        dados_pesquisar_bairros_ruas p_Ruas_Bairro = new dados_pesquisar_bairros_ruas();
        public System.Data.DataTable pesquisar_bairro_ruas(string chave)
        {
               return p_Ruas_Bairro.pesquisar_Bairro_Ruas(chave);
        }
    }
}
