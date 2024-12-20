using Capa_Dominio.Dominio_Dashboard;
using Capa_Dados.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Formulario_Dashboard
{
    public partial class Form_Dashboard : Form
    {
        dominio_Dashboard model = new dominio_Dashboard();
        dados_dashboard dados = new dados_dashboard();
        public Form_Dashboard()
        {
            InitializeComponent();
            CarregarDashboard();
        }
        private void CarregarDashboard()
        {
            label_total_continentes.Text = dados.NumeroContinentes.ToString();
            label_total_paises.Text = dados.NumeroPaises.ToString();
            label_total_provincias.Text = dados.NumeroProvincias.ToString();
            label_total_municipios.Text = dados.NumeroMunicipios.ToString();
            label_total_bairro_ruas.Text = dados.NumeroBairrosRuas.ToString();
            label_total_afastamentos.Text = dados.NumeroAfastamento.ToString();
            label_total_beneficios.Text = dados.NumeroBeneficios.ToString();
            label_total_beneficios_funcionarios.Text = dados.NumeroBeneficoInvestigadores.ToString();
            label_total_casos.Text = dados.NumeroCasos.ToString();
            label_total_cargos.Text = dados.NumeroCargos.ToString();
            label_total_cursos.Text = dados.NumeroCursos.ToString();
            label_total_departamentos.Text = dados.NumeroDepartamentos.ToString();
            label_total_departamentos_funcionarios.Text = dados.NumeroDepartamentoInvestigadores.ToString();
            label_total_especialidades.Text = dados.NumeroEspecialidades.ToString();
            label_total_evidencias.Text = dados.NumeroEvidencias.ToString();
            label_faltas.Text = dados.NumeroFaltas.ToString();
            label_ferias.Text = dados.NumeroFerias.ToString();
            label_total_horas_extras.Text = dados.NumeroHorasExtras.ToString();
            label_total_funcionarios.Text = dados.NumeroFuncionarios.ToString();
            label_total_niveis_academicos.Text = dados.NumeroNiveisAcademicos.ToString();
            label_patentes.Text = dados.NumeroPatentes.ToString();
            label_testemunhas.Text = dados.NumeroTestemunhas.ToString();
            label_total_usuarios.Text = dados.NumeroUsuarios.ToString();
            label_total_vitimas.Text = dados.NumeroVitimas.ToString();
            label_treinamento.Text = dados.NumeroTreinamento.ToString();
        }
    }
}
