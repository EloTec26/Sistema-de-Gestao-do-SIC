using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Dados;
using Capa_Comum.Entidades;


namespace Capa_Dominio
{
    public class dominio_provincias
    {
        #region Instanciação da classe
        dados_provincias provincias = new dados_provincias();
        #endregion

        #region Método para selecionar as provincias
        public DataTable selecionar_provincias_ComboBox_Filtros(int idPaises)
        {
            return provincias.selecionar_provincia_comboBox_filtro(idPaises);
        }
        public DataTable selecionar_provincias_ComboBox()
        {
            return provincias.selecionar_provincia_comboBox();
        }
        public DataTable selecionar_provincias ()
        {
            return provincias.selecionar_provincia();
        }
        #endregion

        #region Método para registrar as provincias
        public void registrar_provincias (e_comum_provincias provincia)
        {
            provincias.registrar_provincia(provincia);
        }
        #endregion

        #region Método para atualizar as provincias
        public void atualizar_provincias (e_comum_provincias provincia)
        {
            provincias.atualizar_provincias(provincia);
        }
        #endregion

        #region Método para eliminar as provincias
        public void eliminar_provincias (e_comum_provincias provincia)
        {
            provincias.eliminar_provincia(provincia);
        }
        #endregion
    }
}
