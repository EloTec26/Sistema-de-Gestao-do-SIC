using Capa_Dados.Dados_Relatorios;
using Capa_Dominio.Dominio_Relatorio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Formularios_Relatorios
{
    public partial class Form_Relatorio_Beneficios_Investigadores : Form
    {
        private dados_relatorios_beneficios_investigadores _dados_relatorio_beneficios_investigadores;
        private List<Dominio_Relatorio_Beneficios_Investigadores> _dominio_Relatorio_Beneficios_Investigadores;
        public Form_Relatorio_Beneficios_Investigadores()
        {
            InitializeComponent();

            _dados_relatorio_beneficios_investigadores = new dados_relatorios_beneficios_investigadores();
            _dominio_Relatorio_Beneficios_Investigadores = new List<Dominio_Relatorio_Beneficios_Investigadores>();

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Capa_Apresentacao.Formularios.Formularios_Relatorios.Report_Benefios_Investigadores.rdlc";

            panel_personalizado.Visible = false;
            panel_butoes.Width = 0;
        }

        private void Form_Relatorio_Beneficios_Investigadores_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            CarregarDadosUltimoMes();
        }
        private void CarregarDados(DateTime dataInicio, DateTime dataFim)
        {
            _dominio_Relatorio_Beneficios_Investigadores.Clear();
            DataTable dataTable = _dados_relatorio_beneficios_investigadores.relatorioBenefiosInvestigadores(dataInicio, dataFim);
            foreach (DataRow Ler_Lista in dataTable.Rows)
            {
                _dominio_Relatorio_Beneficios_Investigadores.Add(new Dominio_Relatorio_Beneficios_Investigadores
                {
                    Codigo = Convert.ToInt32(Ler_Lista["Codigo"].ToString()),
                    Funcionario = Ler_Lista["Funcionario"].ToString(),
                    Descricao = Ler_Lista["Descricao"].ToString(),
                    Data_registro = Convert.ToDateTime(Ler_Lista["Data_registro"].ToString()),
                });
            }
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void CarregarDadosUltimoMes()
        {
            DateTime dataInicio = DateTime.Now.AddMonths(-1);
            DateTime dataFim = DateTime.Now;
            CarregarDados(dataInicio, dataFim);
        }
        private void btn_exbir_Click(object sender, EventArgs e)
        {
            if (panel_butoes.Width == 0)
                panel_butoes.Width = 184;
            else panel_butoes.Width = 0;
        }

        private void btn_exibir_painel_busca_personalizada_Click(object sender, EventArgs e)
        {
            panel_personalizado.Visible = !panel_personalizado.Visible;
        }

        private void btn_Hoje_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today;
            CarregarDados(dataInicio, dataFim);
        }

        private void btn_Ha_7_Dias_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Now.AddDays(-7);
            DateTime dataFim = DateTime.Now;
            CarregarDados(dataInicio, dataFim);
        }

        private void btn_Ha_1_Mes_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Now.AddMonths(-1);
            DateTime dataFim = DateTime.Now;
            CarregarDados(dataInicio, dataFim);
        }

        private void btn_Buscar_Personalizada_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = data_inicial.Value;
            DateTime dataFim = data_final.Value;
            CarregarDados(dataInicio, dataFim);
        }
    }
}
