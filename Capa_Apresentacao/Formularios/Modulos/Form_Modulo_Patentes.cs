using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using System.Data.SqlClient;
using Capa_Apresentacao.Formularios.Lista_Formularios;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Patentes : Form
    {
        e_comum_patentes c_Patentes = new e_comum_patentes();
        dominio_patentes d_Patentes = new dominio_patentes();
        Form_Lista_Patentes Patentes;
        public Form_Modulo_Patentes(Form_Lista_Patentes Patentes)
        {
            InitializeComponent();
            this.Patentes = Patentes;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarCampos()
        {
            // Capturar os dados digitados no formulário
            string patentes = text_patentes.Text;
            string descricao = text_descricao.Text;
           
            // Definir dados no objecto
            c_Patentes.nome = patentes;
            c_Patentes.descricao = descricao;
            c_Patentes.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
        }
        private bool VerificarCampos()
        {
            if (text_patentes.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
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
                    //Registrar
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_atualizacao = DateTime.Now;
                    c_Patentes.data_registro = data_Registro;
                    c_Patentes.data_atualizacao = data_atualizacao;
                    c_Patentes.id_patente = Convert.ToInt32(label_id.Text);
                    CapturarCampos();
                    d_Patentes.inserir_patentes(c_Patentes);
                    guna2MessageDialog_Inform.Show($"A patente foi registrada com sucesso!", "Registro bem sucedido");
                    // Limpa todos os campos depois do registro.
                    Patentes.listar_Patentes();
                    limpar_Campos();
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    string erro_Duplicacao = ex.Message;
                    if (erro_Duplicacao.Contains("nome"))
                    {
                        MessageDialog_Error.Show("A 'Patente' inserida já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação");
                        text_patentes.Focus();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar esta patente!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    //Atualizar
                    DateTime data_atualizacao = DateTime.Now;
                    c_Patentes.data_atualizacao = data_atualizacao;
                    c_Patentes.id_patente = Convert.ToInt32(label_id.Text);
                    CapturarCampos();
                    d_Patentes.atualizar_patentes(c_Patentes);
                    guna2MessageDialog_Inform.Show($"A patente foi atualizada com sucesso!", "Atualização bem sucedida");
                    // Limpa todos os campos depois do registro.
                    Patentes.listar_Patentes();
                    limpar_Campos();
                    this.Close();
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    string erro_Duplicacao = ex.Message;
                    if (erro_Duplicacao.Contains("nome"))
                    {
                        MessageDialog_Error.Show("A 'Patente' inserida já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação");
                        text_patentes.Focus();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar esta patente!", Ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_patentes.Clear();
            text_descricao.Clear();
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void text_patentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTextoNumeroSimbolo(e, text_patentes, label_msg_patente, "Apenas letras e os símbolos (º e -), são permitidos!");
        }

        private void text_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidarTextoDescricao(e, text_descricao, label_msg_descricao, "Apenas letras e alguns caracteres são permitidos!");
        }
    }
}
