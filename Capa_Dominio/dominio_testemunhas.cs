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
    public class dominio_testemunhas
    {
        dados_testemunhas d_testemunhas = new dados_testemunhas();
        public DataTable selecionar_testemunhas_combo_box()
        {
            return d_testemunhas.selecionar_testemunhas_combo_boxs();
        }
        public DataTable selecionar_testemunhas()
        {
            return d_testemunhas.selecionar_testemunhas();
        }
        public void inserir_testemunhas(e_comum_testemunhas testemunhas)
        {
            d_testemunhas.inserir_testemunhas(testemunhas);
        }
        public void atualizar_testemunhas(e_comum_testemunhas testemunhas)
        {
            d_testemunhas.atualizar_testemunhas(testemunhas);
        }
        public void eliminar_testemunhas(e_comum_testemunhas testemunhas)
        {
            d_testemunhas.eliminar_testemunhas(testemunhas);
        }
    }
}
