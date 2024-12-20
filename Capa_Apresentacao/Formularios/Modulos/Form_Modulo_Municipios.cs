using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Municipios : Form
    {
        #region Instanciar as classes e os métodos
        e_comum_municipios c_Municipios = new e_comum_municipios();
        dominio_municipios d_Municipios = new dominio_municipios();
        dominio_provincias d_Provincias = new dominio_provincias();
        #endregion
        public Form_Modulo_Municipios()
        {
            InitializeComponent();
            carregar_Provincia_comboBox();
        }
        private void carregar_Provincia_comboBox()
        {
            text_provincias.DataSource = d_Provincias.selecionar_provincias_ComboBox();
            text_provincias.DisplayMember = "nome";
            text_provincias.ValueMember = "id_provincia";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDados()
        {
            // Capturar os dados digitados no formulário
            int provincia = Convert.ToInt32(text_provincias.SelectedValue);
            string nome = text_municipio.Text;
            c_Municipios.id_provincia = provincia;
            c_Municipios.nome = nome;
        }
        private bool VerificarCampos()
        {
            if (text_municipio.Text == "" || text_provincias.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return false;
            }
            return true;
        }
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            // Verificar a existência de campos vazios
            if (VerificarCampos())
            {
                try
                {
                    DateTime data_registro = DateTime.Now;
                    DateTime data_atualizacao = DateTime.Now;

                    // Registrar os dados digitados
                    CapturarDados();
                    c_Municipios.data_registro = data_registro;
                    c_Municipios.data_atualizacao = data_atualizacao;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este município?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Municipios.registrar_municipios(c_Municipios);
                        guna2MessageDialog_Inform.Show($"O município {text_municipio.Text}, foi registrado com sucesso!", "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome do município já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                        MessageDialog_Error.Show("Não possível salvar este municipio", ex.Message);
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
                    // Capturar os dados digitados no formulário
                    int id = Convert.ToInt32(label_id.Text);
                    DateTime data_atualizacao = DateTime.Now;

                    // Atualizar os dados digitados
                    c_Municipios.id_municipio = id;
                    c_Municipios.data_atualizacao = data_atualizacao;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este município?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Municipios.atualizar_municipios(c_Municipios);
                        guna2MessageDialog_Inform.Show($"O município {text_municipio.Text}, foi atualizado com sucesso!", "Atualização bem sucedida");
                        this.Close();
                        limpar_Campos();
                    }
                }
                catch (Exception ex)
                {
                    // capturar a mensagem de exceção personalizada da camada de domínio
                    if (ex.Message.Contains("O nome do município já está registrado"))
                    {
                        MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                    }
                    else
                        MessageDialog_Error.Show("Não possível atualizar este municipio", ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_municipio.Clear();
            text_provincias.SelectedIndex = -1;
        }

        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            limpar_Campos();
        }


        private void text_municipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_municipio, label_msg_municipio, "Apenas letras são permitidas!");
        }
    }
}
