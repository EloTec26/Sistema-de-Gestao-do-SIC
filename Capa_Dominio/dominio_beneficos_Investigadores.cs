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
    public class dominio_beneficos_Investigadores
    {
        dados_beneficios_investigadores d_Beneficios_Investigadores = new dados_beneficios_investigadores();
     
        public DataTable selecionar_Beneficios_Investigadores()
        {
            return d_Beneficios_Investigadores.selecionar_beneficios_investigadores();
        }
        public void inserir_Beneficios_Investigadores(e_comum_beneficios_investigadores beneficios_Investigadores)
        {
            d_Beneficios_Investigadores.registrar_beneficios_investigadores(beneficios_Investigadores);
        }
        public void atualizar_Beneficios_Investigadores(e_comum_beneficios_investigadores beneficios_Investigadores)
        {
            d_Beneficios_Investigadores.atualizar_beneficios_investigadores(beneficios_Investigadores);
        }
        public void eliminar_Beneficios_Investigadores(e_comum_beneficios_investigadores beneficios_Investigadores)
        {
            d_Beneficios_Investigadores.eliminar_beneficios_investigadores(beneficios_Investigadores);
        }
    }
}
