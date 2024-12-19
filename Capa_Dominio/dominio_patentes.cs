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
    public class dominio_patentes
    {
        dados_patentes d_patentes = new dados_patentes();
        public DataTable selecionar_patentes_combobox()
        {
            return d_patentes.selecionar_patentes_combobox();
        }
        public DataTable selecionar_patentes()
        {
            return d_patentes.selecionar_patentes();
        }
        public void inserir_patentes(e_comum_patentes patentes)
        {
            d_patentes.inserir_patentes(patentes);
        }
        public void atualizar_patentes(e_comum_patentes patentes)
        {
            d_patentes.atualizar_patentes(patentes);
        }
        public void eliminar_patentes(e_comum_patentes patentes)
        {
            d_patentes.eliminar_patentes(patentes);
        }
    }
}
