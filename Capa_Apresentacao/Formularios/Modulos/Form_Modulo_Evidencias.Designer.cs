namespace Capa_Apresentacao.Formularios.Modulos
{
    partial class Form_Modulo_Evidencias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Limpar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_salvar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.text_investigador = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_caso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_tipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_data_coleta = new CustomBox.RJControls.RJDatePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_local_armazenamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.text_descricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.MessageDialog_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label_msg_local_armazenamento = new System.Windows.Forms.Label();
            this.label_msg_descricao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 28);
            this.panel1.TabIndex = 71;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_Fechar.IconColor = System.Drawing.Color.White;
            this.btn_Fechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Fechar.IconSize = 30;
            this.btn_Fechar.Location = new System.Drawing.Point(511, 1);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(25, 25);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Registrar evidência";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Animated = true;
            this.btn_Limpar.AnimatedGIF = true;
            this.btn_Limpar.BorderRadius = 4;
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Limpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Limpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Limpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Limpar.FillColor = System.Drawing.Color.Tomato;
            this.btn_Limpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(184, 453);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(146, 45);
            this.btn_Limpar.TabIndex = 151;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Animated = true;
            this.btn_salvar.AnimatedGIF = true;
            this.btn_salvar.BorderRadius = 4;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(30, 453);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(146, 45);
            this.btn_salvar.TabIndex = 150;
            this.btn_salvar.Text = "Registrar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(30, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 146;
            this.label4.Text = "Os campos com o (";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(30, 433);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(481, 14);
            this.guna2Separator1.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(169, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 147;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(180, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 19);
            this.label6.TabIndex = 148;
            this.label6.Text = ") são de preenchimento obrigatório.";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(383, 23);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 184;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
            // 
            // text_investigador
            // 
            this.text_investigador.BackColor = System.Drawing.Color.Transparent;
            this.text_investigador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_investigador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_investigador.DropDownHeight = 250;
            this.text_investigador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_investigador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_investigador.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_investigador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_investigador.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_investigador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_investigador.IntegralHeight = false;
            this.text_investigador.ItemHeight = 30;
            this.text_investigador.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.text_investigador.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_investigador.Location = new System.Drawing.Point(24, 63);
            this.text_investigador.Name = "text_investigador";
            this.text_investigador.Size = new System.Drawing.Size(487, 36);
            this.text_investigador.TabIndex = 187;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(212, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 21);
            this.label10.TabIndex = 186;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(20, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 21);
            this.label9.TabIndex = 185;
            this.label9.Text = "Selecione o funcionário:";
            // 
            // text_caso
            // 
            this.text_caso.BackColor = System.Drawing.Color.Transparent;
            this.text_caso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_caso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_caso.DropDownHeight = 250;
            this.text_caso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_caso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_caso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_caso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_caso.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_caso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_caso.IntegralHeight = false;
            this.text_caso.ItemHeight = 30;
            this.text_caso.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.text_caso.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_caso.Location = new System.Drawing.Point(24, 138);
            this.text_caso.Name = "text_caso";
            this.text_caso.Size = new System.Drawing.Size(237, 36);
            this.text_caso.TabIndex = 191;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(164, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 190;
            this.label2.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(20, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 189;
            this.label7.Text = "Selecione o caso:";
            // 
            // text_tipo
            // 
            this.text_tipo.BackColor = System.Drawing.Color.Transparent;
            this.text_tipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_tipo.DropDownHeight = 250;
            this.text_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_tipo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_tipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tipo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_tipo.IntegralHeight = false;
            this.text_tipo.ItemHeight = 30;
            this.text_tipo.Items.AddRange(new object[] {
            "Tipo 1",
            "Tipo 2",
            "Tipo 3",
            "Tipo 4"});
            this.text_tipo.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.text_tipo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tipo.Location = new System.Drawing.Point(274, 138);
            this.text_tipo.Name = "text_tipo";
            this.text_tipo.Size = new System.Drawing.Size(237, 36);
            this.text_tipo.StartIndex = 0;
            this.text_tipo.TabIndex = 194;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(406, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 193;
            this.label1.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(270, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 21);
            this.label8.TabIndex = 192;
            this.label8.Text = "Selecione o tipo:";
            // 
            // text_data_coleta
            // 
            this.text_data_coleta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.text_data_coleta.BorderSize = 0;
            this.text_data_coleta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_coleta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_coleta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_coleta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_data_coleta.Location = new System.Drawing.Point(24, 219);
            this.text_data_coleta.MinimumSize = new System.Drawing.Size(4, 35);
            this.text_data_coleta.Name = "text_data_coleta";
            this.text_data_coleta.Size = new System.Drawing.Size(237, 35);
            this.text_data_coleta.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_data_coleta.TabIndex = 198;
            this.text_data_coleta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Tomato;
            this.label13.Location = new System.Drawing.Point(156, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 21);
            this.label13.TabIndex = 200;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(20, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 21);
            this.label14.TabIndex = 199;
            this.label14.Text = "Data da coleta:";
            // 
            // text_local_armazenamento
            // 
            this.text_local_armazenamento.AcceptsReturn = true;
            this.text_local_armazenamento.Animated = true;
            this.text_local_armazenamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_local_armazenamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_local_armazenamento.DefaultText = "";
            this.text_local_armazenamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_local_armazenamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_local_armazenamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_local_armazenamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_local_armazenamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_local_armazenamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(223)))));
            this.text_local_armazenamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_local_armazenamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_local_armazenamento.Location = new System.Drawing.Point(274, 218);
            this.text_local_armazenamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_local_armazenamento.Name = "text_local_armazenamento";
            this.text_local_armazenamento.PasswordChar = '\0';
            this.text_local_armazenamento.PlaceholderText = "";
            this.text_local_armazenamento.SelectedText = "";
            this.text_local_armazenamento.Size = new System.Drawing.Size(237, 36);
            this.text_local_armazenamento.TabIndex = 201;
            this.text_local_armazenamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_local_armazenamento_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(484, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 21);
            this.label11.TabIndex = 203;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(270, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 21);
            this.label12.TabIndex = 202;
            this.label12.Text = "Local de armazenamento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(21, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 21);
            this.label16.TabIndex = 205;
            this.label16.Text = "Descrição:";
            // 
            // text_descricao
            // 
            this.text_descricao.AcceptsReturn = true;
            this.text_descricao.Animated = true;
            this.text_descricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_descricao.DefaultText = "";
            this.text_descricao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_descricao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_descricao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_descricao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_descricao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_descricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(223)))));
            this.text_descricao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_descricao.Location = new System.Drawing.Point(25, 296);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_descricao.MaxLength = 320;
            this.text_descricao.Multiline = true;
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.PasswordChar = '\0';
            this.text_descricao.PlaceholderText = "";
            this.text_descricao.SelectedText = "";
            this.text_descricao.Size = new System.Drawing.Size(486, 86);
            this.text_descricao.TabIndex = 204;
            this.text_descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_descricao_KeyPress);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Animated = true;
            this.btn_Atualizar.AnimatedGIF = true;
            this.btn_Atualizar.BorderRadius = 4;
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Atualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Atualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Atualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Atualizar.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Atualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Atualizar.Location = new System.Drawing.Point(30, 453);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_Atualizar.TabIndex = 209;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // MessageDialog_Error
            // 
            this.MessageDialog_Error.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.MessageDialog_Error.Caption = null;
            this.MessageDialog_Error.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageDialog_Error.Parent = this;
            this.MessageDialog_Error.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageDialog_Error.Text = null;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 4;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.9D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2MessageDialog_Confirm
            // 
            this.guna2MessageDialog_Confirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog_Confirm.Caption = null;
            this.guna2MessageDialog_Confirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog_Confirm.Parent = this;
            this.guna2MessageDialog_Confirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog_Confirm.Text = null;
            // 
            // guna2MessageDialog_Inform
            // 
            this.guna2MessageDialog_Inform.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog_Inform.Caption = null;
            this.guna2MessageDialog_Inform.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog_Inform.Parent = this;
            this.guna2MessageDialog_Inform.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog_Inform.Text = null;
            // 
            // label_msg_local_armazenamento
            // 
            this.label_msg_local_armazenamento.AutoSize = true;
            this.label_msg_local_armazenamento.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_local_armazenamento.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_local_armazenamento.Location = new System.Drawing.Point(271, 258);
            this.label_msg_local_armazenamento.Name = "label_msg_local_armazenamento";
            this.label_msg_local_armazenamento.Size = new System.Drawing.Size(120, 17);
            this.label_msg_local_armazenamento.TabIndex = 210;
            this.label_msg_local_armazenamento.Text = "mensagem de erro";
            this.label_msg_local_armazenamento.Visible = false;
            // 
            // label_msg_descricao
            // 
            this.label_msg_descricao.AutoSize = true;
            this.label_msg_descricao.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_descricao.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_descricao.Location = new System.Drawing.Point(29, 386);
            this.label_msg_descricao.Name = "label_msg_descricao";
            this.label_msg_descricao.Size = new System.Drawing.Size(120, 17);
            this.label_msg_descricao.TabIndex = 211;
            this.label_msg_descricao.Text = "mensagem de erro";
            this.label_msg_descricao.Visible = false;
            // 
            // Form_Modulo_Evidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(536, 512);
            this.Controls.Add(this.label_msg_descricao);
            this.Controls.Add(this.label_msg_local_armazenamento);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.text_descricao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_local_armazenamento);
            this.Controls.Add(this.text_data_coleta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.text_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_caso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.text_investigador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Atualizar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Modulo_Evidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Modulo_Evidencias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        public System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2Button btn_Limpar;
        public Guna.UI2.WinForms.Guna2Button btn_salvar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label_id;
        public Guna.UI2.WinForms.Guna2ComboBox text_investigador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2ComboBox text_caso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2ComboBox text_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public CustomBox.RJControls.RJDatePicker text_data_coleta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public Guna.UI2.WinForms.Guna2TextBox text_local_armazenamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        public Guna.UI2.WinForms.Guna2TextBox text_descricao;
        public Guna.UI2.WinForms.Guna2Button btn_Atualizar;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog_Error;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        private System.Windows.Forms.Label label_msg_descricao;
        private System.Windows.Forms.Label label_msg_local_armazenamento;
    }
}