//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System;
using System.Data;
using System.Data.SqlClient;

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
            try
            {
                validacacoes(departamentos);
                d_Departamentos.inserir_departamentos(departamentos);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("nome"))
                {
                    throw new ArgumentException("Este 'Departamento' já existe´no sistema.!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação" + ex.Message);
                }

                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação" + ex.Message);
                }
            }

        }
        public void atualizar_Departamentos(e_comum_departamentos departamentos)
        {
            try
            {
                validacacoes(departamentos);
                d_Departamentos.atualizar_departamentos(departamentos);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("nome"))
                {
                    throw new ArgumentException("Este 'Departamento' já existe´no sistema.!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação" + ex.Message);
                }

                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação" + ex.Message);
                }
            }
        }
        public void eliminar_Departamentos(e_comum_departamentos departamentos)
        {
            d_Departamentos.eliminar_departamentos(departamentos);
        }
    }
}
