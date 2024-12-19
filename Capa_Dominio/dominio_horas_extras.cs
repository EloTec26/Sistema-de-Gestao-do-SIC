
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_horas_extras
    {
        dados_horas_extras d_Horas_Extras = new dados_horas_extras();
        public DataTable selecionar_horas_extras()
        {
            return d_Horas_Extras.selecionar_horas_extras();
        }
        public void inserir_horas_extras(e_comum_horas_extras horas_Extras)
        {
            d_Horas_Extras.inserir_horas_extras(horas_Extras);
        }
        public void atualizar_horas_extras(e_comum_horas_extras horas_Extras)
        {
            d_Horas_Extras.atualizar_horas_extras(horas_Extras);
        }
        public void eliminar_horas_extras(e_comum_horas_extras horas_Extras)
        {
            d_Horas_Extras.eliminar_horas_extras(horas_Extras);
        }
    }
}
