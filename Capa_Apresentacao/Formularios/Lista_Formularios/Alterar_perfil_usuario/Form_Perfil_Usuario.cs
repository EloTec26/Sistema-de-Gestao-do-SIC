using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;

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
            carregaar_Dados_Usuarios_Labels();
            carregaar_Dados_Usuarios_Textbox();
            label1.Text = "Informações\npessoais";
        }
        #region Método para carregar os cados do usuário nos label
        private void carregaar_Dados_Usuarios_Labels()
        {
            label_id.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario.ToString();
            label_primeiro_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome;
            label_nome_meio.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio;
            label_ultimo_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome;
            label_numero_bi.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.bi;
            labe_sexo.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo;
            label_telefone1.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1;
            label_telefone2.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone2;
            label_email.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail;
            //label_continente.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_continente.ToString();
            //label_pais.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_pais.ToString();
            //label_provincia.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_provincia.ToString();
            //text_municipio.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_municipio.ToString();
            label_tipo_usuario.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario;
            label_palavra_passe.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe;
        }
        #endregion
        #region Método para carregar os dados do usuário nos textBox
        private void carregaar_Dados_Usuarios_Textbox()
        {
            label_id.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario.ToString();
            text_primeiro_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome;
            text_nome_meio.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.nome_meio;
            text_ultimo_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome;
            text_numero_bi.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.bi;
            text_sexo.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.sexo;
            text_primerio_numero_telefone.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1;
            text_segundo_numero_telefone.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone2;
            text_e_mail.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail;
            label_continente.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_continente.ToString();
            label_pais.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_pais.ToString();
            label_provincia.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_provincia.ToString();
            label_Municipio.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_municipio.ToString();
            label_bairro_rua.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_bairro_rua.ToString();
            text_tipo_usuario.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario;
            text_palavra_passe.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe;
            text_conformar_palavra_passe.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.palavra_passe;
        }
        #endregion
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
            carregaar_Dados_Usuarios_Labels();
        }

        private void btn_perfil_esquerda_Click(object sender, EventArgs e)
        {
            if (panel_formulario.Width == 18)
                panel_formulario.Width = 460;
            btn_perfil_esquerda.Visible = false;
            btn_perfil_direita.Visible = true;

        }

        private void btn_perfil_direita_Click(object sender, EventArgs e)
        {
            if (panel_formulario.Width == 460)
                panel_formulario.Width =18;
            btn_perfil_esquerda.Visible = true;
            btn_perfil_direita.Visible = false;
        }
        private void CapturarDados()
        {
            // Capturar os dados do formulário
            int id_usuario = Convert.ToInt32(label_id.Text);
            int id_continente = Convert.ToInt32(label_continente.Text);
            int id_pais = Convert.ToInt32(label_pais.Text);
            int id_provincia = Convert.ToInt32(label_provincia.Text);
            int id_municipio = Convert.ToInt32(label_Municipio.Text);
            int id_bairro_rua = Convert.ToInt32(label_bairro_rua.Text);

            string primeiro_nome = text_primeiro_nome.Text;
            string nome_meio = text_nome_meio.Text;
            string ultimo_nome = text_ultimo_nome.Text;
            string sexo = text_sexo.Text;
            string numero_bi = text_numero_bi.Text;
            string telefone1 = text_primerio_numero_telefone.Text;
            string telefone2 = text_segundo_numero_telefone.Text;
            string email = text_e_mail.Text;
            string tipo_usuario = text_tipo_usuario.Text;
            string palavra_passe = text_palavra_passe.Text;

            // Atualizar os dados capturados
            c_Usuarios.id_usuario = id_usuario;
            c_Usuarios.id_continente = id_continente;
            c_Usuarios.id_pais = id_pais;
            c_Usuarios.id_provincia = id_provincia;
            c_Usuarios.id_municipio = id_municipio;
            c_Usuarios.id_bairro_rua = id_bairro_rua;
            c_Usuarios.primeiro_nome = primeiro_nome;
            c_Usuarios.nome_meio = nome_meio;
            c_Usuarios.ultimo_nome = ultimo_nome;
            c_Usuarios.sexo = sexo;
            c_Usuarios.bi = numero_bi;
            c_Usuarios.telefone1 = telefone1;
            c_Usuarios.telefone2 = telefone2;
            c_Usuarios.e_mail = email;
            c_Usuarios.tipo_usuario = tipo_usuario;
            c_Usuarios.palavra_passe = palavra_passe;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(text_primeiro_nome.Text == "" || text_ultimo_nome.Text == "" || text_sexo.Text == ""
                || text_numero_bi.Text == "" || label_telefone1.Text == "" ||text_palavra_passe.Text == "" || text_conformar_palavra_passe.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório!", "Erro ao atualizar o perfil");
                return;
            }
            if(text_palavra_passe.Text != text_conformar_palavra_passe.Text)
            {
                MessageDialog_Error.Show("As palavras-passe não coincidem.\nPor verifique-as e tente novamente.", "Erro ao atualizar o perfil");
                return;
            }
            else
            {
                try
                {
                    CapturarDados();
                    //c_Usuarios.data_registro = data_registro;
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar os dados do seu perfil?", "Mensagem de atualização do perfil") == DialogResult.Yes)
                    {
                        d_Usuarios.atualizar_usuarios(c_Usuarios);
                        guna2MessageDialog_Inform.Show("O seu perfil foi atualizado com sucesso!", "Atualização bem sucedida");
                        carregaar_Dados_Usuarios_Labels();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show(Ex.Message, "Não foi possível atualizar o seu perfil");
                }
            }
        }
    }
}
