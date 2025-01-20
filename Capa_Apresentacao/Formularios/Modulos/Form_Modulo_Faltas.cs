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
using Capa_Dominio;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Apresentacao.Formularios.Lista_Formularios;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Faltas : Form
    {
        e_comum_faltas c_Faltas = new e_comum_faltas();
        dominio_faltas d_Faltas = new dominio_faltas();
        dominio_investigadores d_Investigador = new dominio_investigadores();
        Form_Lista_Faltas faltas;
        public Form_Modulo_Faltas(Form_Lista_Faltas faltas)
        {
            InitializeComponent();
            this.faltas = faltas;
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
        private bool VerificarCampos()
        {
            if (text_investigador.Text == "" || text_estado_falta.Text == "" || text_motivos.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com asteríscos(*) são de preenchimento obrigatório!", "Erro ao salvar a falta");
                return false;
            }
            // Verifica se a data selecionada é maior que a data atual
            if (text_data_falta.Value.Date > DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A [data da falta] selecionada não pode ser uma data futura.", "Erro de seleção de data");
                return false;
            }
            return true;
        }
        private void CapturarDados()
        {
            // Capturar os dados do formulário
            int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
            DateTime data_Falta = text_data_falta.Value;
            string estado_Falta = text_estado_falta.Text;
            string motivos_Falta = text_motivos.Text;

            c_Faltas.id_investigador = id_Investigador;
            c_Faltas.data_falta = data_Falta;
            c_Faltas.estado_falta = estado_Falta;
            c_Faltas.descricao = motivos_Falta;
            c_Faltas.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Registrar
            if (VerificarCampos())
            {
                try
                {
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Faltas.data_registro = data_Registro;
                    c_Faltas.data_atualizacao = data_Atualizacao;

                    CapturarDados();

                    // Registrar os dados capturados
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta falta?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Faltas.inserir_Faltas(c_Faltas);

                        guna2MessageDialog_Inform.Show("A falta foi registrada com sucesso!", "Registro bem-sucedido");
                        faltas.selecionar_Faltas();
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível registrar esta falta!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            // Atualizar
            if (VerificarCampos())
            {
                try
                {
                    // Capturar os dados do formulário
                    CapturarDados();
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Faltas.data_atualizacao = data_Atualizacao;
                    c_Faltas.id_falta = Convert.ToInt32(label_id.Text);
                    // Registrar os dados capturados
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta falta?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Faltas.atualizar_Faltas(c_Faltas);

                        guna2MessageDialog_Inform.Show("A falta foi atualizada com sucesso!", "Atualização bem-sucedida");
                        limpar_Campos();
                        faltas.selecionar_Faltas();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar esta falta!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            label_id.Text = String.Empty;
            text_investigador.SelectedIndex = -1;
            text_data_falta.Value = DateTime.Now;
            text_motivos.Text = String.Empty;
        }
    }
}
