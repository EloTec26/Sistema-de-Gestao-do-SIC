using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_usuarios
    {
        dados_pesquisar_usuarios d_Usuarios = new dados_pesquisar_usuarios();
        public System.Data.DataTable pesquisar_Usuarios(string pesquisar_Usuarios)
        {
            return d_Usuarios.pesquisar_Usuarios(pesquisar_Usuarios);
        }
    }
}
