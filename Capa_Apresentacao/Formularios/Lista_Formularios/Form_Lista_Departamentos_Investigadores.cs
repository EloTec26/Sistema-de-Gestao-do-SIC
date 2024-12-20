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
using Capa_Comum.Entidades;
using Capa_Dominio.Dominio_Permissoes;
using Capa_Dominio.Dominio_Pesquisas;
using Capa_Dominio;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Departamentos_Investigadores : Form
    {
        e_comum_departamentos_investigadores c_Departamentos_Investigadores = new e_comum_departamentos_investigadores();
        dominio_departamentos_investigadores d_Departamentos_Investigadores = new dominio_departamentos_investigadores();
        dominio_pesquisar_departamentos_investigadores d_Pesquisar_Departamento_Investigador = new dominio_pesquisar_departamentos_investigadores();
        public Form_Lista_Departamentos_Investigadores()
        {
            InitializeComponent();
            selecionar_Departamentos_Investigadores();
            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
        }
        private void selecionar_Departamentos_Investigadores()
        {
            dgv_departamentos_investigadores.DataSource = d_Departamentos_Investigadores.selecionar_Departamentos_Investigadores();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Departamento_Investigadores departamento_Investigadores = new Form_Modulo_Departamento_Investigadores();
            departamento_Investigadores.FormClosed += Departamento_Investigadores_FormClosed;
            departamento_Investigadores.ShowDialog();
            selecionar_Departamentos_Investigadores();
        }

        private void Departamento_Investigadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            selecionar_Departamentos_Investigadores();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(dgv_departamentos_investigadores.SelectedRows.Count > 0)
            {
                Form_Modulo_Departamento_Investigadores departamento_Investigadores = new Form_Modulo_Departamento_Investigadores();
                departamento_Investigadores.FormClosed += Departamento_Investigadores_FormClosed;

                departamento_Investigadores.label_id.Text = dgv_departamentos_investigadores.CurrentRow.Cells[0].Value.ToString();
                departamento_Investigadores.text_investigador.Text = dgv_departamentos_investigadores.CurrentRow.Cells[1].Value.ToString();
                departamento_Investigadores.text_departamento.Text = dgv_departamentos_investigadores.CurrentRow.Cells[2].Value.ToString();
              
                departamento_Investigadores.label5.Text = "Atualizar a tribuição do func. ao depart.";
                departamento_Investigadores.btn_salvar.Visible = false;
                departamento_Investigadores.btn_Atualizar.Visible = true;
                
                departamento_Investigadores.ShowDialog();
                selecionar_Departamentos_Investigadores();
            }
            else
            {
                MessageBox.Show("Por favor, selecione o Depart.>Investigador que pretende atualizar e tente novamente!",
                    "Falha de atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_departamentos_investigadores.SelectedRows.Count > 0)
            {
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de eliminar esta informação?", "Mensagem de confirmação") == DialogResult.Yes)
                {
                    int id_Departamentos_Investigadores = Convert.ToInt32(dgv_departamentos_investigadores.CurrentRow.Cells[0].Value.ToString());
                    c_Departamentos_Investigadores.id_departamento_investigador = id_Departamentos_Investigadores;
                    d_Departamentos_Investigadores.eliminar_Departamentos_Investigadores(c_Departamentos_Investigadores);
                    guna2MessageDialog_Inform.Show($"A informação com o identificador {id_Departamentos_Investigadores}, foi eliminada com sucesso!", "Exclusão bem sucedida");

                    selecionar_Departamentos_Investigadores();
                }
            }
            else
            {
                MessageDialog_Error.Show("Por favor, selecione o Depart.>Investigador que pretende eliminar e tente novamente!",
                    "Falha de atualização");
            }
        }
        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Depart_Investigador();
        }
        private void pesquisar_Depart_Investigador()
        {
            dgv_departamentos_investigadores.DataSource = d_Pesquisar_Departamento_Investigador.pesquisar_Departamento_Investigador(text_pesquisar.Text);
        }
    }
}
