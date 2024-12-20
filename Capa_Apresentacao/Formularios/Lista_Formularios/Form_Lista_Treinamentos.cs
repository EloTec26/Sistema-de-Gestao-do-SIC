using Capa_Apresentacao.Formularios.Modulos;
using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Treinamentos : Form
    {
        e_comum_treinamentos E_Treinamentos = new e_comum_treinamentos();
        dominio_treinamentos D_Treinamentos = new dominio_treinamentos();
        dominio_pesquisar_treinamentos P_Treinamentos = new dominio_pesquisar_treinamentos();
        public Form_Lista_Treinamentos()
        {
            InitializeComponent();

            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");

            Carregar_Treinamentos();
        }
        private void Carregar_Treinamentos()
        {
            dgv_treinamento.DataSource = D_Treinamentos.selecionar_treinamentos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Treinamentos modulo = new Form_Modulo_Treinamentos();
            modulo.FormClosed += Modulo_FormClosed;
            modulo.ShowDialog();
        }
        private void Modulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Carregar_Treinamentos();
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_treinamento.SelectedCells.Count > 0)
            {
                Form_Modulo_Treinamentos modulo = new Form_Modulo_Treinamentos();
                modulo.FormClosed += Modulo_FormClosed;

                modulo.label_id.Text = dgv_treinamento.CurrentRow.Cells[0].Value.ToString();
                modulo.text_titulo.Text = dgv_treinamento.CurrentRow.Cells[1].Value.ToString();
                modulo.text_funcionario.Text = dgv_treinamento.CurrentRow.Cells[2].Value.ToString();
                modulo.text_departamento.Text = dgv_treinamento.CurrentRow.Cells[3].Value.ToString();
                modulo.text_data_inicial_treinamento.Text = dgv_treinamento.CurrentRow.Cells[4].Value.ToString();
                modulo.text_data_final_treinamento.Text = dgv_treinamento.CurrentRow.Cells[5].Value.ToString();
                modulo.text_descricao.Text = dgv_treinamento.CurrentRow.Cells[6].Value.ToString();

                modulo.label_info.Text = "Atualizar treinamento";
                modulo.btn_salvar.Visible = false;
                modulo.btn_Atualizar.Visible = true;

                modulo.ShowDialog();
                Carregar_Treinamentos();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a testemunha que pretende atualizar e tente novamente!", "Falha");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_treinamento.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar esta treinamento?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int Id_Treinamento = Convert.ToInt32(dgv_treinamento.CurrentRow.Cells[0].Value.ToString());
                        E_Treinamentos.id_treinamento = Id_Treinamento;
                        D_Treinamentos.eliminar_treinamentos(E_Treinamentos);
                        guna2MessageDialog_Inform.Show($"O treinamento com a identificação {Id_Treinamento} foi excluido com sucesso!", "Exclusão bem sucedida");
                        Carregar_Treinamentos();
                    }
                }
                catch (SqlException Ex)
                {
                    if (Ex.Number == 547)
                        MessageDialog_Error.Show("Não é possível eliminar este treinamento, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão");
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este treinamento!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o treinamento que pretende eliminar e tente novamente!", "Falha");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            Pesquisar_Treinament();
        }
        private void Pesquisar_Treinament()
        {
            dgv_treinamento.DataSource = P_Treinamentos.pesquisar_Treinamentos(text_pesquisar.Text);
        }
    }
}
