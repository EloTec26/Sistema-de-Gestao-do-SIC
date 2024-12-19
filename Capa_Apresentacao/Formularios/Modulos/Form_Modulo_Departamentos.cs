using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Departamentos : Form
    {
        e_comum_departamentos c_Departamentos = new e_comum_departamentos();
        dominio_departamentos d_Departamentos = new dominio_departamentos();
        //comum_cache_permissoes_usuarios permissoes_Usuarios = new comum_cache_permissoes_usuarios();
        public Form_Modulo_Departamentos()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerificarCamposVazios()
        {
            if (text_departamento.Text == "" || text_descricao.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return false;
            }
            return true;
        }
        private void capturar_Dados_Digitados_Formulario()
        {
            // Capturar os dados do formulário
            string departamento = text_departamento.Text;
            string descricao = text_descricao.Text;
            DateTime data_registro = text_data_registro.Value;
            DateTime data_atualizacao = DateTime.Now;
            // Salvar os dados capturados
            c_Departamentos.nome = departamento;
            c_Departamentos.descricao = descricao;
            c_Departamentos.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            c_Departamentos.data_registro = data_registro;
            c_Departamentos.data_atualizacao = data_atualizacao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    capturar_Dados_Digitados_Formulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este departamento?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Departamentos.inserir_Departamentos(c_Departamentos);
                        guna2MessageDialog_Inform.Show($"O departamento {text_departamento.Text}, foi registrado com sucesso!", "Registro bem sucedido");
                        // Limpar os campos depois de atualizar
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar este departamento!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    // Capturar o id
                    int id_departamento = Convert.ToInt32(label_id.Text);
                    capturar_Dados_Digitados_Formulario();
                    // Atualizar os dados capturados
                    c_Departamentos.id_departamento = id_departamento;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este departamento?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Departamentos.atualizar_Departamentos(c_Departamentos);
                        guna2MessageDialog_Inform.Show($"O departamento {text_departamento.Text}, foi atualizado com sucesso!", "Registro bem sucedido");
                        // Limpar os campos depois de atualizar
                        limpar_Campos();
                        // fechar o formulário depois de atualizar o departamento
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este departamento!", Ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_departamento.Clear();
            text_descricao.Clear();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }


        private void text_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_departamento, label_msg_departamento, "Apenas letras são permitidas!");
        }

        private void text_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_descricao, label_msg_descricao, "Apenas letras são permitidas!");
        }
    }
}
