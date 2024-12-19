using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Comum.Entidades;
using Capa_Dados;

namespace Capa_Dominio
{
    public class dominio_continentes
    {
        #region Instanciar as classes e os métodos
        dados_continentes d_continentes = new dados_continentes();
        #endregion

        #region Selecionar os continentes
        public DataTable selecionar_continentes_combobox()
        {
            return d_continentes.selecionar_continentes_comboboxs();
        }
        public DataTable selecionar_continentes()
        {
            return d_continentes.selecionar_continentes();
        }
        #endregion

        #region Registrar os continentes
        public void registrar_continentes (e_comum_continentes continentes)
        {
            try
            {
                d_continentes.registrar_continentes(continentes);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do continente já está registrado. Por favor, insira um continente diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        #endregion
        #region Atualizar os continentes
        public void atualizar_continentes(e_comum_continentes continentes)
        {
            try
            {
                d_continentes.atualizar_continentes(continentes);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do continente já está registrado. Por favor, insira um nome diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        #endregion

        #region 
        public void eliminar_continentes(e_comum_continentes continentes)
        {
            d_continentes.eliminar_continentes(continentes);
        }
        #endregion
    }
}
