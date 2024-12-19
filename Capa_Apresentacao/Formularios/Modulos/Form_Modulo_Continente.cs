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


namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Continente : Form
    {
        #region Instanciar as classes e os métodos
        e_comum_continentes c_continentes = new e_comum_continentes();
        dominio_continentes d_continentes = new dominio_continentes();
        #endregion
        public Form_Modulo_Continente()
        {
            InitializeComponent();
        }
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            if (text_continentes.Text == "")
            {
                MessageDialog_Error.Show($"Os campos com (*) são de preenchimento obrigatório!\n" +
                  $"Por favor, preencha-os e tente novamente.", "Erro de cadastro");
                return;
            }
            try
            {
                // Capturar os dados digitados no formulário
                string nome = text_continentes.Text;
                DateTime data_registro = text_data_registro.Value;
                DateTime data_atualizacao = DateTime.Now;
                // Registrar os dados capturados
                c_continentes.nome = nome;
                c_continentes.data_registro = data_registro;
                c_continentes.data_atualizacao = data_atualizacao;

                // Verificar se é um novo registro ou atualização
                bool Atualizacao = Program.AJUDA != 0;
                if (Atualizacao)
                {
                    c_continentes.id_continente = Convert.ToInt32(label_id.Text);
                }
                // Mensagem de confirmação
                string accao = Atualizacao ? "atualizar" : "registrar";
                if (guna2MessageDialog_Confirm.Show($"Tens a certeza de {accao} este continente?", $"Mensagem de {accao}") == DialogResult.Yes)
                {
                    Program.AJUDA = 0;
                    // atualizar os dados
                    if (Atualizacao)
                    {
                        d_continentes.atualizar_continentes(c_continentes);

                        guna2MessageDialog_Inform.Show($"O continente foi atualizado com sucesso!", "Atualização bem sucedida");
                        // Fecha o formulário depois da atualização.
                        this.Close();
                    }
                    else
                    {
                        //Registrar
                        d_continentes.registrar_continentes(c_continentes);
                        guna2MessageDialog_Inform.Show($"O continente foi registrado com sucesso!", "Registro bem sucedido");
                        // Limpa todos os campos depois do registro.
                        Limpar_campos();
                    }
                }
            }
            catch (Exception ex)
            {
                // capturar a mensagem de exceção personalizada da camada de domínio
                if (ex.Message.Contains("O nome do continente já está registrado"))
                {
                    MessageDialog_Error.Show(ex.Message, "Erro de duplicidade");
                }
                else
                {
                    MessageDialog_Error.Show("Não possível registrar este continente!", ex.Message);
                }
            }
        }

        public void Limpar_campos()
        {
            text_continentes.SelectedIndex = -1;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar_campos();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            Limpar_campos();
        }

        private void Form_Modulo_Continente_Load(object sender, EventArgs e)
        {
        }
    }
}
