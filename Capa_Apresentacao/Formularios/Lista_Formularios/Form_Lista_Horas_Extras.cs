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
using Capa_Dominio.Dominio_Pesquisas;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Horas_Extras : Form
    {
        dominio_horas_extras d_Horas_Extras = new dominio_horas_extras();
        e_comum_horas_extras c_Horas_Extras = new e_comum_horas_extras();
        dominio_pesquisar_horas_extras p_h_Extras = new dominio_pesquisar_horas_extras();
        public Form_Lista_Horas_Extras()
        {
            InitializeComponent();
            selecionar_Horas_Extras();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        public void selecionar_Horas_Extras()
        {
            dgv_horas_extras.DataSource = d_Horas_Extras.selecionar_horas_extras();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Formularios.Modulos.Form_Modulo_Horas_Extras form_Horas_Extras = new Modulos.Form_Modulo_Horas_Extras(this);
            form_Horas_Extras.FormClosed += Form_Modulo_Horas_Extras_FormClosed;
            form_Horas_Extras.ShowDialog();
        }

        private void Form_Modulo_Horas_Extras_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Horas_Extras();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_horas_extras.SelectedRows.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Horas_Extras form_Horas_Extras = new Modulos.Form_Modulo_Horas_Extras(this);
                form_Horas_Extras.FormClosed += Form_Modulo_Horas_Extras_FormClosed;

                form_Horas_Extras.label_id.Text = dgv_horas_extras.CurrentRow.Cells[0].Value.ToString();
                form_Horas_Extras.text_investigador.Text = dgv_horas_extras.CurrentRow.Cells[1].Value.ToString();
                form_Horas_Extras.text_data_trabalho.Text = dgv_horas_extras.CurrentRow.Cells[2].Value.ToString();
                form_Horas_Extras.text_horas_trabalho.Text = dgv_horas_extras.CurrentRow.Cells[3].Value.ToString();
                form_Horas_Extras.text_tipo_horas.Text = dgv_horas_extras.CurrentRow.Cells[4].Value.ToString();
       
                form_Horas_Extras.btn_salvar.Visible = false;
                form_Horas_Extras.btn_atualizar.Visible = true;
                form_Horas_Extras.label5.Text = "Atualizar horas-extras";

                form_Horas_Extras.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione as horas_extras que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_horas_extras.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir estas horas-extras?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Horas_Extras = Convert.ToInt32(dgv_horas_extras.CurrentRow.Cells[0].Value.ToString());
                        c_Horas_Extras.id_hora_extra = id_Horas_Extras;
                        d_Horas_Extras.eliminar_horas_extras(c_Horas_Extras);
                        guna2MessageDialog_Inform.Show($"As horas_extras com a identificação {id_Horas_Extras}, foi exluída com sucesso!", "Exclusão bem-sucedida");
                        selecionar_Horas_Extras();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar estas horas-extras!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione as horas_extras que pretende eliminar e tente novamente!", "Erro de exclusão");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_H_Extras();
        }
        private void pesquisar_H_Extras()
        {
            dgv_horas_extras.DataSource = p_h_Extras.pesquisar_Horas_Extras(text_pesquisar.Text);
        }
    }
}
