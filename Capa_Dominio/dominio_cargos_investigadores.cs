using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;


namespace Capa_Dominio
{
    public class dominio_cargos_investigadores
    {
        dados_cargos_investigadores d_Cargos_Investigadores = new dados_cargos_investigadores();
        public DataTable selcionar_Cargos_Investigadores()
        {
            return d_Cargos_Investigadores.selecionar_cargos_investigadores();
        }
        public void inserir_Cargos_Investigadores(e_comum_cargos_investigadores cargos_Investigadores)
        {
            d_Cargos_Investigadores.inserir_cargos_investigadores(cargos_Investigadores);
        }
        public void atualizar_Cargos_Investigadores(e_comum_cargos_investigadores cargos_Investigadores)
        {
            d_Cargos_Investigadores.atualizar_cargos_investigadores(cargos_Investigadores);
        }
        public void eliminar_Cargos_Investigadores(e_comum_cargos_investigadores cargos_Investigadores)
        {
            d_Cargos_Investigadores.eliminar_cargos_investigadores(cargos_Investigadores);
        }
    }
}
