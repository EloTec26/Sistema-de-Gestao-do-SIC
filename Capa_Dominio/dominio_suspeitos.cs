using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System.Data.SqlClient;

namespace Capa_Dominio
{
    public class dominio_suspeitos : Validacoes
    {
        dados_suspeitos d_suspeitos = new dados_suspeitos();
        public DataTable selecionar_suspeitos_combo_boxs()
        {
            return d_suspeitos.selecionar_suspeitos_combo_box();
        }
        public DataTable selecionar_suspeitos()
        {
            try
            {
                return d_suspeitos.selecionar_suspeitos();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao selecionar os suspeitos!", "Ups" + ex.Message);
            }
        }
        private void validacacoes(e_comum_suspeitos suspeitos)
        {
            //Validação de campos obrigatórios.
            if (!int.TryParse(suspeitos.id_caso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Caso' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_continente?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Continente' de selecçãoé obrigatória.");
            if (!int.TryParse(suspeitos.id_pais?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'País' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_provincia?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Província' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_municipio?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Município' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_bairro_rua?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Bairro/Rua' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_nivel_academico?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Nível acadêmico' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_curso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Curso' é de selecção obrigatória.");
            if (!int.TryParse(suspeitos.id_usuario?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - Nenhum usuário logado!");
            if (string.IsNullOrWhiteSpace(suspeitos.primeiro_nome))
                throw new ArgumentException("O campo 'Digite o primeiro nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(suspeitos.ultimo_nome))
                throw new ArgumentException("O campo 'Digite o último nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(suspeitos.telefone1))
                throw new ArgumentException("O campo 'Nº de telefone' é  de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(suspeitos.descricao))
                throw new ArgumentException("O campo 'Descrição' é  de preenchimento obrigatório.");
            //Validade a quantidade de letras no campo
            Validadar_Nomes_Gerais(suspeitos.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            //Validadar_Nomes_Gerais(suspeitos.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(suspeitos.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validar_Email(suspeitos.e_mail);
        }
        public void inserir_suspeitos(e_comum_suspeitos suspeitos)
        {
            try
            {
                validacacoes(suspeitos);
                d_suspeitos.inserir_suspeitos(suspeitos);
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
        public void atualizar_suspeitos(e_comum_suspeitos suspeitos)
        {
            try
            {
                validacacoes(suspeitos);
                d_suspeitos.atualizar_suspeitos(suspeitos);
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
        public void eliminar_suspeitos(e_comum_suspeitos suspeitos)
        {
            try
            {
                d_suspeitos.eliminar_suspeitos(suspeitos);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ArgumentException("Não é possível eliminar este suspeito, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão" + ex.Message);
            }
        }
    }
}
