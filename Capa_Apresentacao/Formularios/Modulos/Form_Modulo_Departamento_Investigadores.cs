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

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Departamento_Investigadores : Form
    {
        e_comum_departamentos_investigadores c_departamentos_Investigadores = new e_comum_departamentos_investigadores();
        dominio_departamentos_investigadores d_departamentos_Investigadores = new dominio_departamentos_investigadores();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_departamentos d_Departamentos = new dominio_departamentos();
        public Form_Modulo_Departamento_Investigadores()
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
            text_departamento.DataSource = d_Departamentos.selecionar_Departamentos_Combo_Box();
            text_departamento.DisplayMember = "nome";
            text_departamento.ValueMember = "id_departamento";
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(text_investigador.Text == "" || text_departamento.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\nPor favor, preencha-os e tente novamente!");
                return;
            }
            // Registrar
            if(Program.AJUDA == 0)
            {
                try
                {
                    // Capturar os dados digitados no formulário
                    int Id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
                    int Id_Departamento = Convert.ToInt32(text_departamento.SelectedValue);
                    int Id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
                    DateTime Data_Registro = text_Data_Registro.Value;
                    DateTime Data_Atualizacao = DateTime.Now;
                    // Salvar os dados capturados
                    c_departamentos_Investigadores.id_investigador = Id_Investigador;
                    c_departamentos_Investigadores.id_departamento = Id_Departamento;
                    c_departamentos_Investigadores.id_usuario = Id_Usuario;
                    c_departamentos_Investigadores.data_registro = Data_Registro;
                    c_departamentos_Investigadores.data_atualizacao = Data_Atualizacao;
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar estas informações?", "Mensagem de confirmação") == DialogResult.Yes)
                    {
                        Program.AJUDA = 0;
                        d_departamentos_Investigadores.inserir_Departamentos_Investigadores(c_departamentos_Investigadores);
                        guna2MessageDialog_Inform.Show("As informações foram registradas com sucesso!", "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Não foi possível salvar os dados!", Ex.Message);
                }
            }
            else
            {
                // Atualizar
                try
                {
                    // Capturar os dados digitados no formulário
                    int id_Departamento_Investigador = Convert.ToInt32(label_id.Text);
                    int Id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
                    int Id_Departamento = Convert.ToInt32(text_departamento.SelectedValue);
                    int Id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
                    DateTime Data_Registro = text_Data_Registro.Value;
                    DateTime Data_Atualizacao = DateTime.Now;
                    // Atualizar os dados capturados
                    c_departamentos_Investigadores.id_departamento_investigador = id_Departamento_Investigador;
                    c_departamentos_Investigadores.id_investigador = Id_Investigador;
                    c_departamentos_Investigadores.id_departamento = Id_Departamento;
                    c_departamentos_Investigadores.id_usuario = Id_Usuario;
                    c_departamentos_Investigadores.data_registro = Data_Registro;
                    c_departamentos_Investigadores.data_atualizacao = Data_Atualizacao;
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar estas informações?", "Mensagem de confirmação") == DialogResult.Yes)
                    {
                        Program.AJUDA = 0;
                        d_departamentos_Investigadores.atualizar_Departamentos_Investigadores(c_departamentos_Investigadores);
                        guna2MessageDialog_Inform.Show("As informações foram atualizadas com sucesso!", "Atualização bem sucedida");
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Não foi possível atualizar os dados!", Ex.Message);
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
            text_departamento.SelectedIndex = -1;
        }
    }
}
