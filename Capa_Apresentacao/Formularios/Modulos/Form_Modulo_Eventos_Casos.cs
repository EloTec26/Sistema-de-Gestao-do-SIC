using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Eventos_Casos : Form
    {
        dominio_casos d_Caso = new dominio_casos();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_vitimas d_Vitimas = new dominio_vitimas();
        dominio_testemunhas d_Testemunhas = new dominio_testemunhas();
        dominio_suspeitos d_Suspeitos = new dominio_suspeitos();
        dominio_eventos_casos d_Evento_Caso = new dominio_eventos_casos();
        e_comum_eventos_casos c_Evento_Caso = new e_comum_eventos_casos();
        public Form_Modulo_Eventos_Casos()
        {
            InitializeComponent();
            adicionar_Dados_Combo_Box();
        }
        private void adicionar_Dados_Combo_Box()
        {
            //---------------------------------------------------------
            text_caso.DataSource = d_Caso.selecionar_Casos_Combo_Box();
            text_caso.DisplayMember = "titulo";
            text_caso.ValueMember = "id_caso";
            //---------------------------------------------------------
            text_investigador.DataSource = d_Investigadores.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";
            //---------------------------------------------------------
            text_vitima.DataSource = d_Vitimas.selecionar_vitimas_combo_box();
            text_vitima.DisplayMember = "Nomes";
            text_vitima.ValueMember = "ID";
            //---------------------------------------------------------
            text_testemunha.DataSource = d_Testemunhas.selecionar_testemunhas_combo_box();
            text_testemunha.DisplayMember = "Nomes";
            text_testemunha.ValueMember = "ID";
            //---------------------------------------------------------
            text_suspeito.DataSource = d_Suspeitos.selecionar_suspeitos_combo_boxs();
            text_suspeito.DisplayMember = "Nomes";
            text_suspeito.ValueMember = "ID";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDados()
        {
            // Capturar os dados digitados no formulário
            int id_Caso = Convert.ToInt32(text_caso.SelectedValue);
            int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
            int id_Vitima = Convert.ToInt32(text_vitima.SelectedValue);
            int id_Testemunha = Convert.ToInt32(text_testemunha.SelectedValue);
            int id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            DateTime data_Evento = text_data_evento.Value;
            string tipo_Evento = text_tipo_evento.Text;
            string descricao = text_descricao.Text;
            int id_Suspeito = Convert.ToInt32(text_suspeito.SelectedValue);

            // Definir dados no objecto
            c_Evento_Caso.id_caso = id_Caso;
            c_Evento_Caso.id_investigador = id_Investigador;
            c_Evento_Caso.id_vitima = id_Vitima;
            c_Evento_Caso.id_testemunha = id_Testemunha;
            c_Evento_Caso.id_usuario = id_Usuario;
            c_Evento_Caso.data_evento = data_Evento;
            c_Evento_Caso.tipo_evento = tipo_Evento;
            c_Evento_Caso.descricao = descricao;
            c_Evento_Caso.id_suspeito = id_Suspeito;

        }
        private bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(text_caso.Text) || string.IsNullOrWhiteSpace(text_investigador.Text)
               || string.IsNullOrWhiteSpace(text_vitima.Text) || string.IsNullOrWhiteSpace(text_testemunha.Text)
               || string.IsNullOrWhiteSpace(text_tipo_evento.Text) || string.IsNullOrWhiteSpace(text_descricao.Text)
               || string.IsNullOrWhiteSpace(text_suspeito.Text))
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\nPor favor, preencha-os e tente novamente!", "Erro ao salvar os dados");
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
                    CapturarDados();
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Evento_Caso.data_registro = data_Registro;
                    c_Evento_Caso.data_atualizacao = data_Atualizacao;

                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de registrar este evento caso?", $"Mensagem de registro") == DialogResult.Yes)
                    {
                        //Registrar
                        d_Evento_Caso.inserir_Enventos_Casos(c_Evento_Caso);
                        guna2MessageDialog_Inform.Show($"O evento caso foi registrado com sucesso!", "Registro bem sucedido");
                        // Limpa todos os campos depois do registro.
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível registrar este evento-caso!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    CapturarDados();
                    c_Evento_Caso.id_evento_caso = Convert.ToInt32(label_id.Text);
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Evento_Caso.data_atualizacao = data_Atualizacao;
                    if (guna2MessageDialog_Confirm.Show($"Tens a certeza de atualizar este evento caso?", $"Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Evento_Caso.stualizar_Enventos_Casos(c_Evento_Caso);
                        guna2MessageDialog_Inform.Show($"O evento caso foi atualizado com sucesso!", "Atualização bem sucedida");
                        limpar_Campos();
                        // Fecha o formulário depois da atualização.
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este evento-caso!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            label_id.Text = "";
            text_caso.SelectedIndex = -1;
            text_investigador.SelectedIndex = -1;
            text_vitima.SelectedIndex = -1;
            text_testemunha.SelectedIndex = -1;
            text_tipo_evento.SelectedIndex = -1;
            text_descricao.Text = "";
            text_suspeito.SelectedIndex = -1;
            text_data_evento.Value = DateTime.Now;
        }

        private void text_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, teclas de controle (como Backspace).
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false; // Permite a entrada
                label23.Visible = false; // Oculta o Label se a entrada for válida
                //text_descricao.FocusedState.BorderColor = Color.FromArgb(23, 35, 49);
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Exibe a mensagem no Label
                //text_descricao.FocusedState.BorderColor = Color.Tomato;
                label23.Text = "Apenas letras são permitidas!";
               
                label23.Visible = true;

                // Cancela a entrada do número no TextBox
                e.Handled = true;
            }
            else
            {
                // Impede qualquer outra entrada que não seja permitida
                e.Handled = true;
                label23.Visible = false; // Opcional: pode manter o Label oculto para outros caracteres
            }
        }
    }
}
