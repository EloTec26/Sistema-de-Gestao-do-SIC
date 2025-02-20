namespace Capa_Apresentacao.Formularios.Formularios_Relatorios
{
    partial class Form_Relatorio_Testemunhas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel_butoes = new System.Windows.Forms.Panel();
            this.panel_personalizado = new System.Windows.Forms.Panel();
            this.data_final = new CustomBox.RJControls.RJDatePicker();
            this.btn_Buscar_Personalizada = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.data_inicial = new CustomBox.RJControls.RJDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exibir_painel_busca_personalizada = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ha_1_Mes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Hoje = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ha_7_Dias = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_exbir = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dominioRelatorioTestemunhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_butoes.SuspendLayout();
            this.panel_personalizado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dominioRelatorioTestemunhasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_butoes
            // 
            this.panel_butoes.Controls.Add(this.panel_personalizado);
            this.panel_butoes.Controls.Add(this.panel2);
            this.panel_butoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_butoes.Location = new System.Drawing.Point(0, 0);
            this.panel_butoes.Margin = new System.Windows.Forms.Padding(5);
            this.panel_butoes.Name = "panel_butoes";
            this.panel_butoes.Size = new System.Drawing.Size(187, 474);
            this.panel_butoes.TabIndex = 143;
            // 
            // panel_personalizado
            // 
            this.panel_personalizado.Controls.Add(this.data_final);
            this.panel_personalizado.Controls.Add(this.btn_Buscar_Personalizada);
            this.panel_personalizado.Controls.Add(this.label1);
            this.panel_personalizado.Controls.Add(this.data_inicial);
            this.panel_personalizado.Controls.Add(this.label7);
            this.panel_personalizado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_personalizado.Location = new System.Drawing.Point(0, 255);
            this.panel_personalizado.Margin = new System.Windows.Forms.Padding(5);
            this.panel_personalizado.Name = "panel_personalizado";
            this.panel_personalizado.Size = new System.Drawing.Size(187, 201);
            this.panel_personalizado.TabIndex = 1;
            // 
            // data_final
            // 
            this.data_final.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.data_final.BorderSize = 0;
            this.data_final.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.data_final.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.data_final.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_final.Location = new System.Drawing.Point(19, 97);
            this.data_final.Margin = new System.Windows.Forms.Padding(5);
            this.data_final.MinimumSize = new System.Drawing.Size(4, 35);
            this.data_final.Name = "data_final";
            this.data_final.Size = new System.Drawing.Size(146, 35);
            this.data_final.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.data_final.TabIndex = 136;
            this.data_final.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // btn_Buscar_Personalizada
            // 
            this.btn_Buscar_Personalizada.Animated = true;
            this.btn_Buscar_Personalizada.AnimatedGIF = true;
            this.btn_Buscar_Personalizada.BorderRadius = 4;
            this.btn_Buscar_Personalizada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar_Personalizada.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_Buscar_Personalizada.DisabledState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.btn_Buscar_Personalizada.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_Buscar_Personalizada.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar_Personalizada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar_Personalizada.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar_Personalizada.Location = new System.Drawing.Point(19, 142);
            this.btn_Buscar_Personalizada.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Buscar_Personalizada.Name = "btn_Buscar_Personalizada";
            this.btn_Buscar_Personalizada.Size = new System.Drawing.Size(146, 45);
            this.btn_Buscar_Personalizada.TabIndex = 131;
            this.btn_Buscar_Personalizada.Text = "Buscar";
            this.btn_Buscar_Personalizada.Click += new System.EventHandler(this.btn_Buscar_Personalizada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 137;
            this.label1.Text = "Data final:";
            // 
            // data_inicial
            // 
            this.data_inicial.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.data_inicial.BorderSize = 0;
            this.data_inicial.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.data_inicial.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.data_inicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_inicial.Location = new System.Drawing.Point(19, 31);
            this.data_inicial.Margin = new System.Windows.Forms.Padding(5);
            this.data_inicial.MinimumSize = new System.Drawing.Size(4, 35);
            this.data_inicial.Name = "data_inicial";
            this.data_inicial.Size = new System.Drawing.Size(146, 35);
            this.data_inicial.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.data_inicial.TabIndex = 134;
            this.data_inicial.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(15, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 135;
            this.label7.Text = "Data inicial:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_exibir_painel_busca_personalizada);
            this.panel2.Controls.Add(this.btn_Ha_1_Mes);
            this.panel2.Controls.Add(this.btn_Hoje);
            this.panel2.Controls.Add(this.btn_Ha_7_Dias);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 255);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(14, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 139;
            this.label2.Text = "Rel. Testemunhas";
            // 
            // btn_exibir_painel_busca_personalizada
            // 
            this.btn_exibir_painel_busca_personalizada.Animated = true;
            this.btn_exibir_painel_busca_personalizada.AnimatedGIF = true;
            this.btn_exibir_painel_busca_personalizada.BorderRadius = 4;
            this.btn_exibir_painel_busca_personalizada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exibir_painel_busca_personalizada.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_exibir_painel_busca_personalizada.DisabledState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.btn_exibir_painel_busca_personalizada.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_exibir_painel_busca_personalizada.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_exibir_painel_busca_personalizada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exibir_painel_busca_personalizada.ForeColor = System.Drawing.Color.White;
            this.btn_exibir_painel_busca_personalizada.Location = new System.Drawing.Point(19, 208);
            this.btn_exibir_painel_busca_personalizada.Margin = new System.Windows.Forms.Padding(5);
            this.btn_exibir_painel_busca_personalizada.Name = "btn_exibir_painel_busca_personalizada";
            this.btn_exibir_painel_busca_personalizada.Size = new System.Drawing.Size(146, 45);
            this.btn_exibir_painel_busca_personalizada.TabIndex = 138;
            this.btn_exibir_painel_busca_personalizada.Text = "Busca person.";
            this.btn_exibir_painel_busca_personalizada.Click += new System.EventHandler(this.btn_exibir_painel_busca_personalizada_Click);
            // 
            // btn_Ha_1_Mes
            // 
            this.btn_Ha_1_Mes.Animated = true;
            this.btn_Ha_1_Mes.AnimatedGIF = true;
            this.btn_Ha_1_Mes.BorderRadius = 4;
            this.btn_Ha_1_Mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ha_1_Mes.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_Ha_1_Mes.DisabledState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.btn_Ha_1_Mes.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_Ha_1_Mes.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_Ha_1_Mes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ha_1_Mes.ForeColor = System.Drawing.Color.White;
            this.btn_Ha_1_Mes.Location = new System.Drawing.Point(19, 153);
            this.btn_Ha_1_Mes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Ha_1_Mes.Name = "btn_Ha_1_Mes";
            this.btn_Ha_1_Mes.Size = new System.Drawing.Size(146, 45);
            this.btn_Ha_1_Mes.TabIndex = 132;
            this.btn_Ha_1_Mes.Text = "Há 1 mês";
            this.btn_Ha_1_Mes.Click += new System.EventHandler(this.btn_Ha_1_Mes_Click);
            // 
            // btn_Hoje
            // 
            this.btn_Hoje.Animated = true;
            this.btn_Hoje.AnimatedGIF = true;
            this.btn_Hoje.BorderRadius = 4;
            this.btn_Hoje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hoje.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_Hoje.DisabledState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.btn_Hoje.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_Hoje.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_Hoje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hoje.ForeColor = System.Drawing.Color.White;
            this.btn_Hoje.Location = new System.Drawing.Point(19, 43);
            this.btn_Hoje.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Hoje.Name = "btn_Hoje";
            this.btn_Hoje.Size = new System.Drawing.Size(146, 45);
            this.btn_Hoje.TabIndex = 130;
            this.btn_Hoje.Text = "Hoje";
            this.btn_Hoje.Click += new System.EventHandler(this.btn_Hoje_Click);
            // 
            // btn_Ha_7_Dias
            // 
            this.btn_Ha_7_Dias.Animated = true;
            this.btn_Ha_7_Dias.AnimatedGIF = true;
            this.btn_Ha_7_Dias.BorderRadius = 4;
            this.btn_Ha_7_Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ha_7_Dias.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_Ha_7_Dias.DisabledState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.btn_Ha_7_Dias.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_Ha_7_Dias.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_Ha_7_Dias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ha_7_Dias.ForeColor = System.Drawing.Color.White;
            this.btn_Ha_7_Dias.Location = new System.Drawing.Point(19, 98);
            this.btn_Ha_7_Dias.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Ha_7_Dias.Name = "btn_Ha_7_Dias";
            this.btn_Ha_7_Dias.Size = new System.Drawing.Size(146, 45);
            this.btn_Ha_7_Dias.TabIndex = 133;
            this.btn_Ha_7_Dias.Text = "Há 7 dias";
            this.btn_Ha_7_Dias.Click += new System.EventHandler(this.btn_Ha_7_Dias_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_exbir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(187, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 474);
            this.panel3.TabIndex = 144;
            // 
            // btn_exbir
            // 
            this.btn_exbir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exbir.FlatAppearance.BorderSize = 0;
            this.btn_exbir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exbir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_exbir.IconChar = FontAwesome.Sharp.IconChar.AlignRight;
            this.btn_exbir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_exbir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_exbir.IconSize = 30;
            this.btn_exbir.Location = new System.Drawing.Point(0, 0);
            this.btn_exbir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_exbir.Name = "btn_exbir";
            this.btn_exbir.Size = new System.Drawing.Size(34, 30);
            this.btn_exbir.TabIndex = 1;
            this.btn_exbir.UseVisualStyleBackColor = false;
            this.btn_exbir.Click += new System.EventHandler(this.btn_exbir_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dominioRelatorioTestemunhasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Apresentacao.Formularios.Formularios_Relatorios.Report_Evento_Casos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(223, 3);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(895, 471);
            this.reportViewer1.TabIndex = 145;
            // 
            // dominioRelatorioTestemunhasBindingSource
            // 
            this.dominioRelatorioTestemunhasBindingSource.DataSource = typeof(Capa_Dominio.Dominio_Relatorio.Dominio_Relatorio_Testemunhas);
            // 
            // Form_Relatorio_Testemunhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1120, 474);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_butoes);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Relatorio_Testemunhas";
            this.Text = "Form_Relatorio_Testemunhas";
            this.Load += new System.EventHandler(this.Form_Relatorio_Testemunhas_Load);
            this.panel_butoes.ResumeLayout(false);
            this.panel_personalizado.ResumeLayout(false);
            this.panel_personalizado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dominioRelatorioTestemunhasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_butoes;
        private System.Windows.Forms.Panel panel_personalizado;
        public CustomBox.RJControls.RJDatePicker data_final;
        private Guna.UI2.WinForms.Guna2Button btn_Buscar_Personalizada;
        private System.Windows.Forms.Label label1;
        public CustomBox.RJControls.RJDatePicker data_inicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_exibir_painel_busca_personalizada;
        private Guna.UI2.WinForms.Guna2Button btn_Ha_1_Mes;
        private Guna.UI2.WinForms.Guna2Button btn_Hoje;
        private Guna.UI2.WinForms.Guna2Button btn_Ha_7_Dias;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_exbir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dominioRelatorioTestemunhasBindingSource;
    }
}