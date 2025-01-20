//-------------------------------
using Capa_Apresentacao.Formularios.Lista_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Niveis_Academicos : Form
    {
        e_comum_nivel_academicos c_Nivel_Academicos = new e_comum_nivel_academicos();
        dominio_niveis_academicos d_Niveis_Academicos = new dominio_niveis_academicos();
        Form_Lista_Niveis_Academicos niveis_Academicos;
        public Form_Modulo_Niveis_Academicos(Form_Lista_Niveis_Academicos niveis_Academicos)
        {
            InitializeComponent();
            this.niveis_Academicos = niveis_Academicos;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDadosFormulario()
        {
            //
            string nivel_Academico = text_Nivel_Academico.Text;

            //
            c_Nivel_Academicos.nome = nivel_Academico;

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
                DateTime data_Registro = DateTime.Now;
                DateTime data_atualizacao = DateTime.Now;
                c_Nivel_Academicos.data_registro = data_Registro;
                c_Nivel_Academicos.data_atualizacao = data_atualizacao;
                //
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este nível acadêmico?", "Mensagem de registro") == DialogResult.Yes)
                {
                    d_Niveis_Academicos.inserir_niveis_academicos(c_Nivel_Academicos);
                    guna2MessageDialog_Inform.Show($"O nível acadêmico {text_Nivel_Academico.Text}, foi registrado com  sucesso", "Registro bem sucedido");
                    niveis_Academicos.listat_Niveis_Academicos();
                    limpar_Campos();
                }
            }
            //catch (ArgumentException ex)
            //{
            //    MessageDialog_Error.Show(ex.Message);
            //}
            catch(Exception ex)
            {
                MessageDialog_Error.Show("Não foi possível registrar este nível acadêmico!" + ex.Message);
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
                DateTime data_atualizacao = DateTime.Now;
                c_Nivel_Academicos.data_atualizacao = data_atualizacao;
                c_Nivel_Academicos.id_nivel_academico = id_Nivel_Academico;

                //
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este nível acadêmico?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    d_Niveis_Academicos.atualizar_niveis_academicos(c_Nivel_Academicos);
                    guna2MessageDialog_Inform.Show($"O nível acadêmico {text_Nivel_Academico.Text}, foi atualizado com  sucesso!", "Atualização bem sucedida");
                    limpar_Campos();
                    niveis_Academicos.listat_Niveis_Academicos();
                    this.Close();
                }
            }
            //catch (ArgumentException ex)
            //{              
            //    MessageDialog_Error.Show(ex.Message);
            //}
            catch(Exception ex)
            {
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
