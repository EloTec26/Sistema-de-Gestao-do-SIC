using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas ;
using Capa_Comum.Entidades;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Evidencias : Form
    {
        e_comum_evidencias c_Evidencias = new e_comum_evidencias();
        dominio_evidencias d_Evidencias = new dominio_evidencias();
        dominio_pesquisar_evidencias p_Evidencias = new dominio_pesquisar_evidencias();

        public Form_Lista_Evidencias()
        {
            InitializeComponent();
            selecionar_Evidencias();
        }
        private void selecionar_Evidencias()
        {
            dgv_evidencias.DataSource = d_Evidencias.selecionar_evidencias();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Formularios.Modulos.Form_Modulo_Evidencias form_Modulo = new Modulos.Form_Modulo_Evidencias();
            form_Modulo.FormClosed += Form_Modulo_FormClosed;
            form_Modulo.ShowDialog();
        }

        private void Form_Modulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Evidencias();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_evidencias.SelectedRows.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Evidencias form_Modulo = new Modulos.Form_Modulo_Evidencias();
                form_Modulo.FormClosed += Form_Modulo_FormClosed;

                form_Modulo.label_id.Text = dgv_evidencias.CurrentRow.Cells[0].Value.ToString();
                form_Modulo.text_caso.Text = dgv_evidencias.CurrentRow.Cells[1].Value.ToString();
                form_Modulo.text_tipo.Text = dgv_evidencias.CurrentRow.Cells[2].Value.ToString();
                form_Modulo.text_data_coleta.Text = dgv_evidencias.CurrentRow.Cells[3].Value.ToString();
                form_Modulo.text_local_armazenamento.Text = dgv_evidencias.CurrentRow.Cells[4].Value.ToString();
                form_Modulo.text_descricao.Text = dgv_evidencias.CurrentRow.Cells[5].Value.ToString();
                form_Modulo.text_investigador.Text = dgv_evidencias.CurrentRow.Cells[6].Value.ToString();
                form_Modulo.text_data_registro.Text = dgv_evidencias.CurrentRow.Cells[8].Value.ToString();


                form_Modulo.btn_Atualizar.Visible = true;
                form_Modulo.btn_salvar.Visible = false;
                form_Modulo.label5.Text = "Atualizar evidência";
                form_Modulo.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a evidência que pretendes atualizar e tente novamente.", "Falha de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_evidencias.SelectedRows.Count > 0)
            {
                try
                {
                    int id_Evidencia = Convert.ToInt32(dgv_evidencias.CurrentRow.Cells[0].Value.ToString());
                    c_Evidencias.id_evidencia = id_Evidencia;
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de excluir esta evidência?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        d_Evidencias.eliminar_evidencias(c_Evidencias);
                        guna2MessageDialog_Inform.Show($"A evidência com a identificação {id_Evidencia}, foi excluída com sucesso!", "Exclusão bem sucedida");
                        selecionar_Evidencias();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível excluir esta evidência", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a evidência que pretendes atualizar e tente novamente.", "Falha de atualização");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }
        private void pesquisar()
        {
            dgv_evidencias.DataSource = p_Evidencias.pesquisar_Envidencia(text_pesquisar.Text);
        }
    }
}
