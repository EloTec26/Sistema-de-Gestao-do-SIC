using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;


namespace Capa_Dominio
{
    public class dominio_patentes : Validacoes
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
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_patentes patentes)
        {
            Validadar_Nomes_Gerais(patentes.nome, "[ERRO] - O campo 'Digite a patente', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_patentes(e_comum_patentes patentes)
        {
            validacacoes(patentes);
            d_patentes.inserir_patentes(patentes);
        }
        public void atualizar_patentes(e_comum_patentes patentes)
        {
            validacacoes(patentes);
            d_patentes.atualizar_patentes(patentes);
        }
        public void eliminar_patentes(e_comum_patentes patentes)
        {
            d_patentes.eliminar_patentes(patentes);
        }
    }
}
