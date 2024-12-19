using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Treinamentos : Form
    {
        e_comum_treinamentos E_Treinamentos = new e_comum_treinamentos();
        dominio_treinamentos D_Treinamentos = new dominio_treinamentos();
        dominio_investigadores D_Investigadores = new dominio_investigadores();
        dominio_departamentos D_Departamentos = new dominio_departamentos();
        public Form_Modulo_Treinamentos()
        {
            InitializeComponent();
            carregar_dados_comboboxs();
        }
        private void carregar_dados_comboboxs()
        {
            text_funcionario.DataSource = D_Investigadores.selecionar_investigadores_combobox();
            text_funcionario.DisplayMember = "Nomes";
            text_funcionario.ValueMember = "ID";

            //-------------------------------------------
            text_departamento.DataSource = D_Departamentos.selecionar_Departamentos_Combo_Box();
            text_departamento.DisplayMember = "nome";
            text_departamento.ValueMember = "id_departamento";
        }
        private bool verificar_Campos_Vazios()
        {
            if (text_funcionario.Text == String.Empty ||
               text_departamento.Text == String.Empty ||
               text_titulo.Text == String.Empty ||
               text_descricao.Text == String.Empty)
            {
                MessageDialog_Error.Show("Os campos com (*) são de preechimento obrigatório!\n" +
                   "Por favor, preencha-os e tente novamente!", "Ocorreu um erro ao salvar os dados");
                return false;
            }
            if (text_data_inicial_treinamento.Value < DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A data do 'inicío do treinamento' não pode ser uma data passada nem futura.", "Erro de seleção da data inicial");
                return false;
            }
            //if (text_data_final_treinamento.Value == DateTime.Now.Date)
            //{
            //    MessageDialog_Error.Show("A data 'final do treinamento' não pode ser uma data presente.", "Erro de seleção da data inicial");
            //    return false;
            //}
            else return true;
        }
        public void capturar_dados_formulario()
        {
            int id_funcionario = Convert.ToInt32(text_funcionario.SelectedValue);
            int id_departamento = Convert.ToInt32(text_departamento.SelectedValue);
            string titulo = text_titulo.Text;
            string descricao = text_descricao.Text;
            DateTime data_inicial = text_data_inicial_treinamento.Value;
            DateTime data_final = text_data_final_treinamento.Value;

            E_Treinamentos.id_departamento = id_departamento;
            E_Treinamentos.id_investigador = id_funcionario;
            E_Treinamentos.id_usuario = 2;//comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            E_Treinamentos.titulo = titulo;
            E_Treinamentos.descricao = descricao;
            E_Treinamentos.data_inicio = data_inicial;
            E_Treinamentos.data_fim = data_final;

        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (verificar_Campos_Vazios())
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta vítima?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        capturar_dados_formulario();
                        E_Treinamentos.data_registro = DateTime.Now;
                        E_Treinamentos.data_atualizacao = DateTime.Now;

                        D_Treinamentos.cadastrar_treinamentos(E_Treinamentos);
                        guna2MessageDialog_Inform.Show($"O treinamento {text_titulo.Text} foi registrado com sucesso",
                           "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar este treinamento!", Ex.Message);
                }
            }
        }


        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (verificar_Campos_Vazios())
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta vítima?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        capturar_dados_formulario();

                        E_Treinamentos.id_treinamento = Convert.ToInt32(label_id.Text);
                        E_Treinamentos.data_atualizacao = DateTime.Now;

                        D_Treinamentos.atualizar_treinamentos(E_Treinamentos);
                        guna2MessageDialog_Inform.Show($"O treinamento {text_titulo.Text} foi atualizado com sucesso",
                           "Atualização bem sucedida");
                        limpar_Campos();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este treinamento!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_funcionario.Text = String.Empty;
            text_departamento.Text = String.Empty;
            text_titulo.Text = String.Empty;
            text_descricao.Text = String.Empty;
            text_data_inicial_treinamento.Value = DateTime.Now;
            text_data_final_treinamento.Value = DateTime.Now;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_titulo, label_msg_titulo, "Apenas letras são permitidas!");
        }

        private void text_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_descricao, label_msg_descricao, "Apenas letras são permitidas!");
        }
    }
}
