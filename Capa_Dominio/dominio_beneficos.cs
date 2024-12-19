//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_beneficos
    {
        dados_beneficios d_Beneficios = new dados_beneficios();
        public DataTable selecionar_Beneficos_Combo_Box()
        {
            return d_Beneficios.selecionar_beneficios_Combo_Box();
        }
        public DataTable selecionar_Beneficos()
        {
            return d_Beneficios.selecionar_beneficios();
        }
        public void inserir_Beneficos(e_comum_beneficios beneficios)
        {
            d_Beneficios.registrar_beneficios(beneficios);
        }
        public void atualisar_Beneficos(e_comum_beneficios beneficios)
        {
            d_Beneficios.atualizar_beneficios(beneficios);
        }
        public void eliminar_Beneficos(e_comum_beneficios beneficios)
        {
            d_Beneficios.eliminar_beneficios(beneficios);
        }
    }
}
