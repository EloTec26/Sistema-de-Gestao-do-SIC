using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio.Dominio_Pesquisas;
using Capa_Comum.Entidades;
using Capa_Dominio;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Investigadores : Form
    {
        e_comum_investigadores c_Investigadores = new e_comum_investigadores();
        dominio_investigadores d_Investigadores = new dominio_investigadores();
        dominio_pesquisar_investigadores p_Investigadores = new dominio_pesquisar_investigadores();
        public Form_Lista_Investigadores()
        {
            InitializeComponent();
            listar_Investigadores();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void listar_Investigadores()
        {
            dgv_investigadores.DataSource = d_Investigadores.selecionar_investigadores();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modulos.Form_Modulo_Investigadores investigadores = new Modulos.Form_Modulo_Investigadores();
            investigadores.FormClosed += Investigadores_FormClosed;
            investigadores.ShowDialog();
            listar_Investigadores();
        }

        private void Investigadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar_Investigadores();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_investigadores.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Investigadores investigadores = new Modulos.Form_Modulo_Investigadores();
                investigadores.FormClosed += Investigadores_FormClosed;

                investigadores.label_id.Text = dgv_investigadores.CurrentRow.Cells[0].Value.ToString();
                investigadores.text_primeiro_nome.Text = dgv_investigadores.CurrentRow.Cells[1].Value.ToString();
                investigadores.text_nome_meio.Text = dgv_investigadores.CurrentRow.Cells[2].Value.ToString();
                investigadores.text_ultimo_nome.Text = dgv_investigadores.CurrentRow.Cells[3].Value.ToString();
                investigadores.text_data_nascimento.Text = dgv_investigadores.CurrentRow.Cells[4].Value.ToString();
                investigadores.text_sexo.Text = dgv_investigadores.CurrentRow.Cells[6].Value.ToString();
                investigadores.text_numero_bi.Text = dgv_investigadores.CurrentRow.Cells[7].Value.ToString();
                investigadores.text_primerio_numero_telefone.Text = dgv_investigadores.CurrentRow.Cells[8].Value.ToString();
                investigadores.text_segundo_numero_telefone.Text = dgv_investigadores.CurrentRow.Cells[9].Value.ToString();
                investigadores.text_e_mail.Text = dgv_investigadores.CurrentRow.Cells[10].Value.ToString();
                investigadores.text_nivel_academico.Text = dgv_investigadores.CurrentRow.Cells[11].Value.ToString();
                investigadores.text_curso.Text = dgv_investigadores.CurrentRow.Cells[12].Value.ToString();
                investigadores.text_especialidades.Text = dgv_investigadores.CurrentRow.Cells[13].Value.ToString();
                investigadores.text_patente.Text = dgv_investigadores.CurrentRow.Cells[14].Value.ToString();
                investigadores.text_data_inicio_contrato.Text = dgv_investigadores.CurrentRow.Cells[15].Value.ToString();
                investigadores.text_data_fim_contrato.Text = dgv_investigadores.CurrentRow.Cells[16].Value.ToString();
                investigadores.text_continente.Text = dgv_investigadores.CurrentRow.Cells[17].Value.ToString();
                investigadores.text_pais.Text = dgv_investigadores.CurrentRow.Cells[18].Value.ToString();
                investigadores.text_provincias.Text = dgv_investigadores.CurrentRow.Cells[19].Value.ToString();
                investigadores.text_municipio.Text = dgv_investigadores.CurrentRow.Cells[20].Value.ToString();
                investigadores.text_bairro_rua.Text = dgv_investigadores.CurrentRow.Cells[21].Value.ToString();
              
                investigadores.btn_salvar.Visible = false;
                investigadores.btn_Atualizar.Visible = true;
                investigadores.label5.Text = "Atualizar funcionário";

                investigadores.ShowDialog();
                listar_Investigadores();
            }
            else
            {
                guna2MessageDialog1_Error.Show("Por favor, selecione o funcinário que pretende atualizar e tente novamente", "Falha de atualização");
            }
        }
        private void dgv_investigadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_investigadores.SelectedRows.Count > 0)
            {
                Modulos.Form_Modulo_Investigadores investigadores = new Modulos.Form_Modulo_Investigadores();
                investigadores.FormClosed += Investigadores_FormClosed;


                investigadores.label_id.Text = dgv_investigadores.CurrentRow.Cells[0].Value.ToString();
                investigadores.text_primeiro_nome.Text = dgv_investigadores.CurrentRow.Cells[1].Value.ToString();
                investigadores.text_nome_meio.Text = dgv_investigadores.CurrentRow.Cells[2].Value.ToString();
                investigadores.text_ultimo_nome.Text = dgv_investigadores.CurrentRow.Cells[3].Value.ToString();
                investigadores.text_data_nascimento.Text = dgv_investigadores.CurrentRow.Cells[4].Value.ToString();
                investigadores.text_sexo.Text = dgv_investigadores.CurrentRow.Cells[6].Value.ToString();
                investigadores.text_numero_bi.Text = dgv_investigadores.CurrentRow.Cells[7].Value.ToString();
                investigadores.text_primerio_numero_telefone.Text = dgv_investigadores.CurrentRow.Cells[8].Value.ToString();
                investigadores.text_segundo_numero_telefone.Text = dgv_investigadores.CurrentRow.Cells[9].Value.ToString();
                investigadores.text_e_mail.Text = dgv_investigadores.CurrentRow.Cells[10].Value.ToString();
                investigadores.text_nivel_academico.Text = dgv_investigadores.CurrentRow.Cells[11].Value.ToString();
                investigadores.text_curso.Text = dgv_investigadores.CurrentRow.Cells[12].Value.ToString();
                investigadores.text_especialidades.Text = dgv_investigadores.CurrentRow.Cells[13].Value.ToString();
                investigadores.text_patente.Text = dgv_investigadores.CurrentRow.Cells[14].Value.ToString();
                investigadores.text_data_inicio_contrato.Text = dgv_investigadores.CurrentRow.Cells[15].Value.ToString();
                investigadores.text_data_fim_contrato.Text = dgv_investigadores.CurrentRow.Cells[16].Value.ToString();
                investigadores.text_continente.Text = dgv_investigadores.CurrentRow.Cells[17].Value.ToString();
                investigadores.text_pais.Text = dgv_investigadores.CurrentRow.Cells[18].Value.ToString();
                investigadores.text_provincias.Text = dgv_investigadores.CurrentRow.Cells[19].Value.ToString();
                investigadores.text_municipio.Text = dgv_investigadores.CurrentRow.Cells[20].Value.ToString();
                investigadores.text_bairro_rua.Text = dgv_investigadores.CurrentRow.Cells[21].Value.ToString();
               
                investigadores.btn_salvar.Visible = false;
                investigadores.btn_Atualizar.Visible = true;
                investigadores.label5.Text = "Atualizar funcionário";

                investigadores.ShowDialog();
                listar_Investigadores();
            }
            else
            {
                guna2MessageDialog1_Error.Show("Por favor, selecione o funcionário que pretende atualizar e tente novamente", "Falha de atualização");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_investigadores.SelectedRows.Count > 0)
            {
                try
                {
                   if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar este funcionário?", "Mensagem de exclusão") == DialogResult.Yes)
                   {
                        int id_investigagor = Convert.ToInt32(dgv_investigadores.CurrentRow.Cells[0].Value.ToString());
                        c_Investigadores.id_investigador = id_investigagor;
                        d_Investigadores.eliminar_investigadores(c_Investigadores);

                        guna2MessageDialog_Inform.Show($"O(A) funcionário(a) com a identificação{id_investigagor} foi eliminada com sucesso.", "Exclusão bem sucedia");
                       
                        listar_Investigadores();
                   }
                }
                catch (Exception Ex)
                {
                    guna2MessageDialog1_Error.Show("Não foi possível eliminar este funcionário!",Ex.Message);
                }
            }
            else
            {
                guna2MessageDialog1_Error.Show("Por favor, selecione o funcionário que pretende eliminar e tente novamente", "Falha de exclusão");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Investigadores();
        }
        private void pesquisar_Investigadores()
        {
            dgv_investigadores.DataSource = p_Investigadores.pesquisar_Investigadores(text_pesquisar.Text);
        }
    }
}
