using Capa_Apresentacao.Formularios.Modulos;
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
using Capa_Dominio.Dominio_Pesquisas;
using Capa_Dominio;


namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Listas_Municipios : Form
    {
        #region Instanciação de classes e métodos
        e_comum_municipios c_Municipios = new e_comum_municipios();
        dominio_municipios d_Municipios = new dominio_municipios();
        dominio_pesquisar_municipios p_Municipios = new dominio_pesquisar_municipios();
        #endregion
        public Form_Listas_Municipios()
        {
            InitializeComponent();
            listar_municipios();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        #region Método para listar os municípios
        private void listar_municipios()
        {
            dgv_municipios.DataSource = d_Municipios.selecionar_municipios();
        }
        #endregion
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Municipios formulario = new Form_Modulo_Municipios();
            formulario.FormClosed += Formulario_FormClosed;
            formulario.Show();
            listar_municipios();
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_municipios();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_municipios.SelectedRows.Count > 0)
            {
                Form_Modulo_Municipios formulario = new Form_Modulo_Municipios();
                formulario.FormClosed += Formulario_FormClosed;
                Program.AJUDA = 1;

                formulario.label_id.Text = dgv_municipios.CurrentRow.Cells[0].Value.ToString();
                formulario.text_provincias.Text = dgv_municipios.CurrentRow.Cells[1].Value.ToString();
                formulario.text_municipio.Text = dgv_municipios.CurrentRow.Cells[2].Value.ToString();
                formulario.text_data_registro.Text = dgv_municipios.CurrentRow.Cells[3].Value.ToString();

                formulario.btn_salvar.Visible = false;
                formulario.btn_Atualizar.Visible = true;
                formulario.label5.Text = "Atualizar município";
               
                formulario.Show();
                listar_municipios();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o município que pretendes atualiazar e tente novamente!", "Erro de atualização");
            }
        }
        private void dgv_municipios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_municipios.SelectedRows.Count > 0)
            {
                Form_Modulo_Municipios formulario = new Form_Modulo_Municipios();
                formulario.FormClosed += Formulario_FormClosed;
                Program.AJUDA = 1;

                formulario.label_id.Text = dgv_municipios.CurrentRow.Cells[0].Value.ToString();
                formulario.text_provincias.Text = dgv_municipios.CurrentRow.Cells[1].Value.ToString();
                formulario.text_municipio.Text = dgv_municipios.CurrentRow.Cells[2].Value.ToString();
                formulario.text_data_registro.Text = dgv_municipios.CurrentRow.Cells[3].Value.ToString();
              
                formulario.btn_salvar.Visible = false;
                formulario.btn_Atualizar.Visible = true;
                formulario.label5.Text = "Atualizar município";
                
                formulario.Show();
                listar_municipios();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o município que pretendes atualiazar e tente novamente!", "Erro de atualização");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_municipios.SelectedRows.Count > 0)
            {
                try
                {
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este município?","Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgv_municipios.CurrentRow.Cells[0].Value.ToString());
                        c_Municipios.id_municipio = id;
                        d_Municipios.eliminar_municipios(c_Municipios);
                        guna2MessageDialog_Inform.Show($"O município com a identificação {id}, foi eliminado com sucesso!", "Exclusão bem sucedida");
                        listar_municipios();
                    }
                }
                catch(System.Data.SqlClient.SqlException Ex)
                {
                    if (Ex.Number == 457)
                        MessageDialog_Error.Show("Não é possível eliminar este município, pois existem - no sistema -, dados que estão associados à ele!", "Alerta");
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este municipio", Ex.Message);
                }
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_municipios();
        }
        private void pesquisar_municipios()
        {
            dgv_municipios.DataSource = p_Municipios.pesquisar_Municipios(text_pesquisar.Text);
        }
    }
}
