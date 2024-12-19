using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Casos : Form
    {
        e_comum_casos c_Casos = new e_comum_casos();
        dominio_casos d_Casos = new dominio_casos();
        dominio_pesquisar_casos p_Casos = new dominio_pesquisar_casos();
        public Form_Lista_Casos()
        {
            InitializeComponent();
            selecionar_Casos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Casos()
        {
            dgv_casos.DataSource = d_Casos.selecionar_Casos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Formularios.Modulos.Form_Modulo_Casos modulo_Casos = new Modulos.Form_Modulo_Casos();
            modulo_Casos.FormClosed += Modulo_Casos_FormClosed;
            modulo_Casos.ShowDialog();
        }

        private void Modulo_Casos_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Casos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            if (dgv_casos.SelectedCells.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Casos modulo_Casos = new Modulos.Form_Modulo_Casos();
                modulo_Casos.FormClosed += Modulo_Casos_FormClosed;

                Program.AJUDA = 1;

                modulo_Casos.label_id.Text = dgv_casos.CurrentRow.Cells[0].Value.ToString();
                modulo_Casos.text_titulo.Text = dgv_casos.CurrentRow.Cells[1].Value.ToString();
                modulo_Casos.text_investigador.Text = dgv_casos.CurrentRow.Cells[2].Value.ToString();
                modulo_Casos.text_departamento.Text = dgv_casos.CurrentRow.Cells[3].Value.ToString();
                modulo_Casos.text_data_abetura.Text = dgv_casos.CurrentRow.Cells[4].Value.ToString();
                modulo_Casos.text_data_fechamento.Text = dgv_casos.CurrentRow.Cells[5].Value.ToString();
                modulo_Casos.text_estado.Text = dgv_casos.CurrentRow.Cells[6].Value.ToString();
                modulo_Casos.text_descricao.Text = dgv_casos.CurrentRow.Cells[7].Value.ToString();
                modulo_Casos.text_data_registro.Text = dgv_casos.CurrentRow.Cells[9].Value.ToString();

                modulo_Casos.label5.Text = "Atualizar caso";
                modulo_Casos.btn_salvar.Visible = false;
                modulo_Casos.btn_Atualizar.Visible = true;

                modulo_Casos.ShowDialog();
                selecionar_Casos();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o usuário que pretende atualizar e tente novamente!", "Falha");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_casos.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir este caso?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Caso = Convert.ToInt32(dgv_casos.CurrentRow.Cells[0].Value.ToString());
                        c_Casos.id_caso = id_Caso;
                        d_Casos.eliminar_Casos(c_Casos);
                        guna2MessageDialog_Inform.Show($"O caso com a identificação {id_Caso} foi excluido com sucesso!", "Exclusão bem sucedida");
                        selecionar_Casos();

                    }
                }
                catch (System.Data.SqlClient.SqlException Ex)
                {
                    if (Ex.Number == 547)
                        MessageDialog_Error.Show("Não é possível eliminar este caso, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão");
                }
                catch (Exception Ex)
                {

                    MessageDialog_Error.Show("Não foi possível eliminar este caso!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o usuário que pretende eliminar e tente novamente!", "Falha");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Casos();
        }
        private void pesquisar_Casos()
        {
            dgv_casos.DataSource = p_Casos.pesquisar_Caso(text_pesquisar.Text);
        }
    }
}
