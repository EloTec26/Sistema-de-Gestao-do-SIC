using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;


namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Beneficios : Form
    {
        e_comum_beneficios c_Beneficios = new e_comum_beneficios();
        dominio_beneficos d_Beneficios = new dominio_beneficos();
        public Form_Modulo_Beneficios()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void capturar_Dados_Digitados_Formulario()
        {
            // Capturar os dados digitados no formulário
            string beneficio = text_beneficio.Text;
            string descricao = text_descricao.Text;
         
            // Registrar os dados digitados
            c_Beneficios.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            c_Beneficios.nome = beneficio;
            c_Beneficios.descricao = descricao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (text_beneficio.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {
                DateTime data_registro = DateTime.Now;
                DateTime data_atualizacao = DateTime.Now;
                c_Beneficios.data_registro = data_registro;
                c_Beneficios.data_atualizacao = data_atualizacao;

                capturar_Dados_Digitados_Formulario();

                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este benefício?", "Mensagem de registro") == DialogResult.Yes)
                {
                    d_Beneficios.inserir_Beneficos(c_Beneficios);
                    guna2MessageDialog_Inform.Show($"O benefício {text_beneficio.Text}, foi registrado com sucesso!", "Registro bem sucedido");
                    limpar_Campos();
                }
            }
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message, "Ocorreu um erro ao tentar salvar...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}
            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não possível salvar este beneficio.", Ex.Message);
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (text_beneficio.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {
                // Capturar o id
                int id_beneficio = Convert.ToInt32(label_id.Text);

                DateTime data_atualizacao = DateTime.Now;
                c_Beneficios.data_atualizacao = data_atualizacao;

                capturar_Dados_Digitados_Formulario();

                // --------------------------------------------------------
                c_Beneficios.id_beneficio = id_beneficio;

                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este benefício?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    d_Beneficios.atualisar_Beneficos(c_Beneficios);
                    guna2MessageDialog_Inform.Show($"O benefício {text_beneficio.Text}, foi atualizado com sucesso!", "Atualização bem sucedida");
                    limpar_Campos();
                    this.Close();
                }

            }
            //catch (ArgumentException Ex)
            //{
            //    MessageBox.Show(Ex.Message, "Ocorreu um erro ao tentar atualizar...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}
            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não possível atualizar este beneficio", Ex.Message);
            }
        }
        private void limpar_Campos()
        {
            text_beneficio.Clear();
            text_descricao.Clear();
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void text_beneficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, teclas de controle (como Backspace).
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_benefio.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_benefio.Text = "Apenas letras são permitidas!";
                label_msg_benefio.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_benefio.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }
        private void text_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permite letras, teclas de controle (como Backspace).
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_descricao.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_descricao.Text = "Apenas letras são permitidas!";
                label_msg_descricao.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_descricao.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }

    }
}
