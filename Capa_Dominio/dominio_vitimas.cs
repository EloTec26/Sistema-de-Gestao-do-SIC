
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;


namespace Capa_Dominio
{
    public class dominio_vitimas : Validacoes
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
        private void validacacoes(e_comum_vitimas vitimas)
        {
            //Validade a quantidade de letras no campo
            Validadar_Nomes_Gerais(vitimas.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(vitimas.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(vitimas.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validar_Email(vitimas.e_mail);
        }
        public void inserir_vitimas(e_comum_vitimas vitimas)
        {
            validacacoes(vitimas);
           //Persistir os dados no banco de dados
            d_vitimas.registrar_vitimas(vitimas);
        }
        public void atualizar_vitimas(e_comum_vitimas vitimas)
        {
            validacacoes(vitimas);
            d_vitimas.atualizar_vitimas(vitimas);
        }
        public void eliminar_vitimas(e_comum_vitimas vitimas)
        {
            d_vitimas.eliminar_vitimas(vitimas);
        }
    }
}
