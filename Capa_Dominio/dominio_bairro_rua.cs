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
    public class dominio_bairro_rua
    {
        #region Instanciar as classes e métodos
        dados_bairro_rua d_bairro_rua = new dados_bairro_rua();
        e_comum_bairro_rua c_Bairro_Rua = new e_comum_bairro_rua();
        #endregion

        #region Selecionar os bairros_ruas
        public DataTable selecionar_bairros_ruas_filtro(int IdMunicipio)
        {
            return d_bairro_rua.selecionar_bairro_ruas_combobox_filtro(IdMunicipio);
        }
        public DataTable selecionar_bairros_ruas()
        {
            return d_bairro_rua.selecionar_bairro_ruas();
        }
        public DataTable selecionar_bairros_ruas_combobox()
        {
            return d_bairro_rua.selecionar_bairro_ruas_combobox();
        }
        #endregion

        #region Registrar os bairros_ruas
        public void registrar_bairros_ruas(e_comum_bairro_rua bairro_Rua)
        {
            try
            {
                d_bairro_rua.registrar_bairros_ruas(bairro_Rua);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do bairro/rua já está registrado. Por favor, insira um bairro/rua diferente.");
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
                d_bairro_rua.atualizar_bairros_ruas(bairro_Rua);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do bairro/rua já está registrado. Por favor, insira um bairro/rua diferente.");
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
            catch (System.Data.SqlClient.SqlException Ex)
            {
                if (Ex.Number == 457)
                {
                    throw new ArgumentException("Não é possível eliminar este bairro/rua, pois existem - no sistema-, dados que estão vinculados à ele");
                }
            }
        }
        #endregion
    }
}
