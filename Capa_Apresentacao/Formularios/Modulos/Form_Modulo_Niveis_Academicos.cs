//-------------------------------
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Niveis_Academicos : Form
    {
        e_comum_nivel_academicos c_Nivel_Academicos = new e_comum_nivel_academicos();
        dominio_niveis_academicos d_Niveis_Academicos = new dominio_niveis_academicos();
        public Form_Modulo_Niveis_Academicos()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDadosFormulario()
        {
            //
            string nivel_Academico = text_Nivel_Academico.Text;
            DateTime data_Registro = text_Data_Registro.Value;
            DateTime data_atualizacao = DateTime.Now;
            //
            c_Nivel_Academicos.nome = nivel_Academico;
            c_Nivel_Academicos.data_registro = data_Registro;
            c_Nivel_Academicos.data_atualizacao = data_atualizacao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_Nivel_Academico.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {
                CapturarDadosFormulario();
                //
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este nível acadêmico?", "Mensagem de registro") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    d_Niveis_Academicos.inserir_niveis_academicos(c_Nivel_Academicos);
                    guna2MessageDialog_Inform.Show($"O nível acadêmico {text_Nivel_Academico.Text}, foi registrado com  sucesso", "Registro bem sucedido");
                    limpar_Campos();
                }
            }
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do nivel acadêmico já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                else
                    MessageDialog_Error.Show("Não foi possível salvar este nivel acadêmico", ex.Message);
            }
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (text_Nivel_Academico.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {
                int id_Nivel_Academico = Convert.ToInt32(label_id.Text);
                //
                CapturarDadosFormulario();
                c_Nivel_Academicos.id_nivel_academico = id_Nivel_Academico;

                //
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este nível acadêmico?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    d_Niveis_Academicos.atualizar_niveis_academicos(c_Nivel_Academicos);
                    guna2MessageDialog_Inform.Show($"O nível acadêmico {text_Nivel_Academico.Text}, foi atualizado com  sucesso!", "Atualização bem sucedida");
                    limpar_Campos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do nivel acadêmico já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                else
                    MessageDialog_Error.Show("Não foi possível atualizar este nível academico!", ex.Message);
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_Nivel_Academico.Text = "";
        }
    }
}
