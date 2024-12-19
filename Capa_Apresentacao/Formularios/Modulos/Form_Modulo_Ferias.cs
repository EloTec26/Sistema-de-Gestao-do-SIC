﻿using System;
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


namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Ferias : Form
    {
        #region Instanciar classes e métodos
        e_comum_ferias c_Ferias = new e_comum_ferias();
        dominio_ferias d_Ferias = new dominio_ferias();
        dominio_investigadores d_Investigador = new dominio_investigadores();
        #endregion
        public Form_Modulo_Ferias()
        {
            InitializeComponent();
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(text_investigador.Text == "" || text_estado_feria.Text == "" || text_descricao.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com asteríscos(*) são de preenchimento obrigatório!", "Erro ao salvar a falta");
                return;
            }
            if (text_data_inicial.Value.Date < DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A [data inicial] selecionada não pode ser uma data passada.", "Erro de seleção de data");
                return;
            }
            if (text_data_final.Value.Date < DateTime.Now.Date || text_data_final.Value.Date == DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A [data de final] selecionada não pode estar à baixo ou igual à data atual.", "Erro de seleção de data");
                return;
            }
            if (text_Data_Registro.Value.Date > DateTime.Now.Date)
            {
                MessageDialog_Error.Show("A [data de registro] selecionada não pode ser uma data futura.", "Erro de seleção de data");
                return;
            }
            if(Program.AJUDA == 0)
            {

                try
                {
                    // Capturar os dados do formulário
                    int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
                    DateTime data_Inicial = text_data_inicial.Value;
                    DateTime data_Final = text_data_final.Value;
                    string estado_Feria = text_estado_feria.Text;
                    string descricao_Falta = text_descricao.Text;
                    DateTime data_Registro = text_Data_Registro.Value;
                    DateTime data_Atualizacao = DateTime.Now;
                    // Registrar os dados capturados
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta féria?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        c_Ferias.id_investigador = id_Investigador;
                        c_Ferias.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
                        c_Ferias.data_inicio = data_Inicial;
                        c_Ferias.data_fim = data_Final;
                        c_Ferias.estado_feria = estado_Feria;
                        c_Ferias.descricao = descricao_Falta;
                        c_Ferias.data_registro = data_Registro;
                        c_Ferias.data_atualizacao = data_Atualizacao;

                        Program.AJUDA = 0;
                        d_Ferias.inserir_Ferias(c_Ferias);

                        guna2MessageDialog_Inform.Show("A féria foi registrada com sucesso!", "Registro bem-sucedido");
                        limpar_Campos();

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Não foi possível registrar esta féria!", Ex.Message);
                }
            }
            // Atualizar
            else
            {
                try
                {
                    // Capturar os dados do formulário
                    int id_Falta = Convert.ToInt32(label_id.Text);
                    int id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
                    DateTime data_Inicial = text_data_inicial.Value;
                    DateTime data_Final = text_data_final.Value;
                    string estado_Feria = text_estado_feria.Text;
                    string descricao_Falta = text_descricao.Text;
                    DateTime data_Registro = text_Data_Registro.Value;
                    DateTime data_Atualizacao = DateTime.Now;
                    // Registrar os dados capturados
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta falta?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        c_Ferias.id_feria = id_Falta;
                        c_Ferias.id_investigador = id_Investigador;
                        c_Ferias.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
                        c_Ferias.data_inicio = data_Inicial;
                        c_Ferias.data_fim = data_Final;
                        c_Ferias.estado_feria = estado_Feria;
                        c_Ferias.descricao = descricao_Falta;
                        c_Ferias.data_registro = data_Registro;
                        c_Ferias.data_atualizacao = data_Atualizacao;
                        Program.AJUDA = 0;

                        d_Ferias.atualizar_Ferias(c_Ferias);


                        guna2MessageDialog_Inform.Show("A féria foi atualizada com sucesso!", "Atualização bem-sucedida");
                        limpar_Campos();
                        this.Close();

                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar esta féria!", Ex.Message);
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
            text_data_inicial.Value = DateTime.Now;
            text_data_final.Value = DateTime.Now;
            text_estado_feria.SelectedIndex = -1;
            text_descricao.Text = "";
            text_Data_Registro.Value = DateTime.Now;
        }
    }
}
