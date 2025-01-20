using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dados.Dados_Permissoes;

namespace Capa_Dominio.Dominio_Permissoes
{
    public class dominio_permissoes_usuario
    {
         dados_acesso_usuarios d_Permissoes_Usuarios = new dados_acesso_usuarios();

        private int id_usuario;
        private string primeiro_nome;
        private string nome_meio;
        private string ultimo_nome;
        private string sexo;
        private string bi;
        private string telefone1;
        private string e_mail;
        private string palavra_passe;
        public dominio_permissoes_usuario()
        {

        }
        public dominio_permissoes_usuario(int id_usuario, string primeiro_nome, string nome_meio, string ultimo_nome, string sexo, string bi, string telefone1, string e_mail, string palavra_passe)
        {
            this.id_usuario = id_usuario;
            this.primeiro_nome = primeiro_nome;
            this.nome_meio = nome_meio;
            this.ultimo_nome = ultimo_nome;
            this.sexo = sexo;
            this.bi = bi;
            this.telefone1 = telefone1;
            this.e_mail = e_mail;
            this.palavra_passe = palavra_passe;
        }

        public string UpdateProfile()
        {
            try
            {
                d_Permissoes_Usuarios.AtualizarPerfilUsuario(id_usuario, primeiro_nome, nome_meio, ultimo_nome, bi, telefone1, e_mail, palavra_passe);
                Verificar_Login(palavra_passe);
                return "O seu perfil foi atualizado corretamente!";
            }
            catch (SqlException ex)
            {
                return "Existem dados duplicados, verifique-os e tente novamente!" + ex.Message;
            }
        }
        public bool Verificar_Login(string senha)
        {
            return d_Permissoes_Usuarios.Verificar_Login(senha);
        }
    }
}
