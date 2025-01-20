using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Capa_Comum.Entidades;
using Capa_Apresentacao.Formularios.Modulos;
using Capa_Dominio.Dominio_Pesquisas;
using System.Data.SqlClient;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Usuarios : Form
    {
        e_comum_usuarios c_Usuarios = new e_comum_usuarios();
        dominio_usuarios d_Usuarios = new dominio_usuarios();
        dominio_pesquisar_usuarios p_Usuarios = new dominio_pesquisar_usuarios();
        public Form_Lista_Usuarios()
        {
            InitializeComponent();
           
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void Form_Lista_Usuarios_Load(object sender, EventArgs e)
        {
            listar_Usuarios();
            
            dgv_usuarios.Columns[9].Visible = false;
        }
        private void listar_Usuarios()
        {
            dgv_usuarios.DataSource = d_Usuarios.selecionar_usuarios();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Usuarios usuarios = new Form_Modulo_Usuarios();
            usuarios.FormClosed += Usuarios_FormClosed;
            usuarios.ShowDialog();
            listar_Usuarios();
        }

        private void Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Usuarios();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_usuarios.SelectedCells.Count > 0)
            {
                Form_Modulo_Usuarios usuarios = new Form_Modulo_Usuarios();
                usuarios.FormClosed += Usuarios_FormClosed;

                usuarios.label_id.Text = dgv_usuarios.CurrentRow.Cells[0].Value.ToString();
                usuarios.text_primeiro_nome.Text = dgv_usuarios.CurrentRow.Cells[1].Value.ToString();
                usuarios.text_nome_meio.Text = dgv_usuarios.CurrentRow.Cells[2].Value.ToString();
                usuarios.text_ultimo_nome.Text = dgv_usuarios.CurrentRow.Cells[3].Value.ToString();
                usuarios.text_numero_bi.Text = dgv_usuarios.CurrentRow.Cells[4].Value.ToString();
                usuarios.text_sexo.Text = dgv_usuarios.CurrentRow.Cells[5].Value.ToString();
                usuarios.text_primerio_numero_telefone.Text = dgv_usuarios.CurrentRow.Cells[6].Value.ToString();
               usuarios.text_e_mail.Text = dgv_usuarios.CurrentRow.Cells[7].Value.ToString();
                usuarios.text_tipo_usuario.Text = dgv_usuarios.CurrentRow.Cells[8].Value.ToString();
                usuarios.text_palavra_passe.Text = dgv_usuarios.CurrentRow.Cells[9].Value.ToString();
                
                usuarios.label5.Text = "Atualizar usuário";
                usuarios.btn_salvar.Visible = false;
                usuarios.btn_Atualizar.Visible = true;
                
                usuarios.ShowDialog();
                listar_Usuarios();
               
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o usuário que pretende atualizar e tente novamente!", "Falha");
            }
        }
        private void dgv_usuarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_usuarios.SelectedCells.Count > 0)
            {
                Form_Modulo_Usuarios usuarios = new Form_Modulo_Usuarios();
                usuarios.FormClosed += Usuarios_FormClosed;

                usuarios.label_id.Text = dgv_usuarios.CurrentRow.Cells[0].Value.ToString();
                usuarios.text_primeiro_nome.Text = dgv_usuarios.CurrentRow.Cells[1].Value.ToString();
                usuarios.text_nome_meio.Text = dgv_usuarios.CurrentRow.Cells[2].Value.ToString();
                usuarios.text_ultimo_nome.Text = dgv_usuarios.CurrentRow.Cells[3].Value.ToString();
                usuarios.text_numero_bi.Text = dgv_usuarios.CurrentRow.Cells[4].Value.ToString();
                usuarios.text_sexo.Text = dgv_usuarios.CurrentRow.Cells[5].Value.ToString();
                usuarios.text_primerio_numero_telefone.Text = dgv_usuarios.CurrentRow.Cells[6].Value.ToString();
                usuarios.text_e_mail.Text = dgv_usuarios.CurrentRow.Cells[7].Value.ToString();
                usuarios.text_tipo_usuario.Text = dgv_usuarios.CurrentRow.Cells[8].Value.ToString();
                usuarios.text_palavra_passe.Text = dgv_usuarios.CurrentRow.Cells[9].Value.ToString();
               

                usuarios.label5.Text = "Atualizar usuário";
                usuarios.btn_salvar.Visible = false;
                usuarios.btn_Atualizar.Visible = true;

                usuarios.ShowDialog();
                listar_Usuarios();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o usuário que pretende atualizar e tente novamente!", "Falha");
            }
        }
       
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_usuarios.SelectedRows.Count > 0)
            {
                try
                {
                    if(guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este usuário?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Usuario = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value.ToString());
                        c_Usuarios.id_usuario = id_Usuario;
                        d_Usuarios.eliminar_usuarios(c_Usuarios);
                        guna2MessageDialog_Inform.Show($"O usuário com o identificador {id_Usuario} foi eliminado com sucesso!", "Exclusão bem sucedida");
                        listar_Usuarios();
                    }
                }
                //catch(SqlException Ex)
                //{
                //  MessageDialog_Error.Show(Ex.Message);
                //}
                catch (Exception Ex)
                {

                    MessageDialog_Error.Show("Não foi possível eliminar este usuário!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o usuário que pretende eliminar e tente novamente!", "Falha");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Usuarios();
        }
        private void pesquisar_Usuarios()
        {
            dgv_usuarios.DataSource = p_Usuarios.pesquisar_Usuarios(text_pesquisar.Text);
        }
    }
}
