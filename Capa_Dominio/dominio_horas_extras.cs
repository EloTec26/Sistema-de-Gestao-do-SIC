
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_horas_extras : Validacoes
    {
        dados_horas_extras d_Horas_Extras = new dados_horas_extras();
        public DataTable selecionar_horas_extras()
        {
            return d_Horas_Extras.selecionar_horas_extras();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_horas_extras horas_Extras)
        {
            Validar_Numero_Peso(horas_Extras.horas_trabalhadas);
        }
        public void inserir_horas_extras(e_comum_horas_extras horas_Extras)
        {
            validacacoes(horas_Extras);
            d_Horas_Extras.inserir_horas_extras(horas_Extras);
        }
        public void atualizar_horas_extras(e_comum_horas_extras horas_Extras)
        {
            validacacoes(horas_Extras);
            d_Horas_Extras.atualizar_horas_extras(horas_Extras);
        }
        public void eliminar_horas_extras(e_comum_horas_extras horas_Extras)
        {
            d_Horas_Extras.eliminar_horas_extras(horas_Extras);
        }
    }
}
