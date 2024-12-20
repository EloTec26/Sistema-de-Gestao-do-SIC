using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Cargos : Form
    {
        #region Instanciar métodos
        e_comum_cargos c_Cargos = new e_comum_cargos();
        dominio_cargos d_Cargos = new dominio_cargos();
        #endregion
        public Form_Modulo_Cargos()
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
            string nome_Cagro = text_Cargo.Text;
           
            //--------------------------------------------------------------
            c_Cargos.nome = nome_Cagro;
            c_Cargos.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
           

        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_Cargo.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimanto obrogatório!\n" +
                    "Por favor, preencha-os e tente novamente!", "Erro ao salvar o cargo");
                return;
            }
            try
            {
                DateTime data_Registro = DateTime.Now;
                DateTime data_Atualizacao = DateTime.Now;
                c_Cargos.data_registro = data_Registro;
                c_Cargos.data_atualizacao = data_Atualizacao;
                capturar_Dados_Digitados_Formulario();
                // Registrar os dados capturados
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este cargo?", "Mensagem de registro") == DialogResult.Yes)
                {
                    d_Cargos.inserir_Cargos(c_Cargos);
                    guna2MessageDialog_Inform.Show($"O cargo {text_Cargo.Text} foi registrado com sucesso!", "Registro bem sucedido");
                    Limpar_Campos();
                }
            }
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do cargo já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                else
                    MessageBox.Show("Não foi possível registrar este cargo!", ex.Message);
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (text_Cargo.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimanto obrogatório!\n" +
                    "Por favor, preencha-os e tente novamente!", "Erro ao salvar o cargo");
                return;
            }
            try
            {
                // Capturar os dados digitados no formulário
                int id_Cargo = Convert.ToInt32(label_id.Text);
        
                DateTime data_Atualizacao = DateTime.Now;
            
                c_Cargos.data_atualizacao = data_Atualizacao;
                capturar_Dados_Digitados_Formulario();
                c_Cargos.id_cargo = id_Cargo;
                // Registrar os dados capturados
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este cargo?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    d_Cargos.atualizar_Cargos(c_Cargos);
                    guna2MessageDialog_Inform.Show($"O cargo {text_Cargo.Text} foi atualizado com sucesso!", "Atualização bem sucedida");
                    this.Close();
                    Limpar_Campos();
                }
            }
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do cargo já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                else
                    MessageBox.Show("Não foi possível atualizar 11 este cargo!", ex.Message);
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar_Campos();
        }
        private void Limpar_Campos()
        {
            text_Cargo.Text = String.Empty;
        }
        private void text_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_cargos.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_cargos.Text = "Apenas letras são permitidas!";
                label_msg_cargos.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_cargos.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }
    }
}
