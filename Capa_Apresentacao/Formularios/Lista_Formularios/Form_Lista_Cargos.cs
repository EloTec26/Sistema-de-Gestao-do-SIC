using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio.Dominio_Pesquisas;
using Capa_Dominio;
using Capa_Comum.Entidades;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Apresentacao.Formularios.Modulos;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Cargos : Form
    {
        e_comum_cargos c_Cargos = new e_comum_cargos();
        dominio_cargos d_Cargos = new dominio_cargos();
        dominio_pesquisar_cargos p_Cargos = new dominio_pesquisar_cargos();
        public Form_Lista_Cargos()
        {
            InitializeComponent();
            selecionar_Cargos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Cargos()
        {
            dgv_cargos.DataSource = d_Cargos.selecionar_Cargos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Cargos form_Modulo_Cargos = new Form_Modulo_Cargos();
            form_Modulo_Cargos.FormClosed += Form_Modulo_Cargos_FormClosed;
            form_Modulo_Cargos.ShowDialog();
        }

        private void Form_Modulo_Cargos_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Cargos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_cargos.SelectedRows.Count > 0)
            {
                Form_Modulo_Cargos form_Modulo_Cargos = new Form_Modulo_Cargos();
                form_Modulo_Cargos.FormClosed += Form_Modulo_Cargos_FormClosed;

                Program.AJUDA = 1;

                form_Modulo_Cargos.label_id.Text = dgv_cargos.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Cargos.text_Cargo.Text = dgv_cargos.CurrentRow.Cells[1].Value.ToString();
               
                form_Modulo_Cargos.label5.Text = "Atualizar cargo";
                form_Modulo_Cargos.btn_Atualizar.Visible = true;
                form_Modulo_Cargos.btn_salvar.Visible = false;
                form_Modulo_Cargos.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o cargo que pretende atualizar e tente novamente!", "Falha de atualização");
            }
        }

        private void dgv_cargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cargos.SelectedRows.Count > 0)
            {
                Form_Modulo_Cargos form_Modulo_Cargos = new Form_Modulo_Cargos();
                form_Modulo_Cargos.FormClosed += Form_Modulo_Cargos_FormClosed;

                Program.AJUDA = 1;

                form_Modulo_Cargos.label_id.Text = dgv_cargos.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Cargos.text_Cargo.Text = dgv_cargos.CurrentRow.Cells[1].Value.ToString();
              
                form_Modulo_Cargos.label5.Text = "Atualizar cargo";
                form_Modulo_Cargos.btn_Atualizar.Visible = true;
                form_Modulo_Cargos.btn_salvar.Visible = false;

                form_Modulo_Cargos.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o cargo que pretende atualizar e tente novamente!", "Falha de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_cargos.SelectedRows.Count > 0)
            {
                if(guna2MessageDialog_Confirm.Show("Tens a certeza de excluir este cargo?", "Mensagem de confirmação") == DialogResult.Yes)
                {
                    int id_Cargo = Convert.ToInt32(dgv_cargos.CurrentRow.Cells[0].Value.ToString());
                    c_Cargos.id_cargo = id_Cargo;
                    d_Cargos.eliminar_Cargos(c_Cargos);
                    guna2MessageDialog_Confirm.Show($"O cargo com a identificação {id_Cargo}, foi excluído com sucesso!", "Exclusão bem sucedida");
                    selecionar_Cargos();
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o cargo que pretende eliminar e tente novamente!", "Falha de atualização");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Cargo();
        }
        private void pesquisar_Cargo()
        {
            dgv_cargos.DataSource = p_Cargos.pesquisar_cargos(text_pesquisar.Text);
        }
    }
}
