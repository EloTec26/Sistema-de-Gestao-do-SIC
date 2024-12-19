using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Listas_Cargos_Investigadores : Form
    {
        e_comum_cargos_investigadores c_Cargos_Investigadores = new e_comum_cargos_investigadores();
        dominio_cargos_investigadores d_Cargos_Investigadores = new dominio_cargos_investigadores();
        dominio_pesquisar_cargos_investigadores p_Cargos_Investigadores = new dominio_pesquisar_cargos_investigadores();
        public Form_Listas_Cargos_Investigadores()
        {
            InitializeComponent();
            selecionar_Cargos_Investigadores();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Cargos_Investigadores()
        {
            dgv_cargos_investigadores.DataSource = d_Cargos_Investigadores.selcionar_Cargos_Investigadores();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Cargos_Investigadores form_Modulo_Cargos_Investigadores = new Modulos.Form_Modulo_Cargos_Investigadores();
            form_Modulo_Cargos_Investigadores.FormClosed += Form_Modulo_Cargos_Investigadores_FormClosed;
            form_Modulo_Cargos_Investigadores.ShowDialog();
        }
        private void Form_Modulo_Cargos_Investigadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Cargos_Investigadores();
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_cargos_investigadores.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Cargos_Investigadores form_Modulo_Cargos_Investigadores = new Modulos.Form_Modulo_Cargos_Investigadores();
                form_Modulo_Cargos_Investigadores.FormClosed += Form_Modulo_Cargos_Investigadores_FormClosed;

                form_Modulo_Cargos_Investigadores.label_id.Text = dgv_cargos_investigadores.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Cargos_Investigadores.text_cargo.Text = dgv_cargos_investigadores.CurrentRow.Cells[1].Value.ToString();
                form_Modulo_Cargos_Investigadores.text_investigador.Text = dgv_cargos_investigadores.CurrentRow.Cells[2].Value.ToString();

                form_Modulo_Cargos_Investigadores.label5.Text = "Atualizar o cargo do funcionário";
                form_Modulo_Cargos_Investigadores.btn_salvar.Visible = false;
                form_Modulo_Cargos_Investigadores.btn_Atualizar.Visible = true;
                form_Modulo_Cargos_Investigadores.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a informação que pretende atualizar e tente novamente!", "Erro ao atualizar");
            }
        }

        private void dgv_cargos_investigadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cargos_investigadores.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Cargos_Investigadores form_Modulo_Cargos_Investigadores = new Modulos.Form_Modulo_Cargos_Investigadores();
                form_Modulo_Cargos_Investigadores.FormClosed += Form_Modulo_Cargos_Investigadores_FormClosed;

                form_Modulo_Cargos_Investigadores.label_id.Text = dgv_cargos_investigadores.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Cargos_Investigadores.text_cargo.Text = dgv_cargos_investigadores.CurrentRow.Cells[1].Value.ToString();
                form_Modulo_Cargos_Investigadores.text_investigador.Text = dgv_cargos_investigadores.CurrentRow.Cells[2].Value.ToString();

                form_Modulo_Cargos_Investigadores.label5.Text = "Atualizar o cargo do funcionário";
                form_Modulo_Cargos_Investigadores.btn_salvar.Visible = false;
                form_Modulo_Cargos_Investigadores.btn_Atualizar.Visible = true;

                form_Modulo_Cargos_Investigadores.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a informação que pretende atualizar e tente novamente!", "Erro ao atualizar");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_cargos_investigadores.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir esta informação?", "Mensagem de excluisão") == DialogResult.Yes)
                    {
                        int id_Cargos_Investigadores = Convert.ToInt32(dgv_cargos_investigadores.CurrentRow.Cells[0].Value.ToString());
                        c_Cargos_Investigadores.id_cargo_investigador = id_Cargos_Investigadores;
                        d_Cargos_Investigadores.eliminar_Cargos_Investigadores(c_Cargos_Investigadores);
                        guna2MessageDialog_Inform.Show($"A informação com a identificação {id_Cargos_Investigadores}, foi excluída com sucesso!", "Exclusão bem sucedida");
                        selecionar_Cargos_Investigadores();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao eliminar o cargo!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a informação que pretende eliminar e tente novamente!", "Erro ao excluir");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquiar_c_investigadores();
        }
        private void pesquiar_c_investigadores()
        {
            dgv_cargos_investigadores.DataSource = p_Cargos_Investigadores.pesquisar_Cargo_Investigadores(text_pesquisar.Text);
        }
    }
}
