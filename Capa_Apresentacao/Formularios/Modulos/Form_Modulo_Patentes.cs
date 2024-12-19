using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Patentes : Form
    {
        e_comum_patentes c_Patentes = new e_comum_patentes();
        dominio_patentes d_Patentes = new dominio_patentes();
        public Form_Modulo_Patentes()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_patentes.Text == String.Empty)
            {
                MessageDialog_Error.Show("Todos os campos com (*) são de preenchimento obrigatório.\n" +
                    "Por favor, preencha-o e tente novamente!", "Erro ao salvar os dados");
                return;
            }
            try
            {
                // Capturar os dados digitados no formulário
                string patentes = text_patentes.Text;
                string descricao = text_descricao.Text;
                DateTime data_Registro = text_data_registro.Value;
                DateTime data_atualizacao = DateTime.Now;
                // Definir dados no objecto
                c_Patentes.nome = patentes;
                c_Patentes.descricao = descricao;
                c_Patentes.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
                c_Patentes.data_registro = data_Registro;
                c_Patentes.data_atualizacao = data_atualizacao;

                // Verificar se é um novo registro ou atualização
                bool Atualizacao = Program.AJUDA != 0;
                if (Atualizacao)
                {
                    c_Patentes.id_patente = Convert.ToInt32(label_id.Text);
                }
                // Mensagem de confirmação
                string accao = Atualizacao ? "atualizar" : "registrar";
                if (guna2MessageDialog_Confirm.Show($"Tens a certeza de {accao} este evento caso?", $"Mensagem de {accao}") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    // atualizar os dados
                    if (Atualizacao)
                    {
                        d_Patentes.atualizar_patentes(c_Patentes);
                        guna2MessageDialog_Inform.Show($"A patente foi atualizada com sucesso!", "Atualização bem sucedida");
                        // Fecha o formulário depois da atualização.
                        this.Close();
                    }
                    else
                    {
                        //Registrar
                        d_Patentes.inserir_patentes(c_Patentes);
                        guna2MessageDialog_Inform.Show($"A patente foi registrada com sucesso!", "Registro bem sucedido");
                        // Limpa todos os campos depois do registro.
                        limpar_Campos();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não foi possível registrar/ Atualizar esta patente!", Ex.Message);
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
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_descricao, label_msg_descricao, "Apenas letras são permitidas!");
        }
    }
}
