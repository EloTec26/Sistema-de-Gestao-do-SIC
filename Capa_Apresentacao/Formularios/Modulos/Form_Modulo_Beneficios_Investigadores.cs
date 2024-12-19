using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Beneficios_Investigadores : Form
    {
        e_comum_beneficios_investigadores c_Beneficios_Investigadores = new e_comum_beneficios_investigadores();
        dominio_beneficos_Investigadores d_Beneficios_Investigadores = new dominio_beneficos_Investigadores();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_beneficos d_Beneficios = new dominio_beneficos();
        public Form_Modulo_Beneficios_Investigadores()
        {
            InitializeComponent();
            listar_Investigadores_Beneficios_Combo_Box();
        }
        private void listar_Investigadores_Beneficios_Combo_Box()
        {
            // carregar investigadores
            text_investigador.DataSource = d_Investigadores.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";

            // carregar beneficios
            text_beneficio.DataSource = d_Beneficios.selecionar_Beneficos_Combo_Box();
            text_beneficio.DisplayMember = "nome";
            text_beneficio.ValueMember = "id_beneficio";
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void capturar_Dados_Digitados_Formulario()
        {
            // capturar os dados do formulário
            int id_investigadores = Convert.ToInt32(text_investigador.SelectedValue);
            int id_beneficios = Convert.ToInt32(text_beneficio.SelectedValue);
            DateTime data_inicio_beneficio = text_data_inicio_beneficio.Value;
            DateTime data_fim_beneficio = text_data_fim_beneficio.Value;
           

            // salvar os dados capturados
            c_Beneficios_Investigadores.id_investigador = id_investigadores;
            c_Beneficios_Investigadores.id_beneficio = id_beneficios;
            c_Beneficios_Investigadores.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            c_Beneficios_Investigadores.data_inicio = data_inicio_beneficio;
            c_Beneficios_Investigadores.data_fim = data_fim_beneficio;

        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //Verificar a existência de campos vazios
            if (text_investigador.Text == "" || text_beneficio.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório!, Por favor, preencha-os e tente novamente!", "Erro de registro");
                return;
            }
            // registrar
            try
            {
                DateTime data_registro = DateTime.Now;
                DateTime data_atualizacao = DateTime.Now;
                c_Beneficios_Investigadores.data_registro = data_registro;
                c_Beneficios_Investigadores.data_atualizacao = data_atualizacao;
                capturar_Dados_Digitados_Formulario();
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este benefício - funcionário?", "Mensagem de registro") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    d_Beneficios_Investigadores.inserir_Beneficios_Investigadores(c_Beneficios_Investigadores);
                    guna2MessageDialog_Inform.Show($"O benefício - funcionário {text_beneficio.Text + text_investigador.Text} foi registrado com sucesso!", "Registro bem sucedido");
                    limpar_Campos();
                }
            }
            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não foi possível registrar este benefício - funcionário", Ex.Message);
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            //Verificar a existência de campos vazios
            if (text_investigador.Text == "" || text_beneficio.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório!, Por favor, preencha-os e tente novamente!", "Erro de registro");
                return;
            }
            // Atualizar
            try
            {

                // capturar o id
                int id_beneficios_investigadores = Convert.ToInt32(label_id.Text);
                
                DateTime data_atualizacao = DateTime.Now;
                c_Beneficios_Investigadores.data_atualizacao = data_atualizacao;

                capturar_Dados_Digitados_Formulario();
                // -----------------------------------------------------------------------------
                c_Beneficios_Investigadores.id_beneficio_investigador = id_beneficios_investigadores;

                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este benefício - funcionário?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    d_Beneficios_Investigadores.atualizar_Beneficios_Investigadores(c_Beneficios_Investigadores);
                    guna2MessageDialog_Inform.Show($"O benefício - funcionário {text_beneficio.Text + text_investigador.Text} foi atualizado com sucesso!", "Atualização bem sucedida");
                    this.Close();
                    limpar_Campos();
                }
            }
            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não foi possível atualizar este benefício - funcionário", Ex.Message);
            }
        }
        private void limpar_Campos()
        {
            text_beneficio.Text = "";
            text_investigador.Text = "";
            text_data_fim_beneficio.Value = DateTime.Now;
            text_data_fim_beneficio.Value = DateTime.Now;
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
    }
}
