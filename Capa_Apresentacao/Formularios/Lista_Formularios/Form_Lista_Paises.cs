using Capa_Apresentacao.Formularios.Modulos;
using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Paises : Form
    {
        #region Instanciação de classes e métodos
        e_comum_paises c_paises = new e_comum_paises();
        dominio_paises d_paises = new dominio_paises();
        dominio_pesquisar_paises p_paises = new dominio_pesquisar_paises();
        #endregion
        public Form_Lista_Paises()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");

        }
        #region Método para listar os países
        private void listar_paises()
        {
            dgv_paises.DataSource = d_paises.selecionar_paises();
        }
        #endregion
        private void Form_Lista_Paises_Load(object sender, EventArgs e)
        {
            listar_paises();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Paises formulario = new Form_Modulo_Paises();
            formulario.FormClosed += Formulario_FormClosed;
            formulario.Show();
            listar_paises();
        }
        private void atualizar_lista_paises(object sender, FormClosedEventArgs e)
        {
            listar_paises();
        }
        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_paises();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_paises.SelectedRows.Count > 0)
            {

                Form_Modulo_Paises formulario = new Form_Modulo_Paises();
                Program.AJUDA = 1;

                formulario.FormClosed += Formulario_FormClosed;
                formulario.label_id.Text = dgv_paises.CurrentRow.Cells[0].Value.ToString();
                formulario.text_continentes.Text = dgv_paises.CurrentRow.Cells[1].Value.ToString();
                formulario.text_pais.Text = dgv_paises.CurrentRow.Cells[2].Value.ToString();
                formulario.text_data_registro.Text = dgv_paises.CurrentRow.Cells[3].Value.ToString();
                
                formulario.btn_salvar.Visible = false;
                formulario.btn_Atualizar.Visible = true;
                formulario.label5.Text = "Atualizar país";

                listar_paises();
                formulario.Show();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o país que pretende atualizar e tente novamente!", "Alerta");
            }
        }
        private void dgv_paises_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_paises.SelectedRows.Count > 0)
            {
                Program.AJUDA = 1;

                Form_Modulo_Paises formulario = new Form_Modulo_Paises();
                formulario.FormClosed += Formulario_FormClosed;

                formulario.label_id.Text = dgv_paises.CurrentRow.Cells[0].Value.ToString();
                formulario.text_continentes.Text = dgv_paises.CurrentRow.Cells[1].Value.ToString();
                formulario.text_pais.Text = dgv_paises.CurrentRow.Cells[2].Value.ToString();
                formulario.text_data_registro.Text = dgv_paises.CurrentRow.Cells[3].Value.ToString();

                formulario.btn_salvar.Visible = false;
                formulario.btn_Atualizar.Visible = true;
                formulario.label5.Text = "Atualizar país";

                listar_paises();
                formulario.Show();


            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o país que pretende atualizar e tente novamente!", "Alerta");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_paises.SelectedRows.Count > 0)
            {
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este país?", "Mensagem de exclusão") == DialogResult.Yes)
                {
                    int _id = Convert.ToInt32(dgv_paises.CurrentRow.Cells[0].Value.ToString());
                    c_paises.id_pais = _id;
                    d_paises.eliminar_paises(c_paises);
                    guna2MessageDialog_Inform.Show($"O país com a identificação {_id} foi eliminada com sucesso!", "Exclusão bem sucedida");
                    listar_paises();
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o país que pretende eliminar e tente novamente!", "Alerta");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_paises();
        }
        private void pesquisar_paises()
        {
            dgv_paises.DataSource = p_paises.pesquisar_paises(text_pesquisar.Text);
        }


    }
}
