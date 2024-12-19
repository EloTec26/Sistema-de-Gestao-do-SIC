using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;


namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_provincias
    {
        dados_pesquisar_provincias p_provincias = new dados_pesquisar_provincias();
        public System.Data.DataTable pesquisar_provincias(string pesquisar)
        {
            return p_provincias.pesquisar_provincias(pesquisar);
        }
    }
}
