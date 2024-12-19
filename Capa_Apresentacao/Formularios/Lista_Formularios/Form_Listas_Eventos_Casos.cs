using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Listas_Eventos_Casos : Form
    {
        #region Instanciação de classes e métodos
        dominio_eventos_casos d_eventos_casos = new dominio_eventos_casos();
        e_comum_eventos_casos c_eventos_casos = new e_comum_eventos_casos();
        dominio_pesquisar_eventos_casos p_evento_caso = new dominio_pesquisar_eventos_casos();
        #endregion
        public Form_Listas_Eventos_Casos()
        {
            InitializeComponent();
            selecionar_eventos_casos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_eventos_casos()
        {
            dgv_eventos_casos.DataSource = d_eventos_casos.selecionar_Eventos_Casos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Eventos_Casos form_Modulo_Eventos = new Modulos.Form_Modulo_Eventos_Casos();
            form_Modulo_Eventos.FormClosed += Form_Modulo_Eventos_FormClosed;
            form_Modulo_Eventos.ShowDialog();
        }

        private void Form_Modulo_Eventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_eventos_casos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_eventos_casos.SelectedRows.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Eventos_Casos form_Modulo_Eventos = new Modulos.Form_Modulo_Eventos_Casos();
                form_Modulo_Eventos.FormClosed += Form_Modulo_Eventos_FormClosed;

                Program.AJUDA = 1;
                form_Modulo_Eventos.label_id.Text = dgv_eventos_casos.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Eventos.text_caso.Text = dgv_eventos_casos.CurrentRow.Cells[1].Value.ToString();
                form_Modulo_Eventos.text_vitima.Text = dgv_eventos_casos.CurrentRow.Cells[2].Value.ToString();
                form_Modulo_Eventos.text_suspeito.Text = dgv_eventos_casos.CurrentRow.Cells[3].Value.ToString();
                form_Modulo_Eventos.text_testemunha.Text = dgv_eventos_casos.CurrentRow.Cells[4].Value.ToString();
                form_Modulo_Eventos.text_investigador.Text = dgv_eventos_casos.CurrentRow.Cells[5].Value.ToString();
                form_Modulo_Eventos.text_data_evento.Text = dgv_eventos_casos.CurrentRow.Cells[6].Value.ToString();
                form_Modulo_Eventos.text_tipo_evento.Text = dgv_eventos_casos.CurrentRow.Cells[7].Value.ToString();
                form_Modulo_Eventos.text_descricao.Text = dgv_eventos_casos.CurrentRow.Cells[8].Value.ToString();
                form_Modulo_Eventos.text_data_registro.Text = dgv_eventos_casos.CurrentRow.Cells[10].Value.ToString();

                form_Modulo_Eventos.btn_salvar.Text = "Atualizar";
                form_Modulo_Eventos.label5.Text = "Atualizar";
                form_Modulo_Eventos.btn_salvar.FillColor = Color.SeaGreen;

                form_Modulo_Eventos.ShowDialog();
            }
        }

        private void dgv_eventos_casos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_eventos_casos.SelectedRows.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Eventos_Casos form_Modulo_Eventos = new Modulos.Form_Modulo_Eventos_Casos();
                form_Modulo_Eventos.FormClosed += Form_Modulo_Eventos_FormClosed;

                Program.AJUDA = 1;
                form_Modulo_Eventos.label_id.Text = dgv_eventos_casos.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Eventos.text_caso.Text = dgv_eventos_casos.CurrentRow.Cells[1].Value.ToString();
                form_Modulo_Eventos.text_vitima.Text = dgv_eventos_casos.CurrentRow.Cells[2].Value.ToString();
                form_Modulo_Eventos.text_suspeito.Text = dgv_eventos_casos.CurrentRow.Cells[3].Value.ToString();
                form_Modulo_Eventos.text_testemunha.Text = dgv_eventos_casos.CurrentRow.Cells[4].Value.ToString();
                form_Modulo_Eventos.text_investigador.Text = dgv_eventos_casos.CurrentRow.Cells[5].Value.ToString();
                form_Modulo_Eventos.text_data_evento.Text = dgv_eventos_casos.CurrentRow.Cells[6].Value.ToString();
                form_Modulo_Eventos.text_tipo_evento.Text = dgv_eventos_casos.CurrentRow.Cells[7].Value.ToString();
                form_Modulo_Eventos.text_descricao.Text = dgv_eventos_casos.CurrentRow.Cells[8].Value.ToString();
                form_Modulo_Eventos.text_data_registro.Text = dgv_eventos_casos.CurrentRow.Cells[10].Value.ToString();

                form_Modulo_Eventos.btn_salvar.Text = "Atualizar";
                form_Modulo_Eventos.label5.Text = "Atualizar";
                form_Modulo_Eventos.btn_salvar.FillColor = Color.SeaGreen;

                form_Modulo_Eventos.ShowDialog();
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_eventos_casos.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir este evento -> caso?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_evento_caso = Convert.ToInt32(dgv_eventos_casos.CurrentRow.Cells[0].Value.ToString());
                        c_eventos_casos.id_evento_caso = id_evento_caso;
                        d_eventos_casos.eliminar_Enventos_Casos(c_eventos_casos);
                        guna2MessageDialog_Inform.Show($"O evento -> caso com a identificação {id_evento_caso}, foi excluída com sucesso!", "Exclusão bem sucedida");
                        selecionar_eventos_casos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este evento -> caso!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o evento -> caso que pretende excluir e tente novamente!", "Erro de seleção");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_eventos_casos();
        }
        private void pesquisar_eventos_casos()
        {
            dgv_eventos_casos.DataSource = p_evento_caso.pesquisar_Eventos_Casos(text_pesquisar.Text);
        }
    }
}
