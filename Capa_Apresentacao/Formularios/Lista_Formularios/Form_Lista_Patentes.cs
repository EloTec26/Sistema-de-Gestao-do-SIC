using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Patentes : Form
    {
        e_comum_patentes c_Patentes = new e_comum_patentes();
        dominio_patentes d_Patentes = new dominio_patentes();
        dominio_pesquisar_patentes p_Patentes = new dominio_pesquisar_patentes();
        public Form_Lista_Patentes()
        {
            InitializeComponent();
            listar_Patentes();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void listar_Patentes()
        {
            dgv_patentes.DataSource = d_Patentes.selecionar_patentes();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Patentes patentes = new Modulos.Form_Modulo_Patentes();
            patentes.FormClosed += Patentes_FormClosed;
            patentes.ShowDialog();
            listar_Patentes();
        }

        private void Patentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Patentes();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_patentes.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Patentes patentes = new Modulos.Form_Modulo_Patentes();
                patentes.FormClosed += Patentes_FormClosed;

                patentes.label_id.Text = dgv_patentes.CurrentRow.Cells[0].Value.ToString();
                patentes.text_patentes.Text = dgv_patentes.CurrentRow.Cells[1].Value.ToString();
                patentes.text_descricao.Text = dgv_patentes.CurrentRow.Cells[2].Value.ToString();

                patentes.btn_salvar.Text = "Atualizar";
                patentes.label5.Text = "Atualizar";
                patentes.btn_salvar.FillColor = Color.SeaGreen;


                patentes.ShowDialog();
                listar_Patentes();
            }
            else
            {
                MessageBox.Show("Por favor, selecione patente que pretende atualizar e tente novamente!", "Falha",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_patentes.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Tens a certeza de eliminar esta patente?", "Mensagem de exclusão",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id_patentes = Convert.ToInt32(dgv_patentes.CurrentRow.Cells[0].Value.ToString());
                        c_Patentes.id_patente = id_patentes;
                        d_Patentes.eliminar_patentes(c_Patentes);
                        MessageBox.Show($"A patente com a identificãção {id_patentes}, foi eliminada com sucesso!", "Exclusão bem sucedida",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listar_Patentes();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Não foi possível eliminar esta patente!", Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione patente que pretende eliminar e tente novamente!", "Falha",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        // metodo para pesquisar
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Patentes();
        }
        private void pesquisar_Patentes()
        {
            dgv_patentes.DataSource = p_Patentes.pesquisar_Patentes(guna2TextBox1.Text);
        }
    }
}
