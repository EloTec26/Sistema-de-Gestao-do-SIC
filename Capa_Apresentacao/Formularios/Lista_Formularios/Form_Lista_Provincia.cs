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
    public partial class Form_Lista_Provincia : Form
    {
        public Form_Lista_Provincia()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void Form_Lista_Provincia_Load(object sender, EventArgs e)
        {
            carregar_provincias();
        }
        #region Instanciação de classes
        dominio_provincias d_provincias = new dominio_provincias();
        e_comum_provincias c_provincias = new e_comum_provincias();
        dominio_pesquisar_provincias p_provincias = new dominio_pesquisar_provincias();
        #endregion
        #region Método para carregar as provincias
        public void carregar_provincias()
        {
            dgv_provincia.DataSource = d_provincias.selecionar_provincias();
        }
        #endregion
     
        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Provincia formulario = new Modulos.Form_Modulo_Provincia();
            formulario.FormClosed += Formulario_FormClosed;
            formulario.ShowDialog();
            carregar_provincias();
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            carregar_provincias();
        }

        private void text_provincia_TextChanged(object sender, EventArgs e)
        {
            pesquisar_provincias();
        }
        private void pesquisar_provincias()
        {
            dgv_provincia.DataSource = p_provincias.pesquisar_provincias(text_provincia.Text);
        }
        #region Método para atualizar as províncias
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_provincia.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Provincia formulario = new Modulos.Form_Modulo_Provincia();

                formulario.label_id.Text = dgv_provincia.CurrentRow.Cells[0].Value.ToString();
                formulario.text_paises.Text = dgv_provincia.CurrentRow.Cells[1].Value.ToString();
                formulario.text_provincia.Text = dgv_provincia.CurrentRow.Cells[2].Value.ToString();

                formulario.btn_salvar.FillColor = Color.SeaGreen;
                formulario.label5.Text = "Atualizar província";
                formulario.btn_salvar.Text = "Atualizar";

                formulario.FormClosed += Formulario_FormClosed;
                formulario.ShowDialog();
                carregar_provincias();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a província que pretendes atualizar e tente novamente!", "Erro de atualização");
            }
        }

        private void dgv_provincia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_provincia.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Provincia formulario = new Modulos.Form_Modulo_Provincia();

                formulario.label_id.Text = dgv_provincia.CurrentRow.Cells[0].Value.ToString();
                formulario.text_paises.Text = dgv_provincia.CurrentRow.Cells[1].Value.ToString();
                formulario.text_provincia.Text = dgv_provincia.CurrentRow.Cells[2].Value.ToString();
                formulario.btn_salvar.FillColor = Color.SeaGreen;
                formulario.label5.Text = "Atualizar província";
                formulario.btn_salvar.Text = "Atualizar";

                formulario.FormClosed += Formulario_FormClosed;
                formulario.ShowDialog();
                carregar_provincias();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a província que pretendes atualizar e tente novamente!", "Erro de atualização");
            }
        }
        #endregion
        #region Método para eliminar as províncias
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_provincia.SelectedRows.Count > 0)
            {
                try
                {
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar esta província?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int _id = Convert.ToInt32(dgv_provincia.CurrentRow.Cells[0].Value.ToString());
                        c_provincias.id_provincia = _id;
                        d_provincias.eliminar_provincias(c_provincias);
                        guna2MessageDialog_Inform.Show($"A província com a identificação {_id} foi eliminada com sucesso!", "Exclusão bem sucedida");
                        carregar_provincias();
                    }
                }
                catch (System.Data.SqlClient.SqlException Ex)
                {
                    if(Ex.Number == 457 || Ex.Number == 547)
                    {
                        MessageDialog_Error.Show("Não é possível eliminar esta província, pois existem - no sistema-, dados que estão vinculados  à ela.", "Alerta");
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar esta província", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a província que pretende eliminar e tente novamente!", "Erro de exclusão");
            }
        }
        #endregion
    }
}
