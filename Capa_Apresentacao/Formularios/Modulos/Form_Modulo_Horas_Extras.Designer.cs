﻿namespace Capa_Apresentacao.Formularios.Modulos
{
    partial class Form_Modulo_Horas_Extras
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
            this.MessageDialog_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.text_data_trabalho = new CustomBox.RJControls.RJDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.text_horas_trabalho = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_tipo_horas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_msg_horas_trabalhadas = new System.Windows.Forms.Label();
            this.btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.Size = new System.Drawing.Size(523, 16);
            this.panel1.TabIndex = 70;
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
            this.btn_Fechar.IconSize = 20;
            this.btn_Fechar.Location = new System.Drawing.Point(506, 1);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(15, 15);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Registrar piquete";
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
            this.btn_Limpar.Location = new System.Drawing.Point(176, 287);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(146, 45);
            this.btn_Limpar.TabIndex = 145;
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
            this.btn_salvar.Location = new System.Drawing.Point(21, 287);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(146, 45);
            this.btn_salvar.TabIndex = 144;
            this.btn_salvar.Text = "Registrar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(22, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 140;
            this.label4.Text = "Os campos com o (";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(22, 271);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(486, 10);
            this.guna2Separator1.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(161, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 141;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(172, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 19);
            this.label6.TabIndex = 142;
            this.label6.Text = ") são de preenchimento obrigatório.";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(378, 31);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 146;
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
            this.text_investigador.Location = new System.Drawing.Point(19, 71);
            this.text_investigador.Name = "text_investigador";
            this.text_investigador.Size = new System.Drawing.Size(487, 36);
            this.text_investigador.TabIndex = 183;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(207, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 21);
            this.label10.TabIndex = 182;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(15, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 21);
            this.label9.TabIndex = 181;
            this.label9.Text = "Selecione o funcionário:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(17, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 191;
            this.label8.Text = "Data de trabalho:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(130, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 21);
            this.label11.TabIndex = 193;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(17, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 21);
            this.label12.TabIndex = 192;
            this.label12.Text = "Tipo de horas:";
            // 
            // text_data_trabalho
            // 
            this.text_data_trabalho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.text_data_trabalho.BorderSize = 0;
            this.text_data_trabalho.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_trabalho.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_trabalho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_trabalho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_data_trabalho.Location = new System.Drawing.Point(19, 137);
            this.text_data_trabalho.MinimumSize = new System.Drawing.Size(4, 35);
            this.text_data_trabalho.Name = "text_data_trabalho";
            this.text_data_trabalho.Size = new System.Drawing.Size(219, 35);
            this.text_data_trabalho.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_data_trabalho.TabIndex = 198;
            this.text_data_trabalho.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(157, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 199;
            this.label1.Text = "*";
            // 
            // text_horas_trabalho
            // 
            this.text_horas_trabalho.AcceptsReturn = true;
            this.text_horas_trabalho.Animated = true;
            this.text_horas_trabalho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_horas_trabalho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_horas_trabalho.DefaultText = "";
            this.text_horas_trabalho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_horas_trabalho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_horas_trabalho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_horas_trabalho.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_horas_trabalho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_horas_trabalho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(223)))));
            this.text_horas_trabalho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_horas_trabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_horas_trabalho.Location = new System.Drawing.Point(255, 136);
            this.text_horas_trabalho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_horas_trabalho.MaxLength = 5;
            this.text_horas_trabalho.Name = "text_horas_trabalho";
            this.text_horas_trabalho.PasswordChar = '\0';
            this.text_horas_trabalho.PlaceholderText = "";
            this.text_horas_trabalho.SelectedText = "";
            this.text_horas_trabalho.Size = new System.Drawing.Size(251, 36);
            this.text_horas_trabalho.TabIndex = 200;
            this.text_horas_trabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_horas_trabalho_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(385, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 202;
            this.label2.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(251, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 201;
            this.label7.Text = "Horas trabalhas:";
            // 
            // text_tipo_horas
            // 
            this.text_tipo_horas.BackColor = System.Drawing.Color.Transparent;
            this.text_tipo_horas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_tipo_horas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_tipo_horas.DropDownHeight = 250;
            this.text_tipo_horas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_tipo_horas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_tipo_horas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tipo_horas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tipo_horas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_tipo_horas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_tipo_horas.IntegralHeight = false;
            this.text_tipo_horas.ItemHeight = 30;
            this.text_tipo_horas.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.text_tipo_horas.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.text_tipo_horas.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tipo_horas.Location = new System.Drawing.Point(19, 205);
            this.text_tipo_horas.Name = "text_tipo_horas";
            this.text_tipo_horas.Size = new System.Drawing.Size(487, 36);
            this.text_tipo_horas.StartIndex = 0;
            this.text_tipo_horas.TabIndex = 203;
            // 
            // label_msg_horas_trabalhadas
            // 
            this.label_msg_horas_trabalhadas.AutoSize = true;
            this.label_msg_horas_trabalhadas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_horas_trabalhadas.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_horas_trabalhadas.Location = new System.Drawing.Point(252, 178);
            this.label_msg_horas_trabalhadas.Name = "label_msg_horas_trabalhadas";
            this.label_msg_horas_trabalhadas.Size = new System.Drawing.Size(120, 17);
            this.label_msg_horas_trabalhadas.TabIndex = 204;
            this.label_msg_horas_trabalhadas.Text = "mensagem de erro";
            this.label_msg_horas_trabalhadas.Visible = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Animated = true;
            this.btn_atualizar.AnimatedGIF = true;
            this.btn_atualizar.BorderRadius = 4;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_atualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_atualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_atualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_atualizar.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_atualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Location = new System.Drawing.Point(22, 287);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_atualizar.TabIndex = 205;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.Visible = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // Form_Modulo_Horas_Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(523, 352);
            this.Controls.Add(this.label_msg_horas_trabalhadas);
            this.Controls.Add(this.text_tipo_horas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_horas_trabalho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_data_trabalho);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.btn_atualizar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Modulo_Horas_Extras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Modulo_Horas_Extras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label_id;
        public Guna.UI2.WinForms.Guna2ComboBox text_investigador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog_Error;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        public CustomBox.RJControls.RJDatePicker text_data_trabalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox text_horas_trabalho;
        public Guna.UI2.WinForms.Guna2ComboBox text_tipo_horas;
        public Guna.UI2.WinForms.Guna2Button btn_Limpar;
        public Guna.UI2.WinForms.Guna2Button btn_salvar;
        private System.Windows.Forms.Label label_msg_horas_trabalhadas;
        public Guna.UI2.WinForms.Guna2Button btn_atualizar;
    }
}