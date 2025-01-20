using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dominio
{
    public class dominio_bairro_rua : Validacoes
    {
        #region Instanciar as classes e métodos
        dados_bairro_rua d_bairro_rua = new dados_bairro_rua();
        e_comum_bairro_rua c_Bairro_Rua = new e_comum_bairro_rua();
        #endregion

        #region Selecionar os bairros_ruas
        //public DataTable selecionar_bairros_ruas_filtro(int IdMunicipio)
        //{
        //    return d_bairro_rua.selecionar_bairro_ruas_combobox_filtro(IdMunicipio);
        //}
        public DataTable selecionar_bairros_ruas()
        {
            try
            {
                return d_bairro_rua.selecionar_bairro_ruas();
            }
            catch (SqlException ex)
            {

                throw new ArgumentException("Erro ao selecionar os bairro/ruas", "Erro de selecção" + ex.Message);
            }
        }
        public DataTable selecionar_bairros_ruas_combobox()
        {
            return d_bairro_rua.selecionar_bairro_ruas_combobox();
        }
        #endregion
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_bairro_rua bairro_Rua)
        {
            Validadar_Nomes_Gerais(bairro_Rua.nome, "[ERRO] - O campo 'Insira bairro/rua', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        #region Registrar os bairros_ruas
        public void registrar_bairros_ruas(e_comum_bairro_rua bairro_Rua)
        {
            try
            {
                validacacoes(bairro_Rua);
                d_bairro_rua.registrar_bairros_ruas(bairro_Rua);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new ArgumentException("O nome do bairro/rua já está registrado. Por favor, insira um bairro/rua diferente.", "Erro de registro" + ex.Message);
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        #endregion

        #region Atualizar os bairros_ruas
        public void atualizar_bairros_ruas(e_comum_bairro_rua bairro_Rua)
        {
            try
            {
                validacacoes(bairro_Rua);
                d_bairro_rua.atualizar_bairros_ruas(bairro_Rua);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new ArgumentException("O nome do bairro/rua já está registrado. Por favor, insira um bairro/rua diferente.", "Erro de atualização" + ex.Message);
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        #endregion

        #region Eliminar os bairros_ruas
        public void eliminar_bairros_ruas(e_comum_bairro_rua bairro_Rua)
        {
            try
            {
                d_bairro_rua.eliminar_bairro_rua(bairro_Rua);
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 457)
                {
                    throw new ArgumentException("Não é possível eliminar este bairro/rua, pois existem - no sistema-, dados que estão vinculados à ele", "Erro de exclusão" + Ex.Message);
                }
            }
        }
        #endregion
    }
}
