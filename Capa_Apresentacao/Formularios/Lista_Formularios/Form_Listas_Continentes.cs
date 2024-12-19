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
using Capa_Dominio;
using Capa_Comum.Entidades;
using Capa_Dominio.Dominio_Pesquisas;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Listas_Continentes : Form
    {
        #region Instanciar as classes e os métodos
        e_comum_continentes c_continentes = new e_comum_continentes();
        dominio_continentes d_continentes = new dominio_continentes();
        dominio_pesquisar_continentes p_continentes = new dominio_pesquisar_continentes();
        #endregion
        public Form_Listas_Continentes()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void Form_Listas_Continentes_Load(object sender, EventArgs e)
        {
            listar_continentes();
            titulos();
        }
        public void listar_continentes()
        {
            dgv_continentes.DataSource = d_continentes.selecionar_continentes();
        }
      
        private void btn_cadastrar_Click(object sender, EventArgs ei)
        {
            Form_Modulo_Continente formulario = new Form_Modulo_Continente();
            formulario.FormClosed += Formulario_FormClosed;
            formulario.Show();
            listar_continentes();
        }
        private void atualizar_continentes(object sender, FormClosedEventArgs e)
        {
            
            listar_continentes();
        }
        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {

            listar_continentes();
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_continentes.SelectedRows.Count > 0)
            {
                Form_Modulo_Continente formulario = new Form_Modulo_Continente();
                formulario.FormClosed += Formulario_FormClosed;

                Program.AJUDA = 1;
                formulario.label_id.Text = dgv_continentes.CurrentRow.Cells[0].Value.ToString();
                formulario.text_continentes.Text = dgv_continentes.CurrentRow.Cells[1].Value.ToString();
                formulario.text_data_registro.Text = dgv_continentes.CurrentRow.Cells[2].Value.ToString();

                formulario.btn_salvar.Text = "Atualizar";
                formulario.label_titulo.Text = "Atualizar continente";
                formulario.btn_salvar.FillColor = Color.SeaGreen;

                formulario.Show();

            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o continente que pretende atualizar e tente novamente!", "Alerta");
            }
        }

        private void dgv_continentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_continentes.SelectedRows.Count > 0)
            {
                Form_Modulo_Continente formulario = new Form_Modulo_Continente();
                formulario.FormClosed += Formulario_FormClosed;

                Program.AJUDA = 1;
                formulario.label_id.Text = dgv_continentes.CurrentRow.Cells[0].Value.ToString();
                formulario.text_continentes.Text = dgv_continentes.CurrentRow.Cells[1].Value.ToString();
                formulario.text_data_registro.Text = dgv_continentes.CurrentRow.Cells[2].Value.ToString();

                formulario.btn_salvar.Text = "Atualizar";
                formulario.label_titulo.Text = "Atualizar continente";
                formulario.btn_salvar.FillColor = Color.SeaGreen;

                formulario.Show();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o continente que pretende atualizar e tente novamente!", "Alerta");
            }
        }
        #region Métoddo para excluir os continentes
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_continentes.SelectedRows.Count > 0)
            {
                if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este continente?", "Mensagem de exclusão") == DialogResult.Yes)
                {
                    try
                    {
                        int _id = Convert.ToInt32(dgv_continentes.CurrentRow.Cells[0].Value.ToString());
                        c_continentes.id_continente = _id;
                        d_continentes.eliminar_continentes(c_continentes);
                        guna2MessageDialog_Inform.Show($"O continente com a identificação {_id}, foi eliminado com sucesso!", "Exclusão bem sucedida");
                        listar_continentes();
                    }
                    catch (System.Data.SqlClient.SqlException Ex)
                    {
                        if(Ex.Number == 547)
                            MessageDialog_Error.Show("Não é possível eliminar este continente, pois existem dados no sistema que estão associados à ele!",
                                "Erro ao eliminar o continente");
                    }
                    catch (Exception Ex)
                    {
                        MessageDialog_Error.Show("Não foi possível eliminar este continente!", Ex.Message);
                    }
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o continente que pretende eliminar e tente novamente!", "Alerta");
            }
        }
        #endregion

        #region Método para reescrever os titulos
        private void titulos()
        {
            dgv_continentes.Columns[0].HeaderText = "Id";
            dgv_continentes.Columns[1].HeaderText = "Nome";
            dgv_continentes.Columns[2].HeaderText = "Data de registro";
            dgv_continentes.Columns[3].HeaderText = "Data de atualização";
        }
        #endregion

        #region Método para pesquisar 
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_continente();
        }
        private void pesquisar_continente()
        {
            dgv_continentes.DataSource = p_continentes.pesquisar_continentes(text_pesquisar.Text);
        }
        #endregion
    }
}
