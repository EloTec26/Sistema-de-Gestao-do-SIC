using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Cursos : Form
    {
        dominio_cursos d_Cursos = new dominio_cursos();
        e_comum_cursos c_Cursos = new e_comum_cursos();
        dominio_pesquisar_cursos p_Cursos = new dominio_pesquisar_cursos();
        public Form_Lista_Cursos()
        {
            InitializeComponent();
            listar_Cursos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        public void listar_Cursos()
        {
            dgv_cursos.DataSource = d_Cursos.selecionar_Cursos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Cursos cursos = new Modulos.Form_Modulo_Cursos(this);
            cursos.FormClosed += Cursos_FormClosed;
            cursos.ShowDialog();
            listar_Cursos();
        }

        private void Cursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Cursos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_cursos.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Cursos cursos = new Modulos.Form_Modulo_Cursos(this);
                cursos.FormClosed += Cursos_FormClosed;

                cursos.label_id.Text = dgv_cursos.CurrentRow.Cells[0].Value.ToString();
                cursos.text_Curso.Text = dgv_cursos.CurrentRow.Cells[1].Value.ToString();

                cursos.label5.Text = "Atualizar curso profissional";
                cursos.btn_salvar.Visible = false;
                cursos.btn_Atualizar.Visible = true;
                cursos.ShowDialog();
                listar_Cursos();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o curso que pretendes atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_cursos.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este curso?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int _id = Convert.ToInt32(dgv_cursos.CurrentRow.Cells[0].Value.ToString());
                        c_Cursos.id_curso = _id;
                        d_Cursos.eliminar_Cursos(c_Cursos);
                        guna2MessageDialog_Inform.Show($"O curso com a identificação {_id} foi eliminada com sucesso!", "Exclusão bem sucedida");
                        listar_Cursos();
                    }
                }
                catch (System.Data.SqlClient.SqlException Ex)
                {
                    if (Ex.Number == 457)
                    {
                        MessageDialog_Error.Show("Não é possível eliminar este curso, pois existem - no sistema-, dados que estão vinculados  à ela.", "Alerta");
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este curso!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o curso que pretendes eliminar e tente novamente!", "Erro de atualização");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Cursos();
        }
        private void pesquisar_Cursos()
        {
            dgv_cursos.DataSource = p_Cursos.pesquisar_Cursos(text_pesquisar.Text);
        }
    }
}
