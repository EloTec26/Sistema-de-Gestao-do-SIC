using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_ferias
    {
        dados_ferias d_Dados_Ferias = new dados_ferias();
        public DataTable selecionar_Ferias()
        {
            return d_Dados_Ferias.selecionar_ferias();
        }
        public void inserir_Ferias(e_comum_ferias ferias)
        {
            d_Dados_Ferias.inserir_ferias(ferias);
        }
        public void atualizar_Ferias(e_comum_ferias ferias)
        {
            d_Dados_Ferias.atualizar_ferias(ferias);
        }
        public void eliminar_Ferias(e_comum_ferias ferias)
        {
            d_Dados_Ferias.eliminar_ferias(ferias);
        }
    }
}
