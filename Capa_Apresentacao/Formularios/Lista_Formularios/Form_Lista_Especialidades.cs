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
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Especialidades : Form
    {
        e_comum_especialidades c_Especialidades = new e_comum_especialidades();
        dominio_especialidades d_Especialidades = new dominio_especialidades();
        dominio_pesquisar_especialidades p_Especialidades = new dominio_pesquisar_especialidades();
        public Form_Lista_Especialidades()
        {
            InitializeComponent();
            listar_Especialidades();
        }
        private void listar_Especialidades()
        {
            dgv_especialidades.DataSource = d_Especialidades.selecionar_Especialidades();
        }
        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {

            Formularios.Modulos.Form_Modulo_Especialidades especialidades = new Modulos.Form_Modulo_Especialidades();
            especialidades.FormClosed += Especialidades_FormClosed;
            especialidades.ShowDialog();
        }
        private void Especialidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Especialidades();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_especialidades.SelectedRows.Count > 0)
            {
                Formularios.Modulos.Form_Modulo_Especialidades especialidades = new Modulos.Form_Modulo_Especialidades();
                especialidades.FormClosed += Especialidades_FormClosed;
                Program.AJUDA = 1;

                especialidades.label_id.Text = dgv_especialidades.CurrentRow.Cells[0].Value.ToString();
                especialidades.text_curso.Text = dgv_especialidades.CurrentRow.Cells[1].Value.ToString();
                especialidades.text_Especialidades.Text = dgv_especialidades.CurrentRow.Cells[2].Value.ToString();
                especialidades.text_Data_Registro.Text = dgv_especialidades.CurrentRow.Cells[3].Value.ToString();

                especialidades.label5.Text = "Atualizar especialidade";
                especialidades.btn_Atualizar.Visible = true;
                especialidades.btn_salvar.Visible = false;

                especialidades.ShowDialog();
                listar_Especialidades();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a especialidade que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_especialidades.SelectedRows.Count > 0)
            {
                try
                {
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar esta especialidade?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_especialidade = Convert.ToInt32(dgv_especialidades.CurrentRow.Cells[0].Value.ToString());
                        c_Especialidades.id_especialidade = id_especialidade;
                        d_Especialidades.eliminar_Especialidades(c_Especialidades);
                        guna2MessageDialog_Inform.Show($"A especialidade com o identificador {id_especialidade} foi eliminada com sucesso!", "Exclusão bem sucedida");
                        listar_Especialidades();
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
                    MessageDialog_Error.Show("Não foi possível eliminar esta especialidade!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a especialidade que pretende atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Especialidades();
        }
        private void pesquisar_Especialidades()
        {
            try
            {
                 dgv_especialidades.DataSource = p_Especialidades.pesquisar_Especialidades(text_pesquisar.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Não foi possível pesquisar esta especialidade.", Ex.Message);
            }
        }
    }
}
