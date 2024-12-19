using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos;
using Capa_Dominio.Dominio_Pesquisas;
using Capa_Dominio;
using Capa_Comum.Entidades;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Faltas : Form
    {
        e_comum_faltas c_Faltas = new e_comum_faltas();
        dominio_faltas d_Faltas = new dominio_faltas();
        dominio_pesquisar_faltas p_Pesquisar = new dominio_pesquisar_faltas();  
        public Form_Lista_Faltas()
        {
            InitializeComponent();
            selecionar_Faltas();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Faltas()
        {
            dgv_faltas.DataSource = d_Faltas.selecionar_Faltas();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Faltas form_Modulo_Faltas = new Form_Modulo_Faltas();
            form_Modulo_Faltas.FormClosed += Form_Modulo_Faltas_FormClosed;
            form_Modulo_Faltas.ShowDialog();
        }

        private void Form_Modulo_Faltas_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Faltas();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_faltas.SelectedRows.Count > 0)
            {
                Form_Modulo_Faltas form_Modulo_Faltas = new Form_Modulo_Faltas();
                form_Modulo_Faltas.FormClosed += Form_Modulo_Faltas_FormClosed;

                Program.AJUDA = 1;
                form_Modulo_Faltas.label_id.Text = dgv_faltas.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Faltas.text_investigador.Text = dgv_faltas.CurrentRow.Cells[1].Value.ToString();
                form_Modulo_Faltas.text_data_falta.Text = dgv_faltas.CurrentRow.Cells[2].Value.ToString();
                form_Modulo_Faltas.text_estado_falta.Text = dgv_faltas.CurrentRow.Cells[3].Value.ToString();
                form_Modulo_Faltas.text_motivos.Text = dgv_faltas.CurrentRow.Cells[4].Value.ToString();
                form_Modulo_Faltas.text_Data_Registro.Text = dgv_faltas.CurrentRow.Cells[6].Value.ToString();

                form_Modulo_Faltas.btn_salvar.Text = "Atualizar";
                form_Modulo_Faltas.label5.Text = "Atualizar";
                form_Modulo_Faltas.btn_salvar.FillColor = Color.SeaGreen;

                form_Modulo_Faltas.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a falta que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }
        private void dgv_faltas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_faltas.SelectedRows.Count > 0)
            {
                Form_Modulo_Faltas form_Modulo_Faltas = new Form_Modulo_Faltas();
                form_Modulo_Faltas.FormClosed += Form_Modulo_Faltas_FormClosed;

                Program.AJUDA = 1;
                form_Modulo_Faltas.label_id.Text = dgv_faltas.CurrentRow.Cells[0].Value.ToString();
                form_Modulo_Faltas.text_investigador.Text = dgv_faltas.CurrentRow.Cells[1].Value.ToString();
                form_Modulo_Faltas.text_data_falta.Text = dgv_faltas.CurrentRow.Cells[2].Value.ToString();
                form_Modulo_Faltas.text_estado_falta.Text = dgv_faltas.CurrentRow.Cells[3].Value.ToString();
                form_Modulo_Faltas.text_motivos.Text = dgv_faltas.CurrentRow.Cells[4].Value.ToString();
                form_Modulo_Faltas.text_Data_Registro.Text = dgv_faltas.CurrentRow.Cells[6].Value.ToString();

                form_Modulo_Faltas.btn_salvar.Text = "Atualizar";
                form_Modulo_Faltas.label5.Text = "Atualizar";
                form_Modulo_Faltas.btn_salvar.FillColor = Color.SeaGreen;

                form_Modulo_Faltas.ShowDialog();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a falta que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_faltas.SelectedRows.Count > 0)
            {
                try
                {
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de excluir esta falta?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Faltas = Convert.ToInt32(dgv_faltas.CurrentRow.Cells[0].Value.ToString());
                        c_Faltas.id_falta = id_Faltas;
                        d_Faltas.eliminar_Faltas(c_Faltas);
                        guna2MessageDialog_Inform.Show($"A falta com a identificação {id_Faltas}, foi exluída com sucesso!", "Exclusão bem-sucedida");
                        selecionar_Faltas();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar esta falta!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a falta que pretende eliminar e tente novamente!", "Erro de exclusão");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Faltas();
        }
        private void pesquisar_Faltas()
        {
            dgv_faltas.DataSource = p_Pesquisar.pesquisar_Faltas(text_pesquisar.Text);
        }
    }
}
