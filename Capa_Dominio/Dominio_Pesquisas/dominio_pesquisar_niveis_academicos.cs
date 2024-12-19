using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_niveis_academicos
    {
        dados_pesquisar_niveis_academicos d_Pesquisar_Niveis_Academicos = new dados_pesquisar_niveis_academicos();
        public DataTable pesquisar_Niveis_Academicos(string pesquisar)
        {
            return d_Pesquisar_Niveis_Academicos.pesquisar_Niveis_Academicos(pesquisar);
        }
    }
}
