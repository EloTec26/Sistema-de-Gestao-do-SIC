using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dominio
{
    public class dominio_afastamentos : Validacoes
    {
        dados_afastamentos d_Afastamentos = new dados_afastamentos();
        // Validação de campos obrigatórios
        private void validacacoes(e_comum_afastamentos afastamentos)
        {
            if (!int.TryParse(afastamentos.id_investigador?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - O campo 'Funcionário' é de selecção obrigatória.");

            if (!int.TryParse(afastamentos.id_usuario?.ToString(), out int _))
                throw new ArgumentException("[ERRO] - Nenhum usu+ario logado.");

            if (string.IsNullOrWhiteSpace(afastamentos.estado))
                throw new ArgumentException("O campo 'Estado' é de selecção obrigatória.");

            if (string.IsNullOrWhiteSpace(afastamentos.descricao))
                throw new ArgumentException("O campo 'Descrição' é de preenchimento obrigatório.");
        }
        public DataTable selecionar_Afastamentos()
        {
            try
            {
                return d_Afastamentos.selecionar_afastamentos();
            }
            catch (Exception ex)
            {
                throw new ArgumentException ("Erro - não foi possível selecionar os afastamentos!", "Algum erro ocorreu!" + ex.Message);
            }
        }
        public void inserir_Afastamentos(e_comum_afastamentos afastamentos)
        {
            try
            {
                validacacoes(afastamentos);
                d_Afastamentos.registrar_afastamentos(afastamentos);
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("Erro - Não foi possível registrar este afastamento." +
                    "\nPor favor, verifique os dados inseridos e tente novamente!" + ex.Message);
            }
        }
        public void atualizar_Afastamentos(e_comum_afastamentos afastamentos)
        {
            try
            {
                validacacoes(afastamentos);
                d_Afastamentos.atualizar_afastamentos(afastamentos);
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("Erro - Não foi possível atualizar este afastamento." +
                    "\nPor favor, verifique os dados inseridos e tente novamente!" + ex.Message);
            }
        }
        public void eliminar_Afastamentos(e_comum_afastamentos afastamentos)
        {
            try
            {
                d_Afastamentos.eliminar_afastamentos(afastamentos);
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("Erro - Não foi possível eliminar este afastamento." +
                    "\nPor favor, tente mais tarde!" + ex.Message);
            }
        }
    }
}
