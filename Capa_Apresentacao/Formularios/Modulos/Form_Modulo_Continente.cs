using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;


namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Continente : Form
    {
        #region Instanciar as classes e os métodos
        e_comum_continentes c_continentes = new e_comum_continentes();
        dominio_continentes d_continentes = new dominio_continentes();
        #endregion
        public Form_Modulo_Continente()
        {
            InitializeComponent();
        }
        private void CapturarDados()
        {
            string nome = text_continentes.Text;
            c_continentes.nome = nome;
        }
        private bool ValidarCampos()
        {
            if (text_continentes.Text == "")
            {
                MessageDialog_Error.Show($"Os campos com (*) são de preenchimento obrigatório!\n" +
                  $"Por favor, preencha-os e tente novamente.", "Erro de cadastro");
                return false;
            }
            return true;
        }
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    DateTime data_registro = DateTime.Now;
                    DateTime data_atualizacao = DateTime.Now;

                    c_continentes.data_registro = data_registro;
                    c_continentes.data_atualizacao = data_atualizacao;
                    CapturarDados();
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de registrar este continente?", $"Mensagem de registro") == DialogResult.Yes)
                    {
                        d_continentes.registrar_continentes(c_continentes);
                        guna2MessageDialog_Inform.Show($"O continente foi registrado com sucesso!", "Registro bem sucedido");
                        Limpar_campos();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("O nome do continente já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                    {
                        MessageDialog_Error.Show("Não possível registrar este continente!", ex.Message);
                    }
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    c_continentes.id_continente = Convert.ToInt32(label_id.Text);
                    c_continentes.data_atualizacao = DateTime.Now;
                    CapturarDados();
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de atualizar este continente?", $"Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_continentes.atualizar_continentes(c_continentes);
                        guna2MessageDialog_Inform.Show($"O continente foi atualizado com sucesso!", "Atualização bem sucedida");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("O nome do continente já existe"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                    {
                        MessageDialog_Error.Show("Não possível registrar este continente!", ex.Message);
                    }
                }
            }
        }
        public void Limpar_campos()
        {
            text_continentes.SelectedIndex = -1;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar_campos();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            Limpar_campos();
        }

        private void Form_Modulo_Continente_Load(object sender, EventArgs e)
        {
        }
    }
}
