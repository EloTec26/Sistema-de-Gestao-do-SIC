using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Casos : Form
    {
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_departamentos d_Departamentos = new dominio_departamentos();
        e_comum_casos c_Casos = new e_comum_casos();
        dominio_casos d_Casos = new dominio_casos();
        public Form_Modulo_Casos()
        {
            InitializeComponent();
            carregar_Dados_ComboBoxs();
        }
        private void carregar_Dados_ComboBoxs()
        {
            text_investigador.DataSource = d_Investigadores.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";

            //-------------------------------------------
            text_departamento.DataSource = d_Departamentos.selecionar_Departamentos_Combo_Box();
            text_departamento.DisplayMember = "nome";
            text_departamento.ValueMember = "id_departamento";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void capturar_Dados_Digitados_Formulario()
        {
            // Capturar os dados digitados no formulário
            int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
            int id_Departamento = Convert.ToInt32(text_departamento.SelectedValue);
            int id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            string titulo = text_titulo.Text;
            DateTime data_Abertura = text_data_abetura.Value;
            DateTime data_Fechamento = text_data_fechamento.Value;
            string estado = text_estado.Text;
            string descricao = text_descricao.Text;
            DateTime data_Registro = text_data_registro.Value;
            DateTime data_Atualizacao = DateTime.Now;
            // Salvar os dados capturados
            c_Casos.id_investigador = id_Investigador;
            c_Casos.id_departamento = id_Departamento;
            c_Casos.id_usuario = id_Usuario;
            c_Casos.titulo = titulo;
            c_Casos.data_abertura = data_Abertura;
            c_Casos.data_fechamento = data_Fechamento;
            c_Casos.estado = estado;
            c_Casos.descricao = descricao;
            c_Casos.data_registro = data_Registro;
            c_Casos.data_atualizacao = data_Atualizacao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_investigador.Text == "" || text_departamento.Text == "" || text_titulo.Text == "" || text_estado.Text == "" || text_descricao.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\nPor favor, preencha-os e tente novamente!");
                return;
            }
            if (text_data_abetura.Value < DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A data de abertura não pode estar numa data passada.", "Erro de seleção da data");
                return;
            }
            if (text_data_fechamento.Value <= DateTime.Now)
            {
                MessageDialog_Error.Show("A data de fechamento não pode estar numa data passada ou presente", "Erro de seleção da data");
                return;
            }
            if (text_data_registro.Value < DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A data de registro não pode estar numa data passada ou futura", "Erro de seleção da data");
                return;
            }
            else
            {
                try
                {
                    capturar_Dados_Digitados_Formulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este caso?", "Mensagem de confirmação") == DialogResult.Yes)
                    {
                        Program.AJUDA = 0;
                        d_Casos.inserir_Casos(c_Casos);
                        guna2MessageDialog_Inform.Show("O caso foi registrado com sucesso!", "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Não foi possível salvar este caso!", Ex.Message);
                }
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (text_investigador.Text == "" || text_departamento.Text == "" || text_titulo.Text == "" || text_estado.Text == "" || text_descricao.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\nPor favor, preencha-os e tente novamente!");
                return;
            }
            if (text_data_abetura.Value < DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A data de abertura não pode estar numa data passada.", "Erro de seleção da data");
                return;
            }
            if (text_data_fechamento.Value <= DateTime.Now)
            {
                MessageDialog_Error.Show("A data de fechamento não pode estar numa data passada ou presente", "Erro de seleção da data");
                return;
            }
            if (text_data_registro.Value < DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A data de registro não pode estar numa data passada ou futura", "Erro de seleção da data");
                return;
            }
            // Atualizar
            else
            {
                try
                {
                    // Capturar o id 
                    int id_caso = Convert.ToInt32(label_id.Text);
                    capturar_Dados_Digitados_Formulario();
                    // ---------------------------------------------------------
                    c_Casos.id_caso = id_caso;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este casp?", "Mensagem de confirmação") == DialogResult.Yes)
                    {
                        Program.AJUDA = 0;

                        d_Casos.atualizar_Casos(c_Casos);
                        guna2MessageDialog_Inform.Show($"O caso com o título {text_titulo.Text} foi atualizado com sucesso!", "Atualização bem sucedida");
                        limpar_Campos();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Não foi possível atualizar este caso!", Ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_investigador.SelectedIndex = -1;
            text_departamento.SelectedIndex = -1;
            text_data_abetura.Value = DateTime.Now;
            text_data_fechamento.Value = DateTime.Now;
            text_estado.SelectedIndex = -1;
            text_descricao.Text = "";
            text_data_registro.Value = DateTime.Now;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }

        private void text_titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_casos.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_casos.Text = "Apenas letras são permitidas!";
                label_msg_casos.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_casos.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
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