using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_cargos_investigadores
    {
        dados_pesquisar_cargo_investigadores p_Cargos_Investigadores = new dados_pesquisar_cargo_investigadores();
        public DataTable pesquisar_Cargo_Investigadores (string pesquisar)
        {
            return p_Cargos_Investigadores.pesquisar_Cargos_Investigadores(pesquisar);
        }
    }
}
