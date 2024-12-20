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
    public class dominio_departamentos : Validacoes
    {
        dados_departamentos d_Departamentos = new dados_departamentos();
        public DataTable selecionar_Departamentos()
        {
            return d_Departamentos.selecionar_departamentos();
        }
        public DataTable selecionar_Departamentos_Combo_Box()
        {
            return d_Departamentos.selecionar_departamentos_Combo_Box();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_departamentos departamentos)
        {
            Validadar_Nomes_Gerais(departamentos.nome, "[ERRO] - O campo 'Insira o departamento', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(departamentos.descricao, "[ERRO] - O campo 'Descrição', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_Departamentos(e_comum_departamentos departamentos)
        {
            validacacoes(departamentos);
            d_Departamentos.inserir_departamentos(departamentos);
        }
        public void atualizar_Departamentos(e_comum_departamentos departamentos)
        {
            validacacoes(departamentos);
            d_Departamentos.atualizar_departamentos(departamentos);
        }
        public void eliminar_Departamentos(e_comum_departamentos departamentos)
        {
            d_Departamentos.eliminar_departamentos(departamentos);
        }
    }
}
