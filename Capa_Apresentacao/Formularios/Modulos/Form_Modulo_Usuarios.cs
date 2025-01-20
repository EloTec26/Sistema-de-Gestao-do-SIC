//-----------------------------------------
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Usuarios : Form
    {

        #region Instanciar as classes e os métodos
        e_comum_usuarios c_Usuarios = new e_comum_usuarios();
        dominio_usuarios d_Usuarios = new dominio_usuarios();
        #endregion
        public Form_Modulo_Usuarios()
        {
            InitializeComponent();
        }
        private void Form_Modulo_Usuarios_Load(object sender, EventArgs e)
        {
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerificarCamposVazios()
        {
            if (text_primeiro_nome.Text == String.Empty
              || text_ultimo_nome.Text == String.Empty || text_numero_bi.Text == String.Empty ||
              text_sexo.Text == String.Empty || text_primerio_numero_telefone.Text == String.Empty ||
              text_tipo_usuario.Text == String.Empty || text_palavra_passe.Text == String.Empty)
            {
                MessageDialog_Error.Show("Os campos com (*) são de preechimento obrigatórios!\n" +
                    "Por favor, preencha-os e tente novamente!", "Ocorreu um erro ao salvar os dados");
                return false;
            }
            return true;
        }
        private void CapturarDadosFormulario()
        {
            // Capturar os dados do formulário
            string primeiro_Nome = text_primeiro_nome.Text;
            string nome_Meio = text_nome_meio.Text;
            string ultimo_nome = text_ultimo_nome.Text;
            string numero_Bi = text_numero_bi.Text;
            string sexo = text_sexo.Text;
            string primeiro_Numero_Telefone = text_primerio_numero_telefone.Text;
            string E_Mail = text_e_mail.Text;
            string tipo_Usuario = text_tipo_usuario.Text;
            string palavra_Passe = text_palavra_passe.Text;

            // Salvar os dados capturados
            c_Usuarios.primeiro_nome = primeiro_Nome;
            c_Usuarios.nome_meio = nome_Meio;
            c_Usuarios.ultimo_nome = ultimo_nome;
            c_Usuarios.bi = numero_Bi;
            c_Usuarios.sexo = sexo;
            c_Usuarios.telefone1 = primeiro_Numero_Telefone;
            c_Usuarios.e_mail = E_Mail;
            c_Usuarios.tipo_usuario = tipo_Usuario;
            c_Usuarios.palavra_passe = palavra_Passe;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    CapturarDadosFormulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este usuário?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Usuarios.inserir_usuarios(c_Usuarios);
                        guna2MessageDialog_Inform.Show($"O usuário {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi registrado com sucesso",
                            "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                //catch (SqlException ex)
                //{
                //    MessageDialog_Error.Show(ex.Message);
                //}
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este usuário!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    int id_Usuario = Convert.ToInt32(label_id.Text);
                    CapturarDadosFormulario();
                    c_Usuarios.id_usuario = id_Usuario;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este usuário?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Usuarios.atualizar_usuarios(c_Usuarios);
                        guna2MessageDialog_Inform.Show($"O usuário {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi atualizado com sucesso!",
                            "Atualização bem sucedida");
                        limpar_Campos();
                        this.Dispose();
                    }
                }
                //catch (SqlException ex)
                //{
                //    MessageDialog_Error.Show(ex.Message);
                //}
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este usuário!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_primeiro_nome.Text = String.Empty;
            text_nome_meio.Text = String.Empty;
            text_ultimo_nome.Text = String.Empty;
            text_numero_bi.Text = String.Empty;
            text_sexo.Text = String.Empty;
            text_primerio_numero_telefone.Text = String.Empty;
            text_e_mail.Text = String.Empty;
            text_tipo_usuario.Text = String.Empty;
            text_palavra_passe.Text = String.Empty;
        }
        #region Validações de campos

        private void text_primerio_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_primerio_numero_telefone, label_msg_telefone1, "Apenas números são permitidas!");
        }
        private void text_numero_bi_TextChanged(object sender, EventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarBilheteIdentidade(text_numero_bi, label_msg_bi, "Número do BI inválido!");
        }

        private void text_e_mail_TextChanged_1(object sender, EventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarEmail(text_e_mail, label_msg_email, "Email inválido!");
        }

        private void text_primeiro_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_primeiro_nome, label_msg_primeiro_nome, "Apenas letras são permitidas!");
        }

        private void text_nome_meio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_nome_meio, label_msg_nome_meio, "Apenas letras são permitidas!");
        }

        private void text_ultimo_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_ultimo_nome, label_msg_ultimo_nome, "Apenas letras são permitidas!");
        }

        #endregion

      
    }
}
