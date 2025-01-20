using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dominio
{
    public class dominio_testemunhas : Validacoes
    {
        dados_testemunhas d_testemunhas = new dados_testemunhas();
        public DataTable selecionar_testemunhas_combo_box()
        {
            return d_testemunhas.selecionar_testemunhas_combo_boxs();
        }
        public DataTable selecionar_testemunhas()
        {
            try
            {
                return d_testemunhas.selecionar_testemunhas();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao tentar selecionar a lista de testemunhas!", "Ups" + ex.Message);
            }
        }
        private void validacacoes(e_comum_testemunhas testemunhas)
        { 
            //Validação de campos obrigatórios.
            if (!int.TryParse(testemunhas.id_caso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Caso' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_continente?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Continente' de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_pais?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'País' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_provincia?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Província' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_municipio?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Município' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_bairro_rua?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Bairro/Rua' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_nivel_academico?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Nível acadêmico' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_curso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Curso' é de selecção obrigatória.");
            if (!int.TryParse(testemunhas.id_usuario?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - Nenhum usuário logado!");
            if (string.IsNullOrWhiteSpace(testemunhas.primeiro_nome))
                throw new ArgumentException("O campo 'Digite o primeiro nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(testemunhas.ultimo_nome))
                throw new ArgumentException("O campo 'Digite o último nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(testemunhas.telefone1))
                throw new ArgumentException("O campo 'Nº de telefone' é  de preenchimento obrigatório.");
            //Validar a quantidade de letras no campo e outras regras.
            Validadar_Nomes_Gerais(testemunhas.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            //Validadar_Nomes_Gerais(testemunhas.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(testemunhas.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validar_Email(testemunhas.e_mail);
        }
        public void inserir_testemunhas(e_comum_testemunhas testemunhas)
        {
            try
            {
                validacacoes(testemunhas);
                d_testemunhas.inserir_testemunhas(testemunhas);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("Este 'Nº de telefone' já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone2"))
                {
                    throw new ArgumentException("Este 'Nº de telefone alternativo' já existe!\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("Este 'E-mail' já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação" + ex.Message);
                }
            }
        }
        public void atualizar_testemunhas(e_comum_testemunhas testemunhas)
        {
            try
            {
                validacacoes(testemunhas);
                d_testemunhas.atualizar_testemunhas(testemunhas);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("Este 'Nº de telefone' já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone2"))
                {
                    throw new ArgumentException("Este 'Nº de telefone alternativo' já existe!\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("Este 'E-mail' já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação" + ex.Message);
                }
            }
        }
        public void eliminar_testemunhas(e_comum_testemunhas testemunhas)
        {
            try
            {
                d_testemunhas.eliminar_testemunhas(testemunhas);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ArgumentException("Não é possível eliminar esta testemunha, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão" + ex.Message);
            }
        }
    }
}
