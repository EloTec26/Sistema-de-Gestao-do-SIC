using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Bairro_Rua : Form
    {
        // Instanciar as classes e os métodos
        e_comum_bairro_rua c_Bairro_Rua = new e_comum_bairro_rua();
        dominio_bairro_rua d_Bairro_Rua = new dominio_bairro_rua();
        dominio_municipios d_Municipios = new dominio_municipios();
        public Form_Modulo_Bairro_Rua()
        {
            InitializeComponent();
            carregar_Dados_No_Combo_Box_Municipios();
        }
        private void carregar_Dados_No_Combo_Box_Municipios()
        {
            text_municipio.DataSource = d_Municipios.selecionar_municipios_comboBox();
            text_municipio.DisplayMember = "nome";
            text_municipio.ValueMember = "id_municipio";
        }
        private void capturar_Dados_Digitados_Formulario()
        {
            // Capturar os dados digitados no formulário
            int municipio = Convert.ToInt32(text_municipio.SelectedValue);
            string nome = text_bairro_rua.Text;
           

            // Registrar os dados digitados
            c_Bairro_Rua.id_municipio = municipio;
            c_Bairro_Rua.nome = nome;
           
        }
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (text_bairro_rua.Text == "" || text_municipio.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {

                DateTime data_registro = DateTime.Now;
                DateTime data_atualizacao = DateTime.Now;

                c_Bairro_Rua.data_registro = data_registro;
                c_Bairro_Rua.data_atualizacao = data_atualizacao;
                capturar_Dados_Digitados_Formulario();

                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este bairro/rua?", "Mensagem de registro") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    d_Bairro_Rua.registrar_bairros_ruas(c_Bairro_Rua);
                    guna2MessageDialog_Inform.Show($"O bairro/rua {text_bairro_rua.Text}, foi registrado com sucesso!", "Registro bem sucedido");
                    limpar_Campos();
                }
            }
           
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do bairro/rua já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                else
                    MessageDialog_Error.Show("Não possível salvar este bairro/rua", ex.Message);
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (text_bairro_rua.Text == "" || text_municipio.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {
                // Capturar os dados digitados no formulário
                int id = Convert.ToInt32(label_id.Text);

                DateTime data_atualizacao = DateTime.Now;
                c_Bairro_Rua.data_atualizacao = data_atualizacao;

                capturar_Dados_Digitados_Formulario();

                // Atualizar os dados digitados
                c_Bairro_Rua.id_bairro_rua = id;
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este bairro/rua?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;

                    d_Bairro_Rua.atualizar_bairros_ruas(c_Bairro_Rua);

                    guna2MessageDialog_Inform.Show($"O bairro/rua {text_municipio.Text}, foi atualizado com sucesso!", "Atualização bem sucedida");
                    this.Close();
                    limpar_Campos();
                }
            }
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do bairro/rua já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                MessageDialog_Error.Show("Não possível atualizar este bairro/rua", ex.Message);
            }
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_bairro_rua.Clear();
            text_municipio.SelectedIndex = -1;
        }


        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            limpar_Campos();
        }

        private void text_bairro_rua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_bairro_rua.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_bairro_rua.Text = "Apenas letras são permitidas!";
                label_msg_bairro_rua.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_bairro_rua.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }
    }
}
