using Capa_Apresentacao.Formularios.Lista_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Especialidades : Form
    {
        #region Instanciação dos métodos e classes
        e_comum_especialidades c_Especialidades = new e_comum_especialidades();
        dominio_especialidades d_Especialidades = new dominio_especialidades();
        dominio_cursos d_Cursos = new dominio_cursos();
        #endregion
        Form_Lista_Especialidades especialidades;
        public Form_Modulo_Especialidades(Form_Lista_Especialidades especialidades)
        {
            InitializeComponent();

            this.especialidades = especialidades;
            selecionar_Cursos_Exbir_Combo_Box();
        }
        private void selecionar_Cursos_Exbir_Combo_Box()
        {
            text_curso.DataSource = d_Cursos.selecionar_Cursos_Combo_Box();
            text_curso.DisplayMember = "nome";
            text_curso.ValueMember = "id_curso";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDadosFormulario()
        {
            // Capturar os dados digitados no formulário
            string nome_especialidade = text_Especialidades.Text;
            int id_curso = Convert.ToInt32(text_curso.SelectedValue);

            // Registrar os dados digitados
            c_Especialidades.nome = nome_especialidade;
            c_Especialidades.id_curso = id_curso;
        }
        private bool verificarCamposVazios()
        {
            // Verificar a existência de campos vazios
            if (text_Especialidades.Text == "" || text_curso.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return false;
            }
            return true;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (verificarCamposVazios())
            {
                try
                {
                    DateTime data_registro = DateTime.Now;
                    DateTime data_atualizacao = DateTime.Now;
                    c_Especialidades.data_registro = data_registro;
                    c_Especialidades.data_atualizacao = data_atualizacao;
                    CapturarDadosFormulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta especialidade?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Especialidades.inserir_Especialidades(c_Especialidades);
                        guna2MessageDialog_Inform.Show($"A especialidade {text_Especialidades.Text}, foi registrada com sucesso!", "Registro bem sucedido");
                        especialidades.listar_Especialidades();
                        limpar_Campos();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome da especialidade já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                        MessageDialog_Error.Show("Não possível salvar esta especialidade", ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (verificarCamposVazios())
            {
                try
                {
                    // Capturar os dados digitados no formulário
                    DateTime data_atualizacao = DateTime.Now;
                    c_Especialidades.data_atualizacao = data_atualizacao;
                    int id_especialidade = Convert.ToInt32(label_id.Text);
                    CapturarDadosFormulario();
                    // Atualizar os dados digitados
                    c_Especialidades.id_especialidade = id_especialidade;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar esta especialidade?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Especialidades.atualizar_Especialidades(c_Especialidades);

                        guna2MessageDialog_Inform.Show($"A especialidade {text_Especialidades.Text}, foi atualizada com sucesso!", "Atualização bem sucedida");
                        limpar_Campos();
                        especialidades.listar_Especialidades();
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    if (ex.Message.Contains("O nome da especialidade já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                        MessageDialog_Error.Show("Não possível atualizar esta especialidade.", ex.Message);
                }
            }
        }

        private void limpar_Campos()
        {
            text_Especialidades.Text = "";
            text_curso.Text = "";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }

        private void text_Especialidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é uma letra, tecla de controle ou espaço em branco
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_erro.Visible = false; // Oculta a mensagem de erro
                text_Especialidades.BorderColor = Color.FromArgb(23, 35, 49); // Restaura a cor da borda para a cor padrão
                text_Especialidades.ForeColor = Color.FromArgb(68, 88, 100); // Restaura a cor do texto
                text_Especialidades.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                text_Especialidades.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            }
            else if (char.IsDigit(e.KeyChar)) // Se a entrada for um número
            {
                label_msg_erro.Text = "Apenas letras são permitidas!";
                text_Especialidades.BorderColor = Color.Tomato; // Altera a cor da borda para vermelho
                text_Especialidades.ForeColor = Color.Tomato; // Altera a cor do texto para vermelho
                text_Especialidades.HoverState.BorderColor = Color.Tomato; // Altera a cor do texto para vermelho
                text_Especialidades.FocusedState.BorderColor = Color.Tomato; // Altera a cor do texto para vermelho
                label_msg_erro.Visible = true; // Exibe a mensagem de erro

                e.Handled = true; // Impede a entrada do número
            }
            else
            {
                e.Handled = true; // Impede qualquer outra entrada
                label_msg_erro.Visible = false; // Mantém a mensagem oculta
            }
        }
    }
}
