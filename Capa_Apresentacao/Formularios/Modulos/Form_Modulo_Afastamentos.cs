using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Afastamentos : Form
    {
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        e_comum_afastamentos c_Afastamentos = new e_comum_afastamentos();
        dominio_afastamentos d_Afastamentos = new dominio_afastamentos();
        public Form_Modulo_Afastamentos()
        {
            InitializeComponent();
            buscar_Nomes_Investigadores();
        }
        private void buscar_Nomes_Investigadores()
        {
            text_investigador.DataSource = d_Investigadores.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void capturar_Dados_Digitados_Formulario()
        {
            // Capturar os dados no formulário
            int nome_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
            DateTime data_Inicial = text_data_inicio_afastamentos.Value;
            DateTime data_Final = text_data_final_afastamentos.Value;
            string descricao = text_descricao.Text;
            string estado = text_Estado.Text;

            // Registrar os dados capturados
            c_Afastamentos.id_investigador = nome_Investigador;
            c_Afastamentos.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            c_Afastamentos.data_inicio = data_Inicial;
            c_Afastamentos.data_fim = data_Final;
            c_Afastamentos.descricao = descricao;
            c_Afastamentos.estado = estado;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_investigador.Text == String.Empty || text_descricao.Text == String.Empty || text_Estado.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos são de preenchimento obrigatório!" +
                    "Por favor, preencha-os e tente novamente.", "Erro ao salvar os dados");
                return;
            }
            else
            {
                try
                {
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Afastamentos.data_registro = data_Registro;
                    c_Afastamentos.data_atualizacao = data_Atualizacao;

                    capturar_Dados_Digitados_Formulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este afastamento?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Afastamentos.inserir_Afastamentos(c_Afastamentos);
                        guna2MessageDialog_Inform.Show($"O afastamento foi registrado com sucesso!", "Registro bem sucedido");
                        Limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar esses dados!", Ex.Message);
                }
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (text_investigador.Text == String.Empty || text_descricao.Text == String.Empty || text_Estado.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos são de preenchimento obrigatório!" +
                    "Por favor, preencha-os e tente novamente.", "Erro ao salvar os dados");
                return;
            }
            else
            {
                try
                {
                    // Capturar o id.
                    int id_Afastamento = Convert.ToInt32(label_id.Text);

                    DateTime data_Atualizacao = DateTime.Now;
                    c_Afastamentos.data_atualizacao = data_Atualizacao;

                    // Atualizar os dados capturados
                    capturar_Dados_Digitados_Formulario();
                    c_Afastamentos.id_afastamento = id_Afastamento;
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este afastamento?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Afastamentos.atualizar_Afastamentos(c_Afastamentos);
                        guna2MessageDialog_Inform.Show($"O afastamento foi atualizado com sucesso!", "Atualização bem sucedida");
                        Limpar_Campos();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar esses dados!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar_Campos();
        }
        private void Limpar_Campos()
        {
            text_investigador.SelectedIndex = -1;
            text_descricao.Text = "";
            text_Estado.SelectedIndex = -1;
        }
        private void text_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, teclas de controle (como Backspace), espaço e caracteres especiais
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '[' || e.KeyChar == ']' ||
                e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == 'º' ||
                e.KeyChar == 'ª' || e.KeyChar == '@' || e.KeyChar == '#' || e.KeyChar == '*' ||
                e.KeyChar == '/' || e.KeyChar == ';' || e.KeyChar == ':' || e.KeyChar == '?' ||
                e.KeyChar == '+' || e.KeyChar == '=')
            {
                e.Handled = false; // Permite a entrada
                label15.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label15.Text = "Apenas letras e alguns caracteres especiais são permitidos!";
                label15.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label15.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }
    }
}
