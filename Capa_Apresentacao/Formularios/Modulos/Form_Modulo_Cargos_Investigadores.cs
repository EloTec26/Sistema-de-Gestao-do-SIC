using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;


namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Cargos_Investigadores : Form
    {
        e_comum_cargos_investigadores c_Cargos_Investigadores = new e_comum_cargos_investigadores();
        dominio_cargos_investigadores d_Cargos_Investidores = new dominio_cargos_investigadores();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_cargos d_Cargos = new dominio_cargos();
        public Form_Modulo_Cargos_Investigadores()
        {
            InitializeComponent();
            carregat_Cargos_Investigadores_Combo_Box();
        }
        private void carregat_Cargos_Investigadores_Combo_Box()
        {
            text_investigador.DataSource = d_Investigadores.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";
            //----------------------------------------------------------
            text_cargo.DataSource = d_Cargos.selecionar_Cargos_Combo_Box();
            text_cargo.DisplayMember = "nome";
            text_cargo.ValueMember = "id_cargo";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDadosFormulario()
        {
            // Capturar os dados no formulário
            int id_Cargo = Convert.ToInt32(text_cargo.SelectedValue);
            int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);

            c_Cargos_Investigadores.id_cargo = id_Cargo;
            c_Cargos_Investigadores.id_investigador = id_Investigador;
            c_Cargos_Investigadores.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;

        }
        private bool VerificarCamposVazios()
        {
            if (text_investigador.Text == String.Empty || text_cargo.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório!\n" +
                    "Por favor, preencha-os e tente novamente!", "Erro de registro");
                return false;
            }
            return true;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Cargos_Investigadores.data_registro = data_Registro;
                    c_Cargos_Investigadores.data_atualizacao = data_Atualizacao;

                    CapturarDadosFormulario();

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta informação?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Cargos_Investidores.inserir_Cargos_Investigadores(c_Cargos_Investigadores);
                        guna2MessageDialog_Inform.Show("A informação foi registrada com sucesso!", "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao registrar o cargo -> investigodor", Ex.Message);
                }
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    int id_Cargo_Investigador = Convert.ToInt32(label_id.Text);
                    DateTime data_Atualizacao = DateTime.Now;

                    CapturarDadosFormulario();

                    c_Cargos_Investigadores.id_cargo_investigador = id_Cargo_Investigador;
                    c_Cargos_Investigadores.data_atualizacao = data_Atualizacao;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar esta informação?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Cargos_Investidores.atualizar_Cargos_Investigadores(c_Cargos_Investigadores);
                        guna2MessageDialog_Inform.Show("A informação foi atualizada com sucesso!", "Atualização bem sucedida");
                        limpar_Campos();
                        this.Dispose();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao atualizar o cargo -> investigodor", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_investigador.SelectedIndex = -1;
            text_cargo.SelectedIndex = -1;
        }
    }
}
