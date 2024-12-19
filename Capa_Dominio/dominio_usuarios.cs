
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;



namespace Capa_Dominio
{
    public class dominio_usuarios
    {
        dados_usuarios d_usuarios = new dados_usuarios();
        public DataTable selecionar_usuarios()
        {
            return d_usuarios.selecionar_usuarios();
        }
        public void inserir_usuarios(e_comum_usuarios usuarios)
        {
            d_usuarios.registrar_usuarios(usuarios);
        }
        public void atualizar_usuarios(e_comum_usuarios usuarios)
        {
            d_usuarios.atualizar_usuarios(usuarios);
        }
        public void eliminar_usuarios(e_comum_usuarios usuarios)
        {
            d_usuarios.eliminar_usuarios(usuarios);
        }
    }
}
