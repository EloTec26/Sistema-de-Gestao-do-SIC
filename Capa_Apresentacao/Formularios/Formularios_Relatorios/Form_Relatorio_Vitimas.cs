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
    public partial class Form_Relatorio_Vitimas : Form
    {
        private dados_relatorios_vitimas _dados_relatorio_vitimas;
        private List<Dominio_Relatorio_Vitimas> _dominio_Relatorio_Vitimas;
        public Form_Relatorio_Vitimas()
        {
            InitializeComponent();
            _dados_relatorio_vitimas = new dados_relatorios_vitimas();
            _dominio_Relatorio_Vitimas = new List<Dominio_Relatorio_Vitimas>();

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Capa_Apresentacao.Formularios.Formularios_Relatorios.Report_Vitimas.rdlc";

            panel_personalizado.Visible = false;
            panel_butoes.Width = 0;
        }

        private void Form_Relatorio_Vitimas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            CarregarDadosUltimoMes();
        }
        private void CarregarDados(DateTime dataInicio, DateTime dataFim)
        {
            _dominio_Relatorio_Vitimas.Clear();
            DataTable dataTable = _dados_relatorio_vitimas.relatorioVitimas(dataInicio, dataFim);
            foreach (DataRow Ler_Lista in dataTable.Rows)
            {
                _dominio_Relatorio_Vitimas.Add(new Dominio_Relatorio_Vitimas
                {
                    Codigo_Vitima = Convert.ToInt32(Ler_Lista["Codigo_Vitima"].ToString()),
                    Vitima = Ler_Lista["Vitima"].ToString(),
                    Informacoes_gerais = Ler_Lista["Informacoes_gerais"].ToString(),
                    Data_Registro = Convert.ToDateTime(Ler_Lista["Data_Registro"].ToString()),
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
