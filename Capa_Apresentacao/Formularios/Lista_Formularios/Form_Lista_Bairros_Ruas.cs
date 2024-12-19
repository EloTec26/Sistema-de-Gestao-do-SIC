using Capa_Apresentacao.Formularios.Modulos;
using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;


namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Bairros_Ruas : Form
    {
        e_comum_bairro_rua c_Bairros_Ruas = new e_comum_bairro_rua();
        dominio_pesquisar_bairro_ruas p_Bairro_Rua = new dominio_pesquisar_bairro_ruas();
        dominio_bairro_rua d_Bairro_Rua = new dominio_bairro_rua();
        public Form_Lista_Bairros_Ruas()
        {
            InitializeComponent();
            lista_Bairros_Ruas();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }

        private void lista_Bairros_Ruas()
        {
            dgv_bairros_ruas.DataSource = d_Bairro_Rua.selecionar_bairros_ruas();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Bairro_Rua formulario = new Form_Modulo_Bairro_Rua();
            formulario.FormClosed += Formulario_FormClosed;
            formulario.Show();
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            lista_Bairros_Ruas();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_bairros_ruas.SelectedRows.Count > 0)
            {
                Form_Modulo_Bairro_Rua formulario = new Form_Modulo_Bairro_Rua();

                Program.AJUDA = 1;

                formulario.label_id.Text = dgv_bairros_ruas.CurrentRow.Cells[0].Value.ToString();
                formulario.text_municipio.Text = dgv_bairros_ruas.CurrentRow.Cells[1].Value.ToString();
                formulario.text_bairro_rua.Text = dgv_bairros_ruas.CurrentRow.Cells[2].Value.ToString();
                
                formulario.label5.Text = "Atualizar bairro/rua";

                formulario.btn_salvar.Visible = false;
                formulario.btn_Atualizar.Visible = true;


                formulario.FormClosed += Formulario_FormClosed;
                formulario.Show();
                lista_Bairros_Ruas();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o bairro/rua que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void dgv_bairros_ruas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bairros_ruas.SelectedRows.Count > 0)
            {
                Form_Modulo_Bairro_Rua formulario = new Form_Modulo_Bairro_Rua();

                Program.AJUDA = 1;

                formulario.label_id.Text = dgv_bairros_ruas.CurrentRow.Cells[0].Value.ToString();
                formulario.text_municipio.Text = dgv_bairros_ruas.CurrentRow.Cells[1].Value.ToString();
                formulario.text_bairro_rua.Text = dgv_bairros_ruas.CurrentRow.Cells[2].Value.ToString();
              
                formulario.label5.Text = "Atualizar bairro/rua";
                formulario.btn_salvar.Visible = false;
                formulario.btn_Atualizar.Visible = true;

                formulario.FormClosed += Formulario_FormClosed;
                formulario.Show();
                lista_Bairros_Ruas();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o bairro/rua que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_bairros_ruas.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este bairro/rua?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgv_bairros_ruas.CurrentRow.Cells[0].Value.ToString());
                        c_Bairros_Ruas.id_bairro_rua = id;
                        d_Bairro_Rua.eliminar_bairros_ruas(c_Bairros_Ruas);

                        guna2MessageDialog_Inform.Show($"O bairro/rua com a identificação{id}, foi eliminado com sucesso!", "Exclusão bem sucedida");
                        lista_Bairros_Ruas();
                    }
                }
                catch (System.Data.SqlClient.SqlException Ex)
                {
                    if (Ex.Number == 457)
                    {
                        MessageDialog_Error.Show("Não é possível eliminar este bairro/rua, pois existem - no sistema-, dados que estão vinculados à ele", "Alerta");
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este bairro/rua", Ex.Message);
                }
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Bairro_Ruas();
        }
        private void pesquisar_Bairro_Ruas()
        {
            dgv_bairros_ruas.DataSource = p_Bairro_Rua.pesquisar_bairro_ruas(text_pesquisar.Text);
        }

    }
}
