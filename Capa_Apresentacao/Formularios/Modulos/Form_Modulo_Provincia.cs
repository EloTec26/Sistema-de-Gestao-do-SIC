using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using System.Data.SqlClient;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Provincia : Form
    {
        #region Instanciação das classes e métodos
        e_comum_provincias c_provincias = new e_comum_provincias();
        dominio_provincias d_provincias = new dominio_provincias();
        dominio_paises p_paises = new dominio_paises();
        #endregion
        public Form_Modulo_Provincia()
        {
            InitializeComponent();
            selecionar_paises_no_comboBox();
        }
        private void selecionar_paises_no_comboBox()
        {
            text_paises.DataSource = p_paises.selecionar_paises_comboBox();
            text_paises.DisplayMember = "nome";
            text_paises.ValueMember = "id_pais";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDados()
        {
            // Capturar os dados digitados no formulário
            string nome = text_provincia.Text;
            int pais = Convert.ToInt32(text_paises.SelectedValue);
            // Registrar os dados capturados
            c_provincias.nome = nome;
            c_provincias.id_pais = pais;
        }
        private bool VerificarCampos()
        {
            if (text_provincia.Text == String.Empty || text_paises.Text == "")
            {
                MessageDialog_Error.Show($"Os campos com (*) são de preenchimento obrigatório!\n" +
                    $"Por favor, preencha-os e tente novamente.", "Erro de cadastro");
                return false;
            }
            return true;
        }
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    DateTime data_registro = DateTime.Now;
                    DateTime data_atualizacao = DateTime.Now;
                    c_provincias.data_registro = data_registro;
                    c_provincias.data_atualizacao = data_atualizacao;
                    CapturarDados();
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de registrar esta província?", $"Mensagem de registro") == DialogResult.Yes)
                    {
                        //Registrar
                        d_provincias.registrar_provincias(c_provincias);
                        guna2MessageDialog_Inform.Show($"A província foi registrada com sucesso!", "Registro bem sucedido");
                        // Limpa todos os campos depois do registro.
                        Limpar();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    string erro_Duplicacao = ex.Message;
                    if (erro_Duplicacao.Contains("nome"))
                    {
                        MessageDialog_Error.Show("Esta província já existe!\nPor favor, insira uma outra província e tente novamente!", "Erro de duplicação");
                        text_provincia.Focus();
                    }
                    else
                    {
                        MessageDialog_Error.Show("Esta província já existe!\nPor favor, insira uma outra província e tente novamente!", "Erro de duplicação");
                        text_provincia.Focus();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não possível registrar esta província!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    DateTime data_atualizacao = DateTime.Now;
                    c_provincias.data_atualizacao = data_atualizacao;
                    c_provincias.id_provincia = Convert.ToInt32(label_id.Text);
                    CapturarDados();
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de atualizar esta província?", $"Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_provincias.registrar_provincias(c_provincias);
                        guna2MessageDialog_Inform.Show($"A província foi atualizada com sucesso!", "Atualização bem sucedida");
                        Limpar();
                        this.Close();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    string erro_Duplicacao = ex.Message;
                    if (erro_Duplicacao.Contains("nome"))
                    {
                        MessageDialog_Error.Show("Esta província já existe!\nPor favor, insira uma outra província e tente novamente!", "Erro de duplicação");
                        text_provincia.Focus();
                    }
                    else
                    {
                        MessageDialog_Error.Show("Esta província já existe!\nPor favor, insira uma outra província e tente novamente!", "Erro de duplicação");
                        text_provincia.Focus();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não possível registrar esta província!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            label_id.ResetText();
            text_provincia.Clear();
            text_paises.SelectedIndex = -1;
        }
        private void text_provincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_provincia, label_msg_provincia, "Apenas letras são permitidas!");
        }
    }
}
