using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Beneficios_Investigadores : Form
    {
        e_comum_beneficios_investigadores c_Beneficios_Investigadores = new e_comum_beneficios_investigadores();
        dominio_beneficos_Investigadores d_Beneficos_Investigadores = new dominio_beneficos_Investigadores();
        dominio_pesquisar_beneficios_investigadores p_Beneficios_Investigadores = new dominio_pesquisar_beneficios_investigadores();
        public Form_Lista_Beneficios_Investigadores()
        {
            InitializeComponent();

            listar_Beneficios_Investigadores();
            titulo();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void listar_Beneficios_Investigadores()
        {
            dgv_beneficios_investigadores.DataSource = d_Beneficos_Investigadores.selecionar_Beneficios_Investigadores();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Beneficios_Investigadores beneficios_Investigadores = new Modulos.Form_Modulo_Beneficios_Investigadores();
            beneficios_Investigadores.FormClosed += Beneficios_Investigadores_FormClosed;
            beneficios_Investigadores.ShowDialog();
            listar_Beneficios_Investigadores();
        }

        private void Beneficios_Investigadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Beneficios_Investigadores();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_beneficios_investigadores.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Beneficios_Investigadores beneficios_Investigadores = new Modulos.Form_Modulo_Beneficios_Investigadores();
                beneficios_Investigadores.FormClosed += Beneficios_Investigadores_FormClosed;

                beneficios_Investigadores.label_id.Text = dgv_beneficios_investigadores.CurrentRow.Cells[0].Value.ToString();
                beneficios_Investigadores.text_beneficio.Text = dgv_beneficios_investigadores.CurrentRow.Cells[1].Value.ToString();
                beneficios_Investigadores.text_investigador.Text = dgv_beneficios_investigadores.CurrentRow.Cells[2].Value.ToString();
                beneficios_Investigadores.text_data_inicio_beneficio.Text = dgv_beneficios_investigadores.CurrentRow.Cells[3].Value.ToString();
                beneficios_Investigadores.text_data_fim_beneficio.Text = dgv_beneficios_investigadores.CurrentRow.Cells[4].Value.ToString();
             
                beneficios_Investigadores.btn_Atualizar.Visible = true;
                beneficios_Investigadores.btn_salvar.Visible = false;
                beneficios_Investigadores.label5.Text = "Atualizar benefício - funcionário";

                beneficios_Investigadores.ShowDialog();
                listar_Beneficios_Investigadores();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o benefício-investigador que pretende atualizar e tente novamente!", "Falha de atualização");
            }
        }
        private void titulo()
        {
            dgv_beneficios_investigadores.Columns[0].Visible = false;
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_beneficios_investigadores.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este benefício-investigador?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_beneficio = Convert.ToInt32(dgv_beneficios_investigadores.CurrentRow.Cells[0].Value.ToString());
                        c_Beneficios_Investigadores.id_beneficio_investigador = id_beneficio;
                        d_Beneficos_Investigadores.eliminar_Beneficios_Investigadores(c_Beneficios_Investigadores);

                        guna2MessageDialog_Inform.Show("Benefício-investigador eliminado com sucesso!", "Exclusão bem sucedida");
                        listar_Beneficios_Investigadores();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este benefício-investigador", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o benefício-investigador que pretende eliminar e tente novamente!", "Falha de exclusão");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Beneficios_Investigadores();
        }
        private void pesquisar_Beneficios_Investigadores()
        {
            dgv_beneficios_investigadores.DataSource =
                p_Beneficios_Investigadores.pesquisar_Beneficos_Investigadores(text_pesquisar.Text);
        }
    }
}
