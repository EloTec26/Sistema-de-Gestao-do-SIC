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
    public class dominio_suspeitos
    {
        dados_suspeitos d_suspeitos = new dados_suspeitos();
        public DataTable selecionar_suspeitos_combo_boxs()
        {
            return d_suspeitos.selecionar_suspeitos_combo_box();
        }
        public DataTable selecionar_suspeitos()
        {
            return d_suspeitos.selecionar_suspeitos();
        }
        public void inserir_suspeitos(e_comum_suspeitos suspeitos)
        {
             d_suspeitos.inserir_suspeitos(suspeitos);
        }
        public void atualizar_suspeitos(e_comum_suspeitos suspeitos)
        {
            d_suspeitos.atualizar_suspeitos(suspeitos);
        }
        public void eliminar_suspeitos(e_comum_suspeitos suspeitos)
        {
             d_suspeitos.eliminar_suspeitos(suspeitos);
        }
    }
}
