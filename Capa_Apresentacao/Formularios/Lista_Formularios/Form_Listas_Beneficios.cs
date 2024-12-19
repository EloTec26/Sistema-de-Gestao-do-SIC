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

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Listas_Beneficios : Form
    {
        e_comum_beneficios c_Beneficios = new e_comum_beneficios();
        dominio_pesquisar_beneficios p_Beneficios = new dominio_pesquisar_beneficios();
        dominio_beneficos d_Beneficios = new dominio_beneficos();
        public Form_Listas_Beneficios()
        {
            InitializeComponent();
            listar_Beneficios();

            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void listar_Beneficios()
        {
            dgv_beneficios.DataSource = d_Beneficios.selecionar_Beneficos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Beneficios beneficios = new Modulos.Form_Modulo_Beneficios();
            beneficios.FormClosed += Beneficios_FormClosed;
            beneficios.ShowDialog();
        }

        private void Beneficios_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Beneficios();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_beneficios.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Beneficios beneficios = new Modulos.Form_Modulo_Beneficios();
                beneficios.FormClosed += Beneficios_FormClosed;

                Program.AJUDA = 1;

                beneficios.label_id.Text = dgv_beneficios.CurrentRow.Cells[0].Value.ToString();
                beneficios.text_beneficio.Text = dgv_beneficios.CurrentRow.Cells[1].Value.ToString();
                beneficios.text_descricao.Text = dgv_beneficios.CurrentRow.Cells[2].Value.ToString();

                beneficios.btn_salvar.Visible = false;
                beneficios.btn_Atualizar.Visible = true;
                beneficios.label5.Text = "Atualizar benefício";

                beneficios.ShowDialog();
                listar_Beneficios();
            }
            else
            {
                guna2MessageDialog1_Error.Show("Por favor selecione o benefício que pretendes atualizar e tente novamente!", "Falha de atualização");
            }
        }
        private void dgv_beneficios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_beneficios.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Beneficios beneficios = new Modulos.Form_Modulo_Beneficios();
                beneficios.FormClosed += Beneficios_FormClosed;

                Program.AJUDA = 1;

                beneficios.label_id.Text = dgv_beneficios.CurrentRow.Cells[0].Value.ToString();
                beneficios.text_beneficio.Text = dgv_beneficios.CurrentRow.Cells[1].Value.ToString();
                beneficios.text_descricao.Text = dgv_beneficios.CurrentRow.Cells[2].Value.ToString();

                beneficios.btn_salvar.Visible = false;
                beneficios.btn_Atualizar.Visible = true;
                beneficios.label5.Text = "Atualizar benefício";

                beneficios.ShowDialog();
                listar_Beneficios();
            }
            else
            {
                guna2MessageDialog1_Error.Show("Por favor selecione o benefício que pretendes atualizar e tente novamente!", "Falha de atualização");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_beneficios.SelectedRows.Count > 0)
            {
                try
                {
                    int id_benefico = Convert.ToInt32(dgv_beneficios.CurrentRow.Cells[0].Value.ToString());
                   
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este benefício?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        c_Beneficios.id_beneficio = id_benefico;
                        d_Beneficios.eliminar_Beneficos(c_Beneficios);
                        guna2MessageDialog_Inform.Show($"O benefício com a identificação {id_benefico} foi eliminado com sucesso!", "Exclusão bem sucedida");
                        listar_Beneficios();
                    }
                }
                catch (Exception Ex)
                {
                    guna2MessageDialog1_Error.Show("Não foi possível eliminar este benefício!", Ex.Message);
                }
            }
            else
            {
                guna2MessageDialog1_Error.Show("Por favor selecione o benefício que pretendes eliminar e tente novamente!", "Falha de atualização");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Beneficos();
        }
        private void pesquisar_Beneficos()
        {
            dgv_beneficios.DataSource = p_Beneficios.pesquisar_Beneficos(text_pesquisar.Text);
        }
    }
}
