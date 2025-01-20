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
    public partial class Form_Listas_Vitimas : Form
    {
        dominio_vitimas d_Vitimas = new dominio_vitimas();
        e_comum_vitimas c_Vitimas = new e_comum_vitimas();
        dominio_pesquisar_vitimas p_Vitimas = new dominio_pesquisar_vitimas();
        public Form_Listas_Vitimas()
        {
            InitializeComponent();

            selecionar_Vitimas();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        public void selecionar_Vitimas()
        {
            try
            {
                dgv_vitimas.DataSource = d_Vitimas.selecionar_vitimas();
            }
            catch (Exception ex) 
            {
                MessageDialog_Error.Show(ex.Message);
            }
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Vitimas modulo_Vitimas = new Modulos.Form_Modulo_Vitimas(this);
            modulo_Vitimas.FormClosed += Modulo_Vitimas_FormClosed;
            modulo_Vitimas.ShowDialog();
        }
        private void Modulo_Vitimas_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Vitimas();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_vitimas.SelectedCells.Count > 0)
            {
                Modulos.Form_Modulo_Vitimas modulo_Vitimas = new Modulos.Form_Modulo_Vitimas(this);
                modulo_Vitimas.FormClosed += Modulo_Vitimas_FormClosed;

                modulo_Vitimas.label_id.Text = dgv_vitimas.CurrentRow.Cells[0].Value.ToString();
                modulo_Vitimas.text_primeiro_nome.Text = dgv_vitimas.CurrentRow.Cells[1].Value.ToString();
                modulo_Vitimas.text_nome_meio.Text = dgv_vitimas.CurrentRow.Cells[2].Value.ToString();
                modulo_Vitimas.text_ultimo_nome.Text = dgv_vitimas.CurrentRow.Cells[3].Value.ToString();
                modulo_Vitimas.text_data_nascimento.Text = dgv_vitimas.CurrentRow.Cells[4].Value.ToString();
                modulo_Vitimas.text_sexo.Text = dgv_vitimas.CurrentRow.Cells[6].Value.ToString();
                modulo_Vitimas.text_primerio_numero_telefone.Text = dgv_vitimas.CurrentRow.Cells[7].Value.ToString();
                modulo_Vitimas.text_segundo_numero_telefone.Text = dgv_vitimas.CurrentRow.Cells[8].Value.ToString();
                modulo_Vitimas.text_e_mail.Text = dgv_vitimas.CurrentRow.Cells[9].Value.ToString();
                modulo_Vitimas.text_curso.Text = dgv_vitimas.CurrentRow.Cells[10].Value.ToString();
                modulo_Vitimas.text_nivel_academico.Text = dgv_vitimas.CurrentRow.Cells[11].Value.ToString();
                modulo_Vitimas.text_caso.Text = dgv_vitimas.CurrentRow.Cells[12].Value.ToString();
                modulo_Vitimas.text_declaracao.Text = dgv_vitimas.CurrentRow.Cells[13].Value.ToString();
                modulo_Vitimas.text_continente.Text = dgv_vitimas.CurrentRow.Cells[14].Value.ToString();
                modulo_Vitimas.text_pais.Text = dgv_vitimas.CurrentRow.Cells[15].Value.ToString();
                modulo_Vitimas.text_provincias.Text = dgv_vitimas.CurrentRow.Cells[16].Value.ToString();
                modulo_Vitimas.text_municipio.Text = dgv_vitimas.CurrentRow.Cells[17].Value.ToString();
                modulo_Vitimas.text_bairro_rua.Text = dgv_vitimas.CurrentRow.Cells[18].Value.ToString();
               
                modulo_Vitimas.label5.Text = "Atualizar";
                modulo_Vitimas.btn_salvar.Text = "Atualizar";
                modulo_Vitimas.btn_salvar.FillColor = Color.SeaGreen;

                modulo_Vitimas.ShowDialog();
                selecionar_Vitimas();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a testemunha que pretende atualizar e tente novamente!", "Falha");
            }
        }
        private void dgv_vitimas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_vitimas.SelectedCells.Count > 0)
            {
                Modulos.Form_Modulo_Vitimas modulo_Vitimas = new Modulos.Form_Modulo_Vitimas(this);
                modulo_Vitimas.FormClosed += Modulo_Vitimas_FormClosed;

                modulo_Vitimas.label_id.Text = dgv_vitimas.CurrentRow.Cells[0].Value.ToString();
                modulo_Vitimas.text_primeiro_nome.Text = dgv_vitimas.CurrentRow.Cells[1].Value.ToString();
                modulo_Vitimas.text_nome_meio.Text = dgv_vitimas.CurrentRow.Cells[2].Value.ToString();
                modulo_Vitimas.text_ultimo_nome.Text = dgv_vitimas.CurrentRow.Cells[3].Value.ToString();
                modulo_Vitimas.text_data_nascimento.Text = dgv_vitimas.CurrentRow.Cells[4].Value.ToString();
                modulo_Vitimas.text_sexo.Text = dgv_vitimas.CurrentRow.Cells[6].Value.ToString();
                modulo_Vitimas.text_primerio_numero_telefone.Text = dgv_vitimas.CurrentRow.Cells[7].Value.ToString();
                modulo_Vitimas.text_segundo_numero_telefone.Text = dgv_vitimas.CurrentRow.Cells[8].Value.ToString();
                modulo_Vitimas.text_e_mail.Text = dgv_vitimas.CurrentRow.Cells[9].Value.ToString();
                modulo_Vitimas.text_curso.Text = dgv_vitimas.CurrentRow.Cells[10].Value.ToString();
                modulo_Vitimas.text_nivel_academico.Text = dgv_vitimas.CurrentRow.Cells[11].Value.ToString();
                modulo_Vitimas.text_caso.Text = dgv_vitimas.CurrentRow.Cells[12].Value.ToString();
                modulo_Vitimas.text_declaracao.Text = dgv_vitimas.CurrentRow.Cells[13].Value.ToString();
                modulo_Vitimas.text_continente.Text = dgv_vitimas.CurrentRow.Cells[14].Value.ToString();
                modulo_Vitimas.text_pais.Text = dgv_vitimas.CurrentRow.Cells[15].Value.ToString();
                modulo_Vitimas.text_provincias.Text = dgv_vitimas.CurrentRow.Cells[16].Value.ToString();
                modulo_Vitimas.text_municipio.Text = dgv_vitimas.CurrentRow.Cells[17].Value.ToString();
                modulo_Vitimas.text_bairro_rua.Text = dgv_vitimas.CurrentRow.Cells[18].Value.ToString();

                modulo_Vitimas.label5.Text = "Atualizar vítima";
                modulo_Vitimas.btn_salvar.Text = "Atualizar";
                modulo_Vitimas.btn_salvar.FillColor = Color.SeaGreen;

                modulo_Vitimas.ShowDialog();
                selecionar_Vitimas();
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a testemunha que pretende atualizar e tente novamente!", "Falha");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_vitimas.SelectedRows.Count > 0)
            {
                try
                {
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de excluir esta vítima?", "Mensagem de exclusão") == DialogResult.Yes)
                    {
                        int id_Vitima = Convert.ToInt32(dgv_vitimas.CurrentRow.Cells[0].Value.ToString());
                        c_Vitimas.id_vitima = id_Vitima;
                        d_Vitimas.eliminar_vitimas(c_Vitimas);

                        guna2MessageDialog_Inform.Show($"A vítima com a identificação  foi excluida com sucesso!", "Exclusão bem sucedida");
                        selecionar_Vitimas();
                    }
                }
                //catch (System.Data.SqlClient.SqlException Ex)
                //{
                //    MessageDialog_Error.Show(Ex.Message);
                //}
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível eliminar esta vítima!", Ex.Message);
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione a vítima que pretende eliminar e tente novamente!", "Falha");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Vitimas();
        }
        private void pesquisar_Vitimas()
        {
            dgv_vitimas.DataSource = p_Vitimas.pesquisar_Vitimas(text_pesquisar.Text);
        }
    }
}
