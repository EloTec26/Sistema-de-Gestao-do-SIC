using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Permissoes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios.Alterar_perfil_usuario
{
    public partial class Form_Perfil_Usuario : Form
    {
        e_comum_usuarios c_Usuarios = new e_comum_usuarios();
       
        dominio_usuarios d_Usuarios = new dominio_usuarios();
        public Form_Perfil_Usuario()
        {
            InitializeComponent();
            //-----------------------------------------
            carregar_Dados_Usuarios_Objectos();
            inicializarControloEditar();
            toolTip1.SetToolTip(btn_Fechar, "Fechar formulário");
        }
        #region Método para carregar os dados do usuário nos textBox
        public void carregar_Dados_Usuarios_Objectos()
        {
            //carregar os dados nos labels
            label_id.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario.ToString();
            label_primeiro_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome;
            label_nome_meio.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio;
            label_ultimo_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome;
            label_numero_bi.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.bi;
            labe_sexo.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo;
            label_telefone1.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1;
            label_email.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail;
            label_tipo_usuario.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario;
            //carregar os dados nos textboxs
            label_id.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario.ToString();
            text_primeiro_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome;
            text_nome_meio.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio;
            text_ultimo_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome;
            text_numero_bi.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.bi;
            text_sexo.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo;
            text_primerio_numero_telefone.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1;
            text_e_mail.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail;
            text_cargo.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario;
            //atualizarDados();
        }
        #endregion
        private void Limpar()
        {
            inicializarControloEditar();
        }
        private void inicializarControloEditar()
        {
            linkLabel_alterar_palavra_passe.Text = "Editar";
            text_nova_palavra_passe.Enabled = false;
            text_nova_palavra_passe.UseSystemPasswordChar = true;
            text_confirm_palavra_passe.Enabled = false;
            text_confirm_palavra_passe.UseSystemPasswordChar = true;
            text_palavra_passe_atinga.UseSystemPasswordChar = true;
        }
        private void linkLabel_alterar_palavra_passe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel_alterar_palavra_passe.Text == "Editar")
            {
                linkLabel_alterar_palavra_passe.Text = "Cancelar";
                text_nova_palavra_passe.Enabled = true;
                text_nova_palavra_passe.Text = "";
                text_confirm_palavra_passe.Enabled = true;
                text_confirm_palavra_passe.Text = "";
            }
            else if (linkLabel_alterar_palavra_passe.Text == "Cancelar")
            {
                Limpar();
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_palavra_passe_atinga.Text == comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar os dados do seu perfil?", "Mensagem de atualização do perfil") == DialogResult.Yes)
                    {
                        // Capturar os dados na interface
                        c_Usuarios.id_usuario = Convert.ToInt32(label_id.Text);
                        c_Usuarios.primeiro_nome = text_primeiro_nome.Text;
                        c_Usuarios.nome_meio = text_nome_meio.Text;
                        c_Usuarios.ultimo_nome = text_ultimo_nome.Text;
                        c_Usuarios.bi = text_numero_bi.Text;
                        c_Usuarios.sexo = text_sexo.Text;
                        c_Usuarios.telefone1 = text_primerio_numero_telefone.Text;
                        c_Usuarios.e_mail = text_e_mail.Text;
                        c_Usuarios.tipo_usuario = text_cargo.Text;
                        c_Usuarios.palavra_passe = text_nova_palavra_passe.Text;

                        // Atualizar a interface com os dados mais recentes

                        d_Usuarios.atualizar_usuarios(c_Usuarios);
                        guna2MessageDialog_Confirm.Show("O seu perfil foi atualizado com sucesso!", "Atualização bem sucedida");
                        text_palavra_passe_atinga.Text = "";
                        text_nova_palavra_passe.Text = "";
                        text_confirm_palavra_passe.Text = "";

                        //// Atualizar os dados no cache

                        comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome = c_Usuarios.id_usuario.ToString();
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome = c_Usuarios.primeiro_nome;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio = c_Usuarios.nome_meio;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome = c_Usuarios.ultimo_nome;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo = c_Usuarios.sexo;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.bi = c_Usuarios.bi;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1 = c_Usuarios.telefone1;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail = c_Usuarios.e_mail;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario = c_Usuarios.tipo_usuario;
                        comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe = c_Usuarios.palavra_passe;
                        //Limpar();
                        carregar_Dados_Usuarios_Objectos();
                        panel_formulario.Visible = false;
                    }
                }
                catch (SqlException Ex)
                {
                    MessageDialog_Error.Show(Ex.Message);
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show(Ex.Message, "Não foi possível atualizar o seu perfil");
                }
            }
            else MessageDialog_Error.Show("Palavra-passe actual incorreta\nPor favor, verique-a e tente novamente!", "Eroo de palavra-passe");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carregar_Dados_Usuarios_Objectos();
            panel_formulario.Visible = true;
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
            panel_formulario.Visible = false;
        }
    }
}
