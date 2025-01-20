using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;


namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Niveis_Academicos : Form
    {
        e_comum_nivel_academicos c_Niveis_Academicos = new e_comum_nivel_academicos();
        dominio_niveis_academicos d_Niveis_Academicos = new dominio_niveis_academicos();
        dominio_pesquisar_niveis_academicos P_Niveis_Academicos = new dominio_pesquisar_niveis_academicos();
        public Form_Lista_Niveis_Academicos()
        {
            InitializeComponent();
            listat_Niveis_Academicos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        public void listat_Niveis_Academicos()
        {
            dgv_niveis_academicos.DataSource = d_Niveis_Academicos.selecionar_niveis_academicos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Niveis_Academicos niveis_Academicos = new Modulos.Form_Modulo_Niveis_Academicos(this);
            niveis_Academicos.FormClosed += Niveis_Academicos_FormClosed;
            niveis_Academicos.ShowDialog();
            listat_Niveis_Academicos();
        }
        private void Niveis_Academicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            listat_Niveis_Academicos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_niveis_academicos.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Niveis_Academicos niveis_Academicos = new Modulos.Form_Modulo_Niveis_Academicos(this);
                niveis_Academicos.FormClosed += Niveis_Academicos_FormClosed;

                niveis_Academicos.label_id.Text = dgv_niveis_academicos.CurrentRow.Cells[0].Value.ToString();
                niveis_Academicos.text_Nivel_Academico.Text = dgv_niveis_academicos.CurrentRow.Cells[1].Value.ToString();

                niveis_Academicos.btn_atualizar.Visible = true;
                niveis_Academicos.btn_salvar.Visible = false;
                niveis_Academicos.label5.Text = "Atualizar nível acadêmico";

                niveis_Academicos.ShowDialog();
                listat_Niveis_Academicos();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o nível acadêmico que pretendes atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_niveis_academicos.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este nível acadêmico?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int _id = Convert.ToInt32(dgv_niveis_academicos.CurrentRow.Cells[0].Value.ToString());
                        c_Niveis_Academicos.id_nivel_academico = _id;
                        d_Niveis_Academicos.eliminar_niveis_academicos(c_Niveis_Academicos);
                        guna2MessageDialog_Inform.Show($"O nível acadêmico com o identificador {_id} foi eliminada com sucesso!", "Exclusão bem sucedida");
                        listat_Niveis_Academicos();
                    }
                }
                //catch (System.Data.SqlClient.SqlException Ex)
                //{
                //    MessageDialog_Error.Show(Ex.Message);
                //}
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este nível acadêmico.", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o nível acadêmico que pretendes eliminar e tente novamente!", "Erro de atualização");

            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Niveis_Academicos();
        }
        private void pesquisar_Niveis_Academicos()
        {
            dgv_niveis_academicos.DataSource = P_Niveis_Academicos.pesquisar_Niveis_Academicos(text_pesquisar.Text);
        }
    }
}
