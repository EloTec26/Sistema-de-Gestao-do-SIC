namespace Capa_Apresentacao.Formularios.Modulos
{
    partial class Form_Modulo_Afastamentos
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
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_data_inicio_afastamentos = new CustomBox.RJControls.RJDatePicker();
            this.text_investigador = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_descricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_data_final_afastamentos = new CustomBox.RJControls.RJDatePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Limpar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_salvar = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.MessageDialog_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.text_Estado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(509, 20);
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
            this.btn_Fechar.IconSize = 20;
            this.btn_Fechar.Location = new System.Drawing.Point(491, 2);
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
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Registrar afastamento";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(301, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 156;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(119, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 155;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(21, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 154;
            this.label7.Text = "Data inicial:";
            // 
            // text_data_inicio_afastamentos
            // 
            this.text_data_inicio_afastamentos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.text_data_inicio_afastamentos.BorderSize = 0;
            this.text_data_inicio_afastamentos.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_inicio_afastamentos.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_inicio_afastamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_inicio_afastamentos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_data_inicio_afastamentos.Location = new System.Drawing.Point(25, 129);
            this.text_data_inicio_afastamentos.MinimumSize = new System.Drawing.Size(4, 35);
            this.text_data_inicio_afastamentos.Name = "text_data_inicio_afastamentos";
            this.text_data_inicio_afastamentos.Size = new System.Drawing.Size(222, 35);
            this.text_data_inicio_afastamentos.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_data_inicio_afastamentos.TabIndex = 153;
            this.text_data_inicio_afastamentos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // text_investigador
            // 
            this.text_investigador.BackColor = System.Drawing.Color.Transparent;
            this.text_investigador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_investigador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_investigador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_investigador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_investigador.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_investigador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_investigador.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_investigador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_investigador.ItemHeight = 30;
            this.text_investigador.Location = new System.Drawing.Point(25, 56);
            this.text_investigador.Name = "text_investigador";
            this.text_investigador.Size = new System.Drawing.Size(463, 36);
            this.text_investigador.TabIndex = 149;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(121, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 21);
            this.label10.TabIndex = 148;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(21, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 147;
            this.label9.Text = "Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(114, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 159;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 158;
            this.label4.Text = "Descrição:";
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
            this.text_descricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_descricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_descricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_descricao.Location = new System.Drawing.Point(29, 201);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_descricao.Multiline = true;
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.PasswordChar = '\0';
            this.text_descricao.PlaceholderText = "";
            this.text_descricao.SelectedText = "";
            this.text_descricao.Size = new System.Drawing.Size(459, 94);
            this.text_descricao.TabIndex = 157;
            this.text_descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_descricao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(339, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 162;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(249, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 161;
            this.label2.Text = "Data final:";
            // 
            // text_data_final_afastamentos
            // 
            this.text_data_final_afastamentos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.text_data_final_afastamentos.BorderSize = 0;
            this.text_data_final_afastamentos.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_final_afastamentos.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_final_afastamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_final_afastamentos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_data_final_afastamentos.Location = new System.Drawing.Point(253, 129);
            this.text_data_final_afastamentos.MinimumSize = new System.Drawing.Size(4, 35);
            this.text_data_final_afastamentos.Name = "text_data_final_afastamentos";
            this.text_data_final_afastamentos.Size = new System.Drawing.Size(235, 35);
            this.text_data_final_afastamentos.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_data_final_afastamentos.TabIndex = 160;
            this.text_data_final_afastamentos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Limpar);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btn_Atualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 89);
            this.panel2.TabIndex = 166;
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
            this.btn_Limpar.Location = new System.Drawing.Point(183, 35);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(146, 45);
            this.btn_Limpar.TabIndex = 133;
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
            this.btn_salvar.Location = new System.Drawing.Point(26, 36);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(146, 45);
            this.btn_salvar.TabIndex = 132;
            this.btn_salvar.Text = "Registrar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.ForeColor = System.Drawing.Color.Tomato;
            this.label12.Location = new System.Drawing.Point(29, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 19);
            this.label12.TabIndex = 128;
            this.label12.Text = "Os campos com o (";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(29, 15);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(451, 21);
            this.guna2Separator1.TabIndex = 131;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label13.ForeColor = System.Drawing.Color.Tomato;
            this.label13.Location = new System.Drawing.Point(168, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 21);
            this.label13.TabIndex = 129;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.ForeColor = System.Drawing.Color.Tomato;
            this.label14.Location = new System.Drawing.Point(179, -2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 19);
            this.label14.TabIndex = 130;
            this.label14.Text = ") são de preenchimento obrigatório.";
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
            this.btn_Atualizar.Location = new System.Drawing.Point(26, 36);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_Atualizar.TabIndex = 198;
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
            // text_Estado
            // 
            this.text_Estado.BackColor = System.Drawing.Color.Transparent;
            this.text_Estado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_Estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_Estado.DropDownHeight = 250;
            this.text_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_Estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_Estado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Estado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Estado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_Estado.IntegralHeight = false;
            this.text_Estado.ItemHeight = 30;
            this.text_Estado.Items.AddRange(new object[] {
            "Ativo",
            "Terminado",
            "Cancelado"});
            this.text_Estado.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.text_Estado.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Estado.Location = new System.Drawing.Point(29, 347);
            this.text_Estado.Name = "text_Estado";
            this.text_Estado.Size = new System.Drawing.Size(459, 36);
            this.text_Estado.StartIndex = 0;
            this.text_Estado.TabIndex = 167;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(89, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 169;
            this.label6.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(31, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 168;
            this.label15.Text = "Mensagem de erro.";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(24, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 21);
            this.label16.TabIndex = 170;
            this.label16.Text = "Estado:";
            // 
            // Form_Modulo_Afastamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(509, 487);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.text_Estado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_data_final_afastamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_descricao);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_data_inicio_afastamentos);
            this.Controls.Add(this.text_investigador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Modulo_Afastamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Modulo_Afastamentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public CustomBox.RJControls.RJDatePicker text_data_inicio_afastamentos;
        public Guna.UI2.WinForms.Guna2ComboBox text_investigador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox text_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public CustomBox.RJControls.RJDatePicker text_data_final_afastamentos;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Limpar;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog_Error;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        public Guna.UI2.WinForms.Guna2ComboBox text_Estado;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2Button btn_salvar;
        public Guna.UI2.WinForms.Guna2Button btn_Atualizar;
    }
}