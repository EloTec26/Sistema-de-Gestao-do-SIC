//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_beneficos : Validacoes
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
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_beneficios beneficios)
        {
            Validadar_Nomes_Gerais(beneficios.nome, "[ERRO] - O campo 'Digite o benefício', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(beneficios.descricao, "[ERRO] - O campo 'Descrição', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_Beneficos(e_comum_beneficios beneficios)
        {
            validacacoes(beneficios);
            d_Beneficios.registrar_beneficios(beneficios);
        }
        public void atualisar_Beneficos(e_comum_beneficios beneficios)
        {
            validacacoes(beneficios);
            d_Beneficios.atualizar_beneficios(beneficios);
        }
        public void eliminar_Beneficos(e_comum_beneficios beneficios)
        {
            d_Beneficios.eliminar_beneficios(beneficios);
        }
    }
}
