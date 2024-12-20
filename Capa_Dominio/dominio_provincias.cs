using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;
using System.Data;


namespace Capa_Dominio
{
    public class dominio_provincias : Validacoes
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
        public DataTable selecionar_provincias()
        {
            return provincias.selecionar_provincia();
        }
        #endregion

        #region Método para registrar as provincias
        public void registrar_provincias(e_comum_provincias provincia)
        {
            //Validade a quantidade de letras no campo
            Validadar_Nomes_Gerais(provincia.nome, "[ERRO] - O campo 'nome do país', deve conter somente letras e ter no mínimo 3 caracteres.");
            //Persistir os dados no banco de dados
            provincias.registrar_provincia(provincia);
        }
        #endregion

        #region Método para atualizar as provincias
        public void atualizar_provincias(e_comum_provincias provincia)
        {
            //Persistir os dados no banco de dados
            provincias.atualizar_provincias(provincia);
        }
        #endregion

        #region Método para eliminar as provincias
        public void eliminar_provincias(e_comum_provincias provincia)
        {
            provincias.eliminar_provincia(provincia);
        }
        #endregion
    }
}
