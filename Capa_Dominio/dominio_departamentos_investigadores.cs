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
    public class dominio_departamentos_investigadores
    {
        dados_departamento_investigadores d_Departamentos_Investigadores = new dados_departamento_investigadores();
        public DataTable selecionar_Departamentos_Investigadores()
        {
            return d_Departamentos_Investigadores.selecionar_departamento_investigadores();
        }
        public void inserir_Departamentos_Investigadores(e_comum_departamentos_investigadores departamentos_Investigadores)
        {
            d_Departamentos_Investigadores.inserir_departamentos_Investigadores(departamentos_Investigadores);
        }
        public void atualizar_Departamentos_Investigadores(e_comum_departamentos_investigadores departamentos_Investigadores)
        {
            d_Departamentos_Investigadores.atualizar_departamentos_investigadores(departamentos_Investigadores);
        }
        public void eliminar_Departamentos_Investigadores(e_comum_departamentos_investigadores departamentos_Investigadores)
        {
            d_Departamentos_Investigadores.eliminar_departamento_investigadores(departamentos_Investigadores);
        }
    }
}
