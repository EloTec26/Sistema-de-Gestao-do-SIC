using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Comum.Entidades;
using Capa_Dados;

namespace Capa_Dominio
{
    public class dominio_investigadores
    {
        dados_investigadores d_investigadores = new dados_investigadores();
        public DataTable selecionar_investigadores_combobox()
        {
            return d_investigadores.selecionar_investigadores_combobox();
        }
        public DataTable selecionar_investigadores()
        {
            return d_investigadores.selecionar_investigadores();
        }
        public void inserir_investigadores(e_comum_investigadores investigadores)
        {
            d_investigadores.inserir_investigadores(investigadores);
        }
        public void atualizar_investigadores(e_comum_investigadores investigadores)
        {
            d_investigadores.atualizar_investigadores(investigadores);
        }
        public void eliminar_investigadores(e_comum_investigadores investigadores)
        {
            d_investigadores.eliminar_investigadores(investigadores);
        }
    }
}
