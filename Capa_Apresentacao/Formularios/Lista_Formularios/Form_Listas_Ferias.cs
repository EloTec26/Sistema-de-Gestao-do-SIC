using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Comum.Entidades;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;


namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Listas_Ferias : Form
    {
        #region Instanciar classes e métodos
        e_comum_ferias c_Ferias = new e_comum_ferias();
        dominio_ferias d_Ferias = new dominio_ferias();
        dominio_pesquisar_ferias p_Ferias = new dominio_pesquisar_ferias();
        #endregion
        public Form_Listas_Ferias()
        {
            InitializeComponent();
            selecionar_Ferias();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Ferias()
        {
            dgv_ferias.DataSource = d_Ferias.selecionar_Ferias();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Formularios.Modulos.Form_Modulo_Ferias modulo_Ferias = new Modulos.Form_Modulo_Ferias();
            modulo_Ferias.FormClosed += Modulo_Ferias_FormClosed;
            modulo_Ferias.ShowDialog();
        }

        private void Modulo_Ferias_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Ferias();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_ferias.SelectedRows.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Ferias modulo_Ferias = new Modulos.Form_Modulo_Ferias();
                modulo_Ferias.FormClosed += Modulo_Ferias_FormClosed;

                Program.AJUDA = 1;

                modulo_Ferias.label_id.Text = dgv_ferias.CurrentRow.Cells[0].Value.ToString();
                modulo_Ferias.text_investigador.Text = dgv_ferias.CurrentRow.Cells[1].Value.ToString();
                modulo_Ferias.text_data_inicial.Text = dgv_ferias.CurrentRow.Cells[2].Value.ToString();
                modulo_Ferias.text_data_final.Text = dgv_ferias.CurrentRow.Cells[3].Value.ToString();
                modulo_Ferias.text_estado_feria.Text = dgv_ferias.CurrentRow.Cells[4].Value.ToString();
                modulo_Ferias.text_descricao.Text = dgv_ferias.CurrentRow.Cells[5].Value.ToString();
                modulo_Ferias.text_Data_Registro.Text = dgv_ferias.CurrentRow.Cells[7].Value.ToString();


                modulo_Ferias.btn_salvar.Text = "Atualizar";
                modulo_Ferias.label5.Text = "Atualizar";
                modulo_Ferias.btn_salvar.FillColor = Color.SeaGreen;

                modulo_Ferias.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a féria que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_ferias.SelectedRows.Count > 0)
            {

                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir esta féria?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Feria = Convert.ToInt32(dgv_ferias.CurrentRow.Cells[0].Value.ToString());
                        c_Ferias.id_feria = id_Feria;
                        d_Ferias.eliminar_Ferias(c_Ferias);
                        guna2MessageDialog_Inform.Show($"A féria com a identificação {id_Feria}, foi exluída com sucesso!", "Exclusão bem-sucedida");
                        selecionar_Ferias();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar esta féria!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a féria que pretende eliminar e tente novamente!", "Erro de exclusão");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Ferias();
        }
        public void pesquisar_Ferias()
        {
            dgv_ferias.DataSource = p_Ferias.pesquisar_Ferias(text_pesquisar.Text);
        }
    }
}
