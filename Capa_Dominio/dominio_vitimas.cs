using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System;
using System.Data;
using System.Data.SqlClient;

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
            try
            {
                return d_vitimas.selecionar_vitimas();
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("Erro - Não foi possível selecionar as vítimas!", "Erro de selecção" + ex.Message);
            }
        }
        private void validacacoes(e_comum_vitimas vitimas)
        {
            //Validação de campos obrigatórios.
            if (!int.TryParse(vitimas.id_caso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Caso' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_continente?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Continente' de selecçãoé obrigatória.");
            if (!int.TryParse(vitimas.id_pais?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'País' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_provincia?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Província' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_municipio?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Município' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_bairro_rua?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Bairro/Rua' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_nivel_academico?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Nível acadêmico' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_curso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Curso' é de selecção obrigatória.");
            if (!int.TryParse(vitimas.id_usuario?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - Nenhum usuário logado!");
            if (string.IsNullOrWhiteSpace(vitimas.primeiro_nome))
                throw new ArgumentException("O campo 'Digite o primeiro nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(vitimas.ultimo_nome))
                throw new ArgumentException("O campo 'Digite o último nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(vitimas.telefone1))
                throw new ArgumentException("O campo 'Nº de telefone' é  de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(vitimas.descricao))
                throw new ArgumentException("O campo 'Descrição' é de preenchimento obrigatório.");
            //Validar a quantidade de letras no campo e outras regras.
            Validadar_Nomes_Gerais(vitimas.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            //Validadar_Nomes_Gerais(vitimas.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(vitimas.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validar_Email(vitimas.e_mail);
        }
        public void inserir_vitimas(e_comum_vitimas vitimas)
        {
            try
            {
                validacacoes(vitimas);
                //Persistir os dados no banco de dados
                d_vitimas.registrar_vitimas(vitimas);
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
        public void atualizar_vitimas(e_comum_vitimas vitimas)
        {
            try
            {
                validacacoes(vitimas);
                d_vitimas.atualizar_vitimas(vitimas);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("Este 'Nº de telefone' já está registrado no sistema!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone2"))
                {
                    throw new ArgumentException("Este 'Nº de telefone alternativo' já está registrado no sistema\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("Este 'E-mail' já está registrado no sistema\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação" + ex.Message);
                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação" + ex.Message);
                }
            }
        }
        public void eliminar_vitimas(e_comum_vitimas vitimas)
        {
            try
            {
                d_vitimas.eliminar_vitimas(vitimas);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ArgumentException("Não é possível eliminar esta vítima, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão" + ex.Message);
            }
        }
    }
}
