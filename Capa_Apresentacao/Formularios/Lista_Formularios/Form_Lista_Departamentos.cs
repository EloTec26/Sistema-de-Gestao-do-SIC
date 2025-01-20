using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Departamentos : Form
    {

        e_comum_departamentos c_Departamentos = new e_comum_departamentos();
        dominio_departamentos d_Departamentos = new dominio_departamentos();
        dominio_pesquisar_departamentos p_Departamentos = new dominio_pesquisar_departamentos();

        public Form_Lista_Departamentos()
        {
            InitializeComponent();
            // Inicialização de métodos
            listar_Departamentos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        public void listar_Departamentos()
        {
            dgv_departamentos.DataSource = d_Departamentos.selecionar_Departamentos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Departamentos departamentos = new Modulos.Form_Modulo_Departamentos(this);
            departamentos.FormClosed += Departamentos_FormClosed;
            departamentos.ShowDialog();
            listar_Departamentos();
        }

        private void Departamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Departamentos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_departamentos.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Departamentos departamentos = new Modulos.Form_Modulo_Departamentos(this);
                departamentos.FormClosed += Departamentos_FormClosed;

                departamentos.label_id.Text = dgv_departamentos.CurrentRow.Cells[0].Value.ToString();
                departamentos.text_departamento.Text = dgv_departamentos.CurrentRow.Cells[1].Value.ToString();
                departamentos.text_descricao.Text = dgv_departamentos.CurrentRow.Cells[2].Value.ToString();

                departamentos.btn_Atualizar.Visible = true;
                departamentos.btn_salvar.Visible = false;
                departamentos.label5.Text = "Atualizar departamento";

                departamentos.ShowDialog();
                listar_Departamentos();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o departamento que pretendes atualizar e tente novamente!", "Falha");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_departamentos.SelectedRows.Count > 0)
            {
                try
                {
                    int id_departamento = Convert.ToInt32(dgv_departamentos.CurrentRow.Cells[0].Value.ToString());
                    c_Departamentos.id_departamento = id_departamento;
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este departamento?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        d_Departamentos.eliminar_Departamentos(c_Departamentos);
                        guna2MessageDialog_Inform.Show($"O departamento com a identificação{id_departamento} foi eliminada com sucesso!", "Exclusão bem sucedida");
                        listar_Departamentos();
                    }
                }
                catch (System.Data.SqlClient.SqlException Ex)
                {
                    if (Ex.Number == 457)
                    {
                        MessageDialog_Error.Show("Não é possível eliminar esta especialidade, pois existem - no sistema-, dados que estão vinculados  à ela.", "Alerta");
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este departamento!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o departamento que pretendes eliminar e tente novamente!", "Falha");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Departamentos();
        }
        private void pesquisar_Departamentos()
        {
            dgv_departamentos.DataSource = p_Departamentos.pesquisar_Departamentos(text_pesquisar.Text);
        }
    }
}
