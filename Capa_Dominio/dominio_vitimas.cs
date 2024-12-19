
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;



namespace Capa_Dominio
{
    public class dominio_vitimas
    {
        dados_vitimas d_vitimas = new dados_vitimas();
        public DataTable selecionar_vitimas_combo_box()
        {
            return d_vitimas.selecionar_vitimas_combo_box();
        }
        public DataTable selecionar_vitimas()
        {
            return d_vitimas.selecionar_vitimas();
        }
        public void inserir_vitimas(e_comum_vitimas vitimas)
        {
            d_vitimas.registrar_vitimas(vitimas);
        }
        public void atualizar_vitimas(e_comum_vitimas vitimas)
        {
            d_vitimas.atualizar_vitimas(vitimas);
        }
        public void eliminar_vitimas(e_comum_vitimas vitimas)
        {
            d_vitimas.eliminar_vitimas(vitimas);
        }
    }
}
