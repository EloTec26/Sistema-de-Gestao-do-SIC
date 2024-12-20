using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Evidencias : Form
    {
        e_comum_evidencias c_Evidencias = new e_comum_evidencias();
        dominio_evidencias d_Evidencias = new dominio_evidencias();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_casos d_Casos = new dominio_casos();
        public Form_Modulo_Evidencias()
        {
            InitializeComponent();
            carregar_Dados_ComboBoxs();
        }
        private void carregar_Dados_ComboBoxs()
        {
            text_investigador.DataSource = d_Investigadores.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";

            //-------------------------------------------
            text_caso.DataSource = d_Casos.selecionar_Casos_Combo_Box();
            text_caso.DisplayMember = "titulo";
            text_caso.ValueMember = "id_caso";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDadosFormulario()
        {
            int id_Funcionario = Convert.ToInt32(text_investigador.SelectedValue);
            int id_Caso = Convert.ToInt32(text_caso.SelectedValue);
            int id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            string tipo = text_tipo.Text;
            string descricao = text_descricao.Text;
            DateTime data_Coleta = text_data_coleta.Value;
            string local_Armazenamento = text_local_armazenamento.Text;

            c_Evidencias.id_investigador = id_Funcionario;
            c_Evidencias.id_caso = id_Caso;
            c_Evidencias.id_usuario = id_Usuario;
            c_Evidencias.tipo = tipo;
            c_Evidencias.descricao = descricao;
            c_Evidencias.data_coleta = data_Coleta;
            c_Evidencias.local_armazenamento = local_Armazenamento;
        }
        private bool VerificarCampos()
        {
            if (text_investigador.Text == "" || text_caso.Text == "" || text_tipo.Text == "" || text_descricao.Text == "" ||
                text_local_armazenamento.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com asteríscos(*), são de preenchimento obrigatório\nPor favor, preencha-os e tente novamente!");
                return false;
            }
            return true;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Evidencias.data_registro = data_Registro;
                    c_Evidencias.data_atualizacao = data_Atualizacao;
                    CapturarDadosFormulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta evidência?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Evidencias.inserir_evidencias(c_Evidencias);
                        guna2MessageDialog_Inform.Show($"A evidência do tipo {text_tipo.Text}, foi registrada com sucesso!", "Registro bem sucedido");
                        limpar_campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível registrar essa evidência", Ex.Message);
                }
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    int id_Evidencia = Convert.ToInt32(label_id.Text);
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Evidencias.data_atualizacao = data_Atualizacao;
                    c_Evidencias.id_evidencia = id_Evidencia;

                    CapturarDadosFormulario();

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar esta evidência?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Evidencias.atualizar_evidencias(c_Evidencias);
                        guna2MessageDialog_Inform.Show($"A evidência do tipo {text_tipo.Text}, foi atualizada com sucesso!", "Atualização bem sucedida");
                        limpar_campos();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar essa evidência", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_campos();
        }

        private void limpar_campos()
        {
            text_investigador.Text = "";
            text_caso.Text = "";
            text_tipo.Text = "";
            text_descricao.Text = "";
            text_local_armazenamento.Text = "";
            text_data_coleta.Value = DateTime.Now;
        }
        private void text_local_armazenamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, teclas de controle (como Backspace).
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label_msg_local_armazenamento.Visible = false; // Oculta o Label se a entrada for válida
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                label_msg_local_armazenamento.Text = "Apenas letras são permitidas!";
                label_msg_local_armazenamento.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label_msg_local_armazenamento.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
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
