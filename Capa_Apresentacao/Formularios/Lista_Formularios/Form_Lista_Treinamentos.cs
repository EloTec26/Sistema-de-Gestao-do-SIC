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
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;

namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    public partial class Form_Lista_Treinamentos : Form
    {
        e_comum_treinamentos E_Treinamentos = new e_comum_treinamentos();
        dominio_treinamentos D_Treinamentos = new dominio_treinamentos();
        public Form_Lista_Treinamentos()
        {
            InitializeComponent();

            toolTip1.SetToolTip(btn_cadastrar, "Cadastrar");
            toolTip1.SetToolTip(btn_atualizar, "Atualizar");
            toolTip1.SetToolTip(btn_eliminar, "Eliminar");
            Carregar_Treinamentos();
        }
        private void Carregar_Treinamentos()
        {
            dgv_treinamento.DataSource = D_Treinamentos.selecionar_treinamentos();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Modulo_Treinamentos modulo = new Form_Modulo_Treinamentos();
            modulo.FormClosed += Modulo_FormClosed;
            modulo.ShowDialog();
        }

        private void Modulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Carregar_Treinamentos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void text_pesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
