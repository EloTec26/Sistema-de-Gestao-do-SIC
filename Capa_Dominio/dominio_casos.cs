using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_casos : Validacoes
    {
        dados_casos d_Casos = new dados_casos();
        public DataTable selecionar_Casos_Combo_Box()
        {
            return d_Casos.selecionar_casos_Combo_Box();
        }
        public DataTable selecionar_Casos()
        {
            return d_Casos.selecionar_casos();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_casos casos)
        {
            Validadar_Nomes_Gerais(casos.titulo, "[ERRO] - O campo 'Título', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(casos.descricao, "[ERRO] - O campo 'Descrição', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_Casos(e_comum_casos casos)
        {
            validacacoes(casos);
            d_Casos.inserir_casos(casos);
        }
        public void atualizar_Casos(e_comum_casos casos)
        {
            validacacoes(casos);
            d_Casos.atualizar_casos(casos);
        }
        public void eliminar_Casos(e_comum_casos casos)
        {
            d_Casos.eliminar_casos(casos);
        }
    }
}
