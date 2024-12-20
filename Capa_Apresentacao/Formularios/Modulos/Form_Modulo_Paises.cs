using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Paises : Form
    {
        #region Instanciar as classes e os métodos
        dominio_continentes selecionar_continentes = new dominio_continentes();
        dominio_paises d_paises = new dominio_paises();
        e_comum_paises c_paises = new e_comum_paises();
        #endregion
        public Form_Modulo_Paises()
        {
            InitializeComponent();
            carregar_continentes_combo_box();
        }
        private void Form_Modulo_Paises_Load(object sender, EventArgs e)
        {

        }
        #region Carregar os continentes no comboBox
        private void carregar_continentes_combo_box()
        {
            text_continentes.DataSource = selecionar_continentes.selecionar_continentes();
            text_continentes.DisplayMember = "nome";
            text_continentes.ValueMember = "id_continente";
        }
        #endregion
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerificarCampos()
        {
            // Verificar a existência de campos vazios
            if (text_pais.Text == String.Empty || text_continentes.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com asterísticos(*) são de preenchimento obrigatório!" +
                              "\nPor favor, preencha-os e tente novamente!", "Alerta");
                return false;
            }
            return true;
        }
        private void CapturarCampos()
        {
            string nome = text_pais.Text;
            int continente = Convert.ToInt32(text_continentes.SelectedValue);

            c_paises.nome = nome;
            c_paises.id_continente = continente;
        }
        private void btn_salvar_Click_1(object sender, EventArgs e)
        { 
            // Verificar a existência de campos vazios
            if (VerificarCampos())
            {
                try
                {
                    // Capturar os dados digitados
                    CapturarCampos();
                    DateTime data_registro = DateTime.Now;
                    DateTime data_atualizacao = DateTime.Now;
                    // Registrar os dados cadastrados
                    c_paises.data_registro = data_registro;
                    c_paises.data_atualizacao = data_atualizacao;
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de registrar este país?", $"Mensagem de registro") == DialogResult.Yes)
                    {
                        d_paises.registrar_paises(c_paises);
                        guna2MessageDialog_Inform.Show($"O país foi registrado com sucesso!", "Registro bem sucedida");
                        // Fecha o formulário depois da atualização.
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome do país já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                    {
                        MessageDialog_Error.Show("Não foi possível registrar este  país", ex.Message);
                    }
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (VerificarCampos())
            {
                try
                {
                    // Capturar os dados digitados
                    int id = Convert.ToInt32(label_id.Text);
                    DateTime data_atualizacao = DateTime.Now;
                    // Registrar os dados cadastrados
                    c_paises.id_pais = id;
                    c_paises.data_atualizacao = data_atualizacao;
                    CapturarCampos();
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de atualizar este país?", $"Mensagem de registro") == DialogResult.Yes)
                    {
                        d_paises.atualizar_paises(c_paises);
                        guna2MessageDialog_Inform.Show($"O país foi atualizado com sucesso!", "Atualização bem sucedida");
                        // Fecha o formulário depois da atualização.
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome do país já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                    {
                        MessageDialog_Error.Show("Não foi possível atualizar este  país", ex.Message);
                    }
                }
            }
        }
        #region Limpar os campos
        private void limpar_campos()
        {
            text_pais.Text = "";
            text_continentes.SelectedIndex = -1;
        }
        #endregion

        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            limpar_campos();
        }
        private void text_pais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_pais.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_pais.Text = "Apenas letras são permitidas!";
                label_msg_pais.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_pais.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }


    }
}
