using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Apresentacao.Formularios.Modulos;
using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Testemunhas : Form
    {
        e_comum_testemunhas c_Testemunhas = new e_comum_testemunhas();
        dominio_testemunhas d_Testemunhas = new dominio_testemunhas();
        dominio_pesquisar_testemunhas p_Testemunhas = new dominio_pesquisar_testemunhas(); 
        public Form_Lista_Testemunhas()
        {
            InitializeComponent();

            listar_Testemunhas();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void listar_Testemunhas()
        {
            dgv_testemunhas.DataSource = d_Testemunhas.selecionar_testemunhas();
        }
       
        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            Form_Modulo_Testemunhas testemunhas = new Form_Modulo_Testemunhas();
            testemunhas.FormClosed += Testemunhas_FormClosed;
            testemunhas.ShowDialog();
        }

        private void Testemunhas_FormClosed(object sender, FormClosedEventArgs e)
        {
           listar_Testemunhas();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_testemunhas.SelectedCells.Count > 0)
            {
                Form_Modulo_Testemunhas testemunhas = new Form_Modulo_Testemunhas();
                testemunhas.FormClosed += Testemunhas_FormClosed;


                testemunhas.label_id.Text = dgv_testemunhas.CurrentRow.Cells[0].Value.ToString();
                testemunhas.text_primeiro_nome.Text = dgv_testemunhas.CurrentRow.Cells[1].Value.ToString();
                testemunhas.text_nome_meio.Text = dgv_testemunhas.CurrentRow.Cells[2].Value.ToString();
                testemunhas.text_ultimo_nome.Text = dgv_testemunhas.CurrentRow.Cells[3].Value.ToString();
                testemunhas.text_data_nascimento.Text = dgv_testemunhas.CurrentRow.Cells[4].Value.ToString();
                testemunhas.text_sexo.Text = dgv_testemunhas.CurrentRow.Cells[6].Value.ToString();
                testemunhas.text_primerio_numero_telefone.Text = dgv_testemunhas.CurrentRow.Cells[7].Value.ToString();
                testemunhas.text_segundo_numero_telefone.Text = dgv_testemunhas.CurrentRow.Cells[8].Value.ToString();
                testemunhas.text_e_mail.Text = dgv_testemunhas.CurrentRow.Cells[9].Value.ToString();
                testemunhas.text_curso.Text = dgv_testemunhas.CurrentRow.Cells[10].Value.ToString();
                testemunhas.text_nivel_academico.Text = dgv_testemunhas.CurrentRow.Cells[11].Value.ToString();
                testemunhas.text_caso.Text = dgv_testemunhas.CurrentRow.Cells[12].Value.ToString();
                testemunhas.text_declaracao.Text = dgv_testemunhas.CurrentRow.Cells[13].Value.ToString();
                testemunhas.text_continente.Text = dgv_testemunhas.CurrentRow.Cells[14].Value.ToString();
                testemunhas.text_pais.Text = dgv_testemunhas.CurrentRow.Cells[15].Value.ToString();
                testemunhas.text_provincias.Text = dgv_testemunhas.CurrentRow.Cells[16].Value.ToString();
                testemunhas.text_municipio.Text = dgv_testemunhas.CurrentRow.Cells[17].Value.ToString();
                testemunhas.text_bairro_rua.Text = dgv_testemunhas.CurrentRow.Cells[18].Value.ToString();
                testemunhas.text_data_registro.Text = dgv_testemunhas.CurrentRow.Cells[20].Value.ToString();

                testemunhas.label5.Text = "Atualizar testemunha";
                testemunhas.btn_salvar.Visible = false;
                testemunhas.btn_Atualizar.Visible = true;

                testemunhas.ShowDialog();
                listar_Testemunhas();

            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a testemunha que pretende atualizar e tente novamente!", "Falha");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_testemunhas.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar esta testemunha?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Testemunha = Convert.ToInt32(dgv_testemunhas.CurrentRow.Cells[0].Value.ToString());
                        c_Testemunhas.id_testemunha = id_Testemunha;
                        d_Testemunhas.eliminar_testemunhas(c_Testemunhas);
                        guna2MessageDialog_Inform.Show($"A testemunha com a identificação {id_Testemunha} foi excluida com sucesso!", "Exclusão bem sucedida");
                        listar_Testemunhas();
                    }
                }
                catch (SqlException Ex)
                {
                    if (Ex.Number == 547)
                        MessageDialog_Error.Show("Não é possível eliminar esta testemunha, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão");
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar esta testemunha!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a testemunha que pretende eliminar e tente novamente!", "Falha");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_testemunhas();
        }
        private void pesquisar_testemunhas()
        {
            dgv_testemunhas.DataSource = p_Testemunhas.pesquisar_Testemunha(text_pesquisar.Text);
        }
    }
}
