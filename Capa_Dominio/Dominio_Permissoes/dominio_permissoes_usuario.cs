using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Permissoes;

namespace Capa_Dominio.Dominio_Permissoes
{
    public class dominio_permissoes_usuario
    {
        private dados_acesso_usuarios d_Permissoes_Usuarios = new dados_acesso_usuarios();

        public bool Verificar_Login(string senha)
        {
            return d_Permissoes_Usuarios.Verificar_Login(senha);
        }
    }

}
