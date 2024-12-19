using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------
using Capa_Comum.Entidades;
using Capa_Dominio;
using Capa_Dominio.Dominio_Pesquisas;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Suspeitos : Form
    {
        dominio_suspeitos d_Suspeito = new dominio_suspeitos();
        e_comum_suspeitos c_Suspeito = new e_comum_suspeitos();
        dominio_pesquisar_suspeitos p_Supeitos = new dominio_pesquisar_suspeitos();
        public Form_Lista_Suspeitos()
        {
            InitializeComponent();

            selecionar_Suspeitos();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Suspeitos()
        {
            dgv_suspeitos.DataSource = d_Suspeito.selecionar_suspeitos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Suspeitos modulo_Suspeitos = new Modulos.Form_Modulo_Suspeitos();
            modulo_Suspeitos.FormClosed += Modulo_Suspeitos_FormClosed;
            modulo_Suspeitos.ShowDialog();
        }

        private void Modulo_Suspeitos_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Suspeitos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_suspeitos.SelectedCells.Count > 0)
            {
                Modulos.Form_Modulo_Suspeitos modulo_Suspeitos = new Modulos.Form_Modulo_Suspeitos();
                modulo_Suspeitos.FormClosed += Modulo_Suspeitos_FormClosed;

                Program.AJUDA = 1;

                modulo_Suspeitos.label_id.Text = dgv_suspeitos.CurrentRow.Cells[0].Value.ToString();
                modulo_Suspeitos.text_primeiro_nome.Text = dgv_suspeitos.CurrentRow.Cells[1].Value.ToString();
                modulo_Suspeitos.text_nome_meio.Text = dgv_suspeitos.CurrentRow.Cells[2].Value.ToString();
                modulo_Suspeitos.text_ultimo_nome.Text = dgv_suspeitos.CurrentRow.Cells[3].Value.ToString();
                modulo_Suspeitos.text_data_nascimento.Text = dgv_suspeitos.CurrentRow.Cells[4].Value.ToString();
                modulo_Suspeitos.text_sexo.Text = dgv_suspeitos.CurrentRow.Cells[6].Value.ToString();
                modulo_Suspeitos.text_primerio_numero_telefone.Text = dgv_suspeitos.CurrentRow.Cells[7].Value.ToString();
                modulo_Suspeitos.text_segundo_numero_telefone.Text = dgv_suspeitos.CurrentRow.Cells[8].Value.ToString();
                modulo_Suspeitos.text_e_mail.Text = dgv_suspeitos.CurrentRow.Cells[9].Value.ToString();
                modulo_Suspeitos.text_curso.Text = dgv_suspeitos.CurrentRow.Cells[10].Value.ToString();
                modulo_Suspeitos.text_nivel_academico.Text = dgv_suspeitos.CurrentRow.Cells[11].Value.ToString();
                modulo_Suspeitos.text_caso.Text = dgv_suspeitos.CurrentRow.Cells[12].Value.ToString();
                modulo_Suspeitos.text_declaracao.Text = dgv_suspeitos.CurrentRow.Cells[13].Value.ToString();
                modulo_Suspeitos.text_continente.Text = dgv_suspeitos.CurrentRow.Cells[14].Value.ToString();
                modulo_Suspeitos.text_pais.Text = dgv_suspeitos.CurrentRow.Cells[15].Value.ToString();
                modulo_Suspeitos.text_provincias.Text = dgv_suspeitos.CurrentRow.Cells[16].Value.ToString();
                modulo_Suspeitos.text_municipio.Text = dgv_suspeitos.CurrentRow.Cells[17].Value.ToString();
                modulo_Suspeitos.text_bairro_rua.Text = dgv_suspeitos.CurrentRow.Cells[18].Value.ToString();
                modulo_Suspeitos.text_data_registro.Text = dgv_suspeitos.CurrentRow.Cells[20].Value.ToString();

                modulo_Suspeitos.label5.Text = "Atualizar suspeito";
                modulo_Suspeitos.btn_salvar.Visible = false;
                modulo_Suspeitos.btn_Atualizar.Visible = true;
                modulo_Suspeitos.ShowDialog();
                selecionar_Suspeitos();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a testemunha que pretende atualizar e tente novamente!", "Falha");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_suspeitos.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir este suspeito?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Suspeito = Convert.ToInt32(dgv_suspeitos.CurrentRow.Cells[0].Value.ToString());
                        c_Suspeito.id_suspeito = id_Suspeito;
                        d_Suspeito.eliminar_suspeitos(c_Suspeito);

                        guna2MessageDialog_Inform.Show($"O suspeito com a identificação {id_Suspeito}, foi excluido com sucesso!", "Exclusão bem sucedida");
                        selecionar_Suspeitos();
                    }
                }
                catch (System.Data.SqlClient.SqlException Ex)
                {
                    if (Ex.Number == 547)
                        MessageDialog_Error.Show("Não é possível eliminar este suspeito, pois existem - no sistema - dados que estão vinculados à ele!", "Erro de exclusão");
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar este suspeito!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o suspeito que pretende eliminar e tente novamente!", "Falha");
            }
        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesqusar_Suspeitos();
        }
        public void pesqusar_Suspeitos()
        {
            dgv_suspeitos.DataSource = p_Supeitos.pesquisar_Suspeito(text_pesquisar.Text);
        }
    }
}
