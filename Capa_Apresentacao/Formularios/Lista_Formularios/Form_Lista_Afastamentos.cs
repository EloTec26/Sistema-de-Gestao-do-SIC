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
using Capa_Dominio.Dominio_Pesquisas;
using Capa_Dominio;
using Capa_Apresentacao.Formularios.Modulos;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Afastamentos : Form
    {
        #region Instanciação de classes e métodos
        dominio_pesquisar_afastamentos pesquisar_Afastamentos = new dominio_pesquisar_afastamentos();
        dominio_afastamentos d_Afastamentos = new dominio_afastamentos();
        e_comum_afastamentos c_Afastamentos = new e_comum_afastamentos();
        #endregion
        public Form_Lista_Afastamentos()
        {
            InitializeComponent();
            selecionar_afastamentos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_afastamentos()
        {
            dgv_Afastamentos.DataSource = d_Afastamentos.selecionar_Afastamentos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Afastamentos afastamentos = new Form_Modulo_Afastamentos();
            afastamentos.FormClosed += Afastamentos_FormClosed;
            afastamentos.ShowDialog();
        }

        private void Afastamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_afastamentos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_Afastamentos.SelectedRows.Count > 0)
            {
                Form_Modulo_Afastamentos afastamentos = new Form_Modulo_Afastamentos();
                afastamentos.FormClosed += Afastamentos_FormClosed;

                afastamentos.label_id.Text = dgv_Afastamentos.CurrentRow.Cells[0].Value.ToString();
                afastamentos.text_investigador.Text = dgv_Afastamentos.CurrentRow.Cells[1].Value.ToString();
                afastamentos.text_data_inicio_afastamentos.Text = dgv_Afastamentos.CurrentRow.Cells[2].Value.ToString();
                afastamentos.text_data_final_afastamentos.Text = dgv_Afastamentos.CurrentRow.Cells[3].Value.ToString();
                afastamentos.text_descricao.Text = dgv_Afastamentos.CurrentRow.Cells[4].Value.ToString();
                afastamentos.text_Estado.Text = dgv_Afastamentos.CurrentRow.Cells[5].Value.ToString();
                afastamentos.label5.Text = "Atualizar afastamento";
                afastamentos.btn_salvar.Visible  = false;
                afastamentos.btn_Atualizar.Visible = true;
                afastamentos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione o afastamento que pretende atualizar e tente novamente!", "Erro de atualização",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Afastamentos.SelectedRows.Count > 0)
            {
                if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este afastamento?", "Mensagem de confirmação") == DialogResult.Yes)
                {
                    int id_Afastamento = Convert.ToInt32(dgv_Afastamentos.CurrentRow.Cells[0].Value.ToString());
                    c_Afastamentos.id_afastamento = id_Afastamento;
                    d_Afastamentos.eliminar_Afastamentos(c_Afastamentos);
                    guna2MessageDialog_Inform.Show($"O afastamento com a identificação {id_Afastamento} foi eliminado com sucesso!", "Exclusão bem sucedida");
                    selecionar_afastamentos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o afastamento que pretende eliminar e tente novamente!", "Erro de exclusão",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            p_Afastamentos();
        }
        private void p_Afastamentos()
        {
            dgv_Afastamentos.DataSource = pesquisar_Afastamentos.pesquisar_Afastamento(text_pesquisar.Text);
        }
    }
}
