using Capa_Dados.Dados_Relatorios;
using Capa_Dominio.Dominio_Relatorio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Formularios_Relatorios
{
    public partial class Form_Relatorio_Evento_Casos : Form
    {
        private dados_relatorios_eventos_casos _dados_relatorio_eventos_casos;
        private List<Dominio_Relatorio_Evento_Casos> _dominio_Relatorio_Evento_Casos;

        public Form_Relatorio_Evento_Casos()
        {
            InitializeComponent();

            _dados_relatorio_eventos_casos = new dados_relatorios_eventos_casos();
            _dominio_Relatorio_Evento_Casos = new List<Dominio_Relatorio_Evento_Casos>();

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Capa_Apresentacao.Formularios.Formularios_Relatorios.Report_Evento_Casos.rdlc";

            panel_personalizado.Visible = false;
            panel_butoes.Width = 0;
        }
        private void Form_Relatorio_Evento_Casos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            CarregarDadosUltimoMes();
        }
        private void CarregarDados(DateTime dataInicio, DateTime dataFim)
        {
            _dominio_Relatorio_Evento_Casos.Clear();
            DataTable dataTable = _dados_relatorio_eventos_casos.buscar_relatorios_eventos_casos(dataInicio, dataFim);
            foreach (DataRow Ler_Lista in dataTable.Rows)
            {
                _dominio_Relatorio_Evento_Casos.Add(new Dominio_Relatorio_Evento_Casos
                {
                    codigo = Ler_Lista["codigo"].ToString(),
                    descricao_vitima = Ler_Lista["descricao_vitima"].ToString(),
                    inf_caso = Ler_Lista["inf_caso"].ToString(),
                    responsavel = Ler_Lista["responsavel"].ToString(),
                    testemunha = Ler_Lista["testemunha"].ToString(),
                    endereco = Ler_Lista["endereco"].ToString(),
                    data_do_evento = Convert.ToDateTime(Ler_Lista["data_do_evento"].ToString()),
                    total_eventos = Ler_Lista["total_eventos"].ToString(),
                    total_masculino = Ler_Lista["total_masculino"].ToString(),
                    total_feminino = Ler_Lista["total_feminino"].ToString()
                });
            }
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
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
        private void CarregarDadosUltimoMes()
        {
            DateTime dataInicio = DateTime.Now.AddMonths(-1);
            DateTime dataFim = DateTime.Now;
            CarregarDados(dataInicio, dataFim);
        }
        private void btn_exibir_painel_busca_personalizada_Click(object sender, EventArgs e)
        {
            panel_personalizado.Visible = !panel_personalizado.Visible;
        }
        private void btn_exbir_Click(object sender, EventArgs e)
        {
            if (panel_butoes.Width == 0)
                panel_butoes.Width = 184;
            else panel_butoes.Width = 0;
        }
        private void btn_ocultar_Click(object sender, EventArgs e)
        {
           
         
        }


    }
}


