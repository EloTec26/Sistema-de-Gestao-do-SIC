//-------------------------------
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Drawing;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Cursos : Form
    {
        e_comum_cursos c_Cursos = new e_comum_cursos();
        dominio_cursos d_Cursos = new dominio_cursos();
        public Form_Modulo_Cursos()
        {
            InitializeComponent();
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capturar_Dados_Digitados_Formulario()
        {
            //
            string curso = text_Curso.Text;
            DateTime data_Registro = text_Data_Registro.Value;
            DateTime data_atualizacao = DateTime.Now;
            //
            c_Cursos.nome = curso;
            c_Cursos.data_registro = data_Registro;
            c_Cursos.data_atualizacao = data_atualizacao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_Curso.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            else
            {
                try
                {
                    capturar_Dados_Digitados_Formulario();
                    //
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este curso?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Cursos.inserir_Cursos(c_Cursos);
                        guna2MessageDialog_Inform.Show($"O curso {text_Curso.Text}, foi registrado com  sucesso", "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome do curso já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }else
                    MessageDialog_Error.Show("Não foi possível salvar este nivel acadêmico", ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (text_Curso.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            else
            {
                try
                {
                    int id_Curso = Convert.ToInt32(label_id.Text);
                    capturar_Dados_Digitados_Formulario();
                    string curso = text_Curso.Text;
                    //
                    c_Cursos.id_curso = id_Curso;
                    //
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este curso?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Cursos.atualizar_Cursos(c_Cursos);
                        guna2MessageDialog_Inform.Show($"O curso {text_Curso.Text}, foi atualizado com  sucesso!", "Atualização bem sucedida");
                        limpar_Campos();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome do curso já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                        MessageDialog_Error.Show("Não foi possível atualizar este curso!", ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_Curso.Text = "";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }

        private void text_Curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_Curso, label_msg_curso, "Apenas letras são permitidas!");
        }
    }
}
