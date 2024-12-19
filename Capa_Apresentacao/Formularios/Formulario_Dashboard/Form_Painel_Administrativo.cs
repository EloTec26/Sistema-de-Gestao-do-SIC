using Capa_Dominio.Dominio_Dashboard;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Capa_Apresentacao.Formularios.Formulario_Dashboard
{
    public partial class Form_Painel_Administrativo : Form
    {
        dominio_painel_administrativo servico = new dominio_painel_administrativo();
        // Adicione um Timer no seu Form, pode ser pelo Designer ou pelo código
        Timer animationTimer = new Timer();
        public Form_Painel_Administrativo()
        {
            InitializeComponent();
            // Carrega os dados iniciais (opcional)
            CarregarDados("Há 7 dias");

            animationTimer.Interval = 50; // Intervalo de 50 ms para suavidade na animação
            animationTimer.Tick += AnimationTimer_Tick;
        }

        int animationStep = 0; // Controle do passo da animação
        private void CarregarDados(string periodo, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            // Limpa o gráfico existente
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Adiciona uma nova série ao gráfico
            Series series = new Series("Quantidade")
            {
                ChartType = SeriesChartType.Column, // Muda para Coluna (vertical)
                IsValueShownAsLabel = false // Desabilita a exibição dos valores em cima das barras
            };

            // Consulta para cada tabela
            string[] tabelas = { "afastamento_tbl", "bairro_rua_tbl", "beneficio_investigador_tbl",
                         "beneficio_tbl", "cargo_tbl", "caso_tbl", "continente_tbl",
                         "curso_tbl", "departamento_tbl", "departamento_investigador_tbl",
                         "especialidade_tbl", "evidencia_tbl", "falta_tbl", "feria_tbl",
                         "hora_extra_tbl", "investigador_tbl", "municipio_tbl",
                         "nivel_academico_tbl", "pais_tbl", "patente_tbl",
                         "provincia_tbl", "suspeito_tbl", "testemunha_tbl", "vitima_tbl" };

            string[] nomes = { "Afastamentos", "Bairros/Ruas", "Bfs. Func.",
                       "Benefícios", "Cargos", "Casos", "Continentes",
                       "Cursos", "Departamentos", "Deprt. Func.",
                       "Espec.", "Evidências", "Faltas", "Férias",
                       "H.Extras", "Funcionários", "Municípios",
                       "N.acad.", "Países", "Patentes",
                       "Províncias", "Suspeitos", "Testemunhas", "Vítimas" };

            double maxCount = 0; // Variável para armazenar o valor máximo

            foreach (var tabela in tabelas)
            {
                int count = (dataInicial != null && dataFinal != null) ?
                            servico.ObterContagemPersonalizada(tabela, dataInicial.Value, dataFinal.Value) :
                            servico.ObterContagem(tabela, periodo);
                series.Points.AddXY(nomes[Array.IndexOf(tabelas, tabela)], count);

                // Atualiza o valor máximo
                if (count > maxCount)
                {
                    maxCount = count;
                }

                // Adiciona o valor do ponto como tooltip
                series.Points[series.Points.Count - 1].ToolTip = $"Quantidade: {count}";
            }

            chart1.Series.Add(series);
            chart1.Titles.Add($"Dados para: {periodo}");
            // Ajustar o eixo X
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.Title = "Categorias";
            chart1.ChartAreas[0].AxisY.Title = "Quantidade";

            // Definir valores mínimo e máximo do eixo Y
            if (maxCount > 0)
            {
                chart1.ChartAreas[0].AxisY.Minimum = 0; // O mínimo é 0
                chart1.ChartAreas[0].AxisY.Maximum = maxCount; // O máximo é o valor máximo encontrado
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 1; // Evita problemas de intervalo quando não há dados
            }

            animationStep = 0; // Inicia a animação
            animationTimer.Start(); // Inicia o Timer para a animação
        }


        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Aumenta o valor máximo do eixo Y gradualmente para criar o efeito de animação
            double maxValue = chart1.ChartAreas[0].AxisY.Maximum; // Usa o valor máximo definido
            double increment = maxValue / 20; // Divide o valor máximo em 20 passos para a animação

            if (chart1.ChartAreas[0].AxisY.Maximum < maxValue)
            {
                chart1.ChartAreas[0].AxisY.Maximum += increment;
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Maximum = maxValue;
                animationTimer.Stop(); // Para a animação quando atingir o valor máximo
            }

            chart1.Invalidate(); // Redesenha o gráfico
        }
        private void iconButton_Buscar_Datas_Personalizadas_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = text_data_inicial.Value.Date;
            DateTime dataFinal = text_data_final.Value.Date;

            if (dataFinal >= dataInicial)
            {
                CarregarDados("", dataInicial, dataFinal); // Passa período vazio para usar as datas personalizadas
            }
        }

        private void iconButton_Hoje_Click(object sender, EventArgs e)
        {
            CarregarDados("Hoje");
        }

        private void iconButto_Ha_7_Dias_Click(object sender, EventArgs e)
        {
            CarregarDados("Há 7 dias");
        }

        private void iconButton_Ha_14_Dias_Click(object sender, EventArgs e)
        {
            CarregarDados("Há 14 dias");
        }

        private void iconButton_Ha_1_Mes_Click(object sender, EventArgs e)
        {
            CarregarDados("Há 1 mês");
        }
        private void iconButton_Ha_2_Meses_Click_1(object sender, EventArgs e)
        {
            CarregarDados("Há 2 meses");
        }

        private void iconButton_Ha_6_Meses_Click(object sender, EventArgs e)
        {
            CarregarDados("Há 6 meses");
        }

        private void iconButton_Ha_1_Ano_Click(object sender, EventArgs e)
        {
            CarregarDados("Há 1 ano");
        }

     
    }
}
