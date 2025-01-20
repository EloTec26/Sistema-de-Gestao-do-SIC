using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Dados;
using Capa_Comum.Entidades;
using System.ComponentModel.DataAnnotations;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_paises : Validacoes
    {
        #region Instanciar as classes e os métodos
        dados_paises d_paises = new dados_paises();
        #endregion
        #region Selecionar os países 
        #region Selecionar países para o comboBox
       
        public DataTable selecionar_paises_comboBox()
        {
            return d_paises.selecionar_paises_comboBox();
        }
        #endregion
        public DataTable selecionar_paises()
        {
            return d_paises.selecionar_paises();
        }
        #endregion
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_paises paises)
        {
            Validadar_Nomes_Gerais(paises.nome, "[ERRO] - O campo 'Insira o país', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        #region Registrar os países
        public void registrar_paises (e_comum_paises paises)
        {
            try
            {
                validacacoes(paises);
                d_paises.registrar_paises(paises);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do país já está registrado. Por favor, insira um país diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
            
        }
        #endregion

        #region Atualizar os países
        public void atualizar_paises(e_comum_paises paises)
        {
            try
            {
                validacacoes(paises);
                d_paises.atualizar_pais(paises);
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

        #region Elimanar os países
        public void eliminar_paises(e_comum_paises paises)
        {
            d_paises.eliminar_paises(paises);
        }
        #endregion
    }
}
