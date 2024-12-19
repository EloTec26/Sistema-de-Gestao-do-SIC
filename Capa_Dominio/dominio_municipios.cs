using Capa_Comum.Entidades;
using Capa_Dados;
using System;

namespace Capa_Dominio
{
    public class dominio_municipios
    {
        #region Instanciar as classes e os métodos
        dados_municipios d_municipios = new dados_municipios();
        #endregion

        #region Selecionar municipios
        #region Selecionar municipios comboBox
        public System.Data.DataTable selecionar_municipios_comboBox()
        {
            return d_municipios.selecionar_municipios_combobox();
        }
        #endregion
        public System.Data.DataTable Selecionar_Municipios_Fitrod(int IdProvincia)
        {
            return d_municipios.selecionar_municipios_combobox_filtro(IdProvincia);
        }
        public System.Data.DataTable selecionar_municipios()
        {
            return d_municipios.selecionar_municipios();
        }
        #endregion

        #region Registrar municipios
        public void registrar_municipios(e_comum_municipios municipios)
        {
            try
            {
                d_municipios.registrar_municipios(municipios);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do município já está registrado. Por favor, insira um município diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        #endregion

        #region Atualizar minucipios
        public void atualizar_municipios(e_comum_municipios municipios)
        {
            try
            {
                d_municipios.atualizar_municipios(municipios);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do município já está registrado. Por favor, insira um município diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        #endregion

        #region Eliminar municipios
        public void eliminar_municipios(e_comum_municipios municipios)
        {
            d_municipios.eliminar_municipios(municipios);
        }
        #endregion

    }
}
