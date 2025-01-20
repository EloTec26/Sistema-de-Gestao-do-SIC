
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;
using System.Data.SqlClient;
using System;

namespace Capa_Dominio
{
    public class dominio_usuarios : Validacoes
    {
        dados_usuarios d_usuarios = new dados_usuarios();
        public DataTable selecionar_usuarios()
        {
            return d_usuarios.selecionar_usuarios();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_usuarios usuarios)
        {
            Validadar_Nomes_Gerais(usuarios.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(usuarios.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(usuarios.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Telefone(usuarios.telefone1);
            Validar_Bilhete_Identidade(usuarios.bi);
            Validar_Palavra_Passe(usuarios.palavra_passe);
            Validar_Email(usuarios.e_mail);
        }
        public void inserir_usuarios(e_comum_usuarios usuarios)
        {
            try
            {
                validacacoes(usuarios);
                d_usuarios.registrar_usuarios(usuarios);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("bi"))
                {
                    throw new ArgumentException("O 'Nº do bilhete de identidade' inserido já existe!\nPor favor, insira um outro 'Nº do bilhete de identidade' e tente novamente!", "Erro de duplicação");

                }
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("O 'Nº de telefone' inserido já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação");

                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("O 'E-mail' inserido já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");

                }
                if (erro_Duplicacao.Contains("palavra_passe"))
                {
                    throw new ArgumentException("A 'Palavra-passe' inserida já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");

                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação");
                }
            }
        }
        public void atualizar_usuarios(e_comum_usuarios usuarios)
        {
            try
            {
                validacacoes(usuarios);
                d_usuarios.atualizar_usuarios(usuarios);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                string erro_Duplicacao = ex.Message;
                if (erro_Duplicacao.Contains("bi"))
                {
                    throw new ArgumentException("O 'Nº do bilhete de identidade' inserido já existe!\nPor favor, insira um outro 'Nº do bilhete de identidade' e tente novamente!", "Erro de duplicação");

                }
                if (erro_Duplicacao.Contains("telefone1"))
                {
                    throw new ArgumentException("O 'Nº de telefone' inserido já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação");

                }
                if (erro_Duplicacao.Contains("e_mail"))
                {
                    throw new ArgumentException("O 'E-mail' inserido já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");

                }
                if (erro_Duplicacao.Contains("palavra_passe"))
                {
                    throw new ArgumentException("A 'Palavra-passe' inserida já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");

                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação");
                }
            }
        }
        public void eliminar_usuarios(e_comum_usuarios usuarios)
        {
            try
            {
                d_usuarios.eliminar_usuarios(usuarios);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ArgumentException("Não é possível eliminar este usuário, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão" + ex.Message);
            }
        }
    }
}
