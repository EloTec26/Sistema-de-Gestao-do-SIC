using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dominio
{
    public class dominio_investigadores : Validacoes
    {
        dados_investigadores d_investigadores = new dados_investigadores();
        public DataTable selecionar_investigadores_combobox()
        {
            return d_investigadores.selecionar_investigadores_combobox();
        }
        public DataTable selecionar_investigadores()
        {
            return d_investigadores.selecionar_investigadores();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_investigadores investigadores)
        {
            //Validação de campos obrigatórios
            if (!int.TryParse(investigadores.id_continente?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Continente' de selecçãoé obrigatória.");
            if (!int.TryParse(investigadores.id_pais?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'País' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_provincia?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Província' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_municipio?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Município' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_bairro_rua?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Bairro/Rua' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_nivel_academico?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Nível acadêmico' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_curso?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Curso' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_especialidade?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Especialidade' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_patente?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Patente' é de selecção obrigatória.");
            if (!int.TryParse(investigadores.id_usuario?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - Nenhum usuário logado!");
            if (string.IsNullOrWhiteSpace(investigadores.primeiro_nome))
                throw new ArgumentException("O campo 'Digite o primeiro nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(investigadores.ultimo_nome))
                throw new ArgumentException("O campo 'Digite o último nome' é de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(investigadores.telefone1))
                throw new ArgumentException("O campo 'Nº de telefone' é  de preenchimento obrigatório.");
            if (string.IsNullOrWhiteSpace(investigadores.bi))
                throw new ArgumentException("O campo 'Nº do Bilhete de Identidade' é de preenchimento obrigatório.");

            Validadar_Nomes_Gerais(investigadores.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            //Validadar_Nomes_Gerais(investigadores.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(investigadores.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Telefone(investigadores.telefone1);
            Validadar_Telefone(investigadores.telefone2);
            Validar_Email(investigadores.e_mail);
            Validar_Bilhete_Identidade(investigadores.bi);
        }
        public void inserir_investigadores(e_comum_investigadores investigadores)
        {
            try
            {
                validacacoes(investigadores);
                d_investigadores.inserir_investigadores(investigadores);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("bi"))
                {
                    throw new ArgumentException("Este 'Nº do Bilhete de Identidade' já existe no sistema!\nPor favor, insira um outro e tente novamente", "Ocorreu um erro de redundância" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("Este 'Nº de telefone'  já existe no sistema!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone2"))
                {
                    throw new ArgumentException("Este 'Nº de telefone alternativo'  já existe no sistema!\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("Este 'E-mail'  já existe no sistema!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
            }
        }
        public void atualizar_investigadores(e_comum_investigadores investigadores)
        {
            try
            {
                validacacoes(investigadores);
                d_investigadores.atualizar_investigadores(investigadores);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("bi"))
                {
                    throw new ArgumentException("Este 'Nº do Bilhete de Identidade' já existe no sistema!\nPor favor, insira um outro e tente novamente", "Ocorreu um erro de redundância" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("Este 'Nº de telefone'  já existe no sistema!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
                if (erro_Duplicacao.Contains("telefone2"))
                {
                    throw new ArgumentException("Este 'Nº de telefone alternativo'  já existe no sistema!\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("Este 'E-mail'  já existe no sistema!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Ocorreu um erro de redundância" + ex.Message);
                }
            }
        }
        public void eliminar_investigadores(e_comum_investigadores investigadores)
        {
            try
            {
                d_investigadores.eliminar_investigadores(investigadores);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ArgumentException("Não é possível eliminar este funcionário, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão" + ex.Message);
            }
        }
    }
}
