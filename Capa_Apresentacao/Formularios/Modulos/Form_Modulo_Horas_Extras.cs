using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Comum.Entidades;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Dominio;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Apresentacao.Formularios.Lista_Formularios;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Horas_Extras : Form
    {
        dominio_investigadores d_Investigador = new dominio_investigadores();
        dominio_horas_extras d_Horas_Extras = new dominio_horas_extras();
        e_comum_horas_extras c_Horas_Extras = new e_comum_horas_extras();
        Form_Lista_Horas_Extras horas_Extras;
        public Form_Modulo_Horas_Extras(Form_Lista_Horas_Extras horas_Extras)
        {
            InitializeComponent();
            this.horas_Extras = horas_Extras;
            carregar_Investigadores_Combo_Box();
        }
        private void carregar_Investigadores_Combo_Box()
        {
            text_investigador.DataSource = d_Investigador.selecionar_investigadores_combobox();
            text_investigador.DisplayMember = "Nomes";
            text_investigador.ValueMember = "ID";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerficarCamposVazios()
        {
            if (text_investigador.Text == "" || text_horas_trabalho.Text == "" || text_tipo_horas.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com asteríscos(*) são de preenchimento obrigatório!", "Erro ao salvar a falta");
                return false;
            }
            return true;
        }
        private void CapturarDadosFormulario()
        {
            // Capturar os dados do formulário
            int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
            DateTime data_Trablho = text_data_trabalho.Value;
            string horas_Trabalhadas = text_horas_trabalho.Text;
            string tipo_Horas = text_tipo_horas.Text;
            
            c_Horas_Extras.id_investigador = id_Investigador;
            c_Horas_Extras.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            c_Horas_Extras.data_trabalho = data_Trablho;
            c_Horas_Extras.horas_trabalhadas = horas_Trabalhadas;
            c_Horas_Extras.tipo_horas = tipo_Horas;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Registrar
            if (VerficarCamposVazios())
            {
                try
                {
                    CapturarDadosFormulario();
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Horas_Extras.data_registro = data_Registro;
                    c_Horas_Extras.data_atualizacao = data_Atualizacao;
                    // Registrar os dados capturados
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar estas horas_extras?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Horas_Extras.inserir_horas_extras(c_Horas_Extras);
                        guna2MessageDialog_Inform.Show("As horas-extras foram registrada com sucesso!", "Registro bem-sucedido");
                        horas_Extras.selecionar_Horas_Extras();
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível registrar estas horas extras!", Ex.Message);
                }
            }
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (VerficarCamposVazios())
            {
                // Atualizar
                try
                {
                    // Capturar os dados do formulário
                    int id_Horas_Extras = Convert.ToInt32(label_id.Text);
                    DateTime data_Atualizacao = DateTime.Now;
                  
                    CapturarDadosFormulario();
                    c_Horas_Extras.id_hora_extra = id_Horas_Extras;
                    c_Horas_Extras.data_atualizacao = data_Atualizacao;
                    // Registrar os dados capturados
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar estas horas_extras?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Horas_Extras.atualizar_horas_extras(c_Horas_Extras);

                        guna2MessageDialog_Inform.Show("A falta foi atualizada com sucesso!", "Atualização bem-sucedida");
                        limpar_Campos();
                        horas_Extras.selecionar_Horas_Extras();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar esta falta!", Ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_investigador.SelectedIndex = -1;
            text_horas_trabalho.Text = "";
            text_tipo_horas.SelectedIndex = -1;
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void text_horas_trabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_horas_trabalho, label_msg_horas_trabalhadas, "Apenas números são permitidos!");
        }
    }
}
