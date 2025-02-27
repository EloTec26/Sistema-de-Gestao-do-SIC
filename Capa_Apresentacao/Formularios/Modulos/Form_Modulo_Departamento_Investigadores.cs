﻿using Capa_Apresentacao.Formularios.Lista_Formularios;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Departamento_Investigadores : Form
    {
        e_comum_departamentos_investigadores c_departamentos_Investigadores = new e_comum_departamentos_investigadores();
        dominio_departamentos_investigadores d_departamentos_Investigadores = new dominio_departamentos_investigadores();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_departamentos d_Departamentos = new dominio_departamentos();

        Form_Lista_Departamentos_Investigadores departamentos_Investigadores;
        public Form_Modulo_Departamento_Investigadores(Form_Lista_Departamentos_Investigadores departamentos_Investigadores)
        {
            InitializeComponent();
            carregar_Dados_ComboBoxs();
            this.departamentos_Investigadores = departamentos_Investigadores;
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
        private void CapturarCampos()
        {
            // Capturar os dados digitados no formulário
            int Id_Investigador = Convert.ToInt32(text_investigador.SelectedValue);
            int Id_Departamento = Convert.ToInt32(text_departamento.SelectedValue);
            int Id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;

            // Salvar os dados capturados
            c_departamentos_Investigadores.id_investigador = Id_Investigador;
            c_departamentos_Investigadores.id_departamento = Id_Departamento;
            c_departamentos_Investigadores.id_usuario = Id_Usuario;
        }
        private bool VerificarCampos()
        {
            if (text_investigador.Text == "" || text_departamento.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\nPor favor, preencha-os e tente novamente!");
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
                    DateTime Data_Registro = DateTime.Now;
                    DateTime Data_Atualizacao = DateTime.Now;
                    c_departamentos_Investigadores.data_registro = Data_Registro;
                    c_departamentos_Investigadores.data_atualizacao = Data_Atualizacao;

                    CapturarCampos();

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar estas informações?", "Mensagem de confirmação") == DialogResult.Yes)
                    {
                        d_departamentos_Investigadores.inserir_Departamentos_Investigadores(c_departamentos_Investigadores);
                        guna2MessageDialog_Inform.Show("As informações foram registradas com sucesso!", "Registro bem sucedido");
                        departamentos_Investigadores.selecionar_Departamentos_Investigadores();
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar os dados!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    DateTime Data_Atualizacao = DateTime.Now;
                    c_departamentos_Investigadores.data_atualizacao = Data_Atualizacao;

                    c_departamentos_Investigadores.id_departamento_investigador = Convert.ToInt32(label_id.Text);

                    CapturarCampos();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar estas informações?", "Mensagem de confirmação") == DialogResult.Yes)
                    {
                        d_departamentos_Investigadores.atualizar_Departamentos_Investigadores(c_departamentos_Investigadores);
                        guna2MessageDialog_Inform.Show("As informações foram atualizadas com sucesso!", "Atualização bem sucedida");
                        departamentos_Investigadores.selecionar_Departamentos_Investigadores();

                        limpar_Campos();
                        this.Close();
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
