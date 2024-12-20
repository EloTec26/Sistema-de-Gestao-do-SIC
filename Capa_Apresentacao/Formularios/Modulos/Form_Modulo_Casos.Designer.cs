namespace Capa_Apresentacao.Formularios.Modulos
{
    partial class Form_Modulo_Casos
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
            this.btn_Limpar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_salvar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MessageDialog_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.panel_formulario = new System.Windows.Forms.Panel();
            this.label_msg_descricao = new System.Windows.Forms.Label();
            this.label_msg_casos = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.text_descricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.text_data_fechamento = new CustomBox.RJControls.RJDatePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_departamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_investigador = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.text_estado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_titulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_data_abetura = new CustomBox.RJControls.RJDatePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 28);
            this.panel1.TabIndex = 117;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_Fechar.IconColor = System.Drawing.Color.White;
            this.btn_Fechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Fechar.IconSize = 30;
            this.btn_Fechar.Location = new System.Drawing.Point(482, 2);
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
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 88;
            this.label5.Text = "Registrar caso";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(394, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 140;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
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
            this.btn_Limpar.Location = new System.Drawing.Point(177, 38);
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
            this.btn_salvar.Location = new System.Drawing.Point(25, 38);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(146, 45);
            this.btn_salvar.TabIndex = 132;
            this.btn_salvar.Text = "Registrar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(23, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "Os campos com o (";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(23, 20);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(451, 12);
            this.guna2Separator1.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(162, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 129;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(173, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 19);
            this.label6.TabIndex = 130;
            this.label6.Text = ") são de preenchimento obrigatório.";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_Limpar);
            this.panel2.Controls.Add(this.btn_Atualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 95);
            this.panel2.TabIndex = 150;
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
            this.btn_Atualizar.Location = new System.Drawing.Point(25, 38);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_Atualizar.TabIndex = 200;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // panel_formulario
            // 
            this.panel_formulario.AutoScroll = true;
            this.panel_formulario.Controls.Add(this.label_msg_descricao);
            this.panel_formulario.Controls.Add(this.label_msg_casos);
            this.panel_formulario.Controls.Add(this.label19);
            this.panel_formulario.Controls.Add(this.label20);
            this.panel_formulario.Controls.Add(this.text_descricao);
            this.panel_formulario.Controls.Add(this.label17);
            this.panel_formulario.Controls.Add(this.label18);
            this.panel_formulario.Controls.Add(this.text_data_fechamento);
            this.panel_formulario.Controls.Add(this.label13);
            this.panel_formulario.Controls.Add(this.label14);
            this.panel_formulario.Controls.Add(this.text_departamento);
            this.panel_formulario.Controls.Add(this.text_investigador);
            this.panel_formulario.Controls.Add(this.label11);
            this.panel_formulario.Controls.Add(this.label12);
            this.panel_formulario.Controls.Add(this.text_estado);
            this.panel_formulario.Controls.Add(this.label9);
            this.panel_formulario.Controls.Add(this.label10);
            this.panel_formulario.Controls.Add(this.label1);
            this.panel_formulario.Controls.Add(this.label2);
            this.panel_formulario.Controls.Add(this.text_titulo);
            this.panel_formulario.Controls.Add(this.label8);
            this.panel_formulario.Controls.Add(this.label7);
            this.panel_formulario.Controls.Add(this.text_data_abetura);
            this.panel_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_formulario.Location = new System.Drawing.Point(0, 28);
            this.panel_formulario.Name = "panel_formulario";
            this.panel_formulario.Size = new System.Drawing.Size(508, 443);
            this.panel_formulario.TabIndex = 151;
            // 
            // label_msg_descricao
            // 
            this.label_msg_descricao.AutoSize = true;
            this.label_msg_descricao.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_descricao.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_descricao.Location = new System.Drawing.Point(24, 553);
            this.label_msg_descricao.Name = "label_msg_descricao";
            this.label_msg_descricao.Size = new System.Drawing.Size(120, 17);
            this.label_msg_descricao.TabIndex = 200;
            this.label_msg_descricao.Text = "mensagem de erro";
            this.label_msg_descricao.Visible = false;
            // 
            // label_msg_casos
            // 
            this.label_msg_casos.AutoSize = true;
            this.label_msg_casos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_casos.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_casos.Location = new System.Drawing.Point(24, 243);
            this.label_msg_casos.Name = "label_msg_casos";
            this.label_msg_casos.Size = new System.Drawing.Size(120, 17);
            this.label_msg_casos.TabIndex = 199;
            this.label_msg_casos.Text = "mensagem de erro";
            this.label_msg_casos.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Tomato;
            this.label19.Location = new System.Drawing.Point(106, 434);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 21);
            this.label19.TabIndex = 173;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.Location = new System.Drawing.Point(17, 434);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 21);
            this.label20.TabIndex = 172;
            this.label20.Text = "Descrição:";
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
            this.text_descricao.Location = new System.Drawing.Point(21, 459);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_descricao.Multiline = true;
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.PasswordChar = '\0';
            this.text_descricao.PlaceholderText = "";
            this.text_descricao.SelectedText = "";
            this.text_descricao.Size = new System.Drawing.Size(465, 90);
            this.text_descricao.TabIndex = 171;
            this.text_descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_descricao_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(428, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 21);
            this.label17.TabIndex = 170;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.Location = new System.Drawing.Point(250, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 21);
            this.label18.TabIndex = 169;
            this.label18.Text = "Data de fechamento:";
            // 
            // text_data_fechamento
            // 
            this.text_data_fechamento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.text_data_fechamento.BorderSize = 0;
            this.text_data_fechamento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_fechamento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_fechamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_fechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_data_fechamento.Location = new System.Drawing.Point(253, 291);
            this.text_data_fechamento.MinimumSize = new System.Drawing.Size(4, 35);
            this.text_data_fechamento.Name = "text_data_fechamento";
            this.text_data_fechamento.Size = new System.Drawing.Size(233, 35);
            this.text_data_fechamento.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_data_fechamento.TabIndex = 168;
            this.text_data_fechamento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Tomato;
            this.label13.Location = new System.Drawing.Point(76, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 21);
            this.label13.TabIndex = 164;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(19, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 21);
            this.label14.TabIndex = 163;
            this.label14.Text = "Título:";
            // 
            // text_departamento
            // 
            this.text_departamento.BackColor = System.Drawing.Color.Transparent;
            this.text_departamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_departamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_departamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_departamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_departamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_departamento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_departamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_departamento.ItemHeight = 30;
            this.text_departamento.Location = new System.Drawing.Point(23, 121);
            this.text_departamento.Name = "text_departamento";
            this.text_departamento.Size = new System.Drawing.Size(463, 36);
            this.text_departamento.TabIndex = 162;
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
            this.text_investigador.Location = new System.Drawing.Point(23, 37);
            this.text_investigador.Name = "text_investigador";
            this.text_investigador.Size = new System.Drawing.Size(463, 36);
            this.text_investigador.TabIndex = 161;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(218, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 21);
            this.label11.TabIndex = 160;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(19, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 21);
            this.label12.TabIndex = 159;
            this.label12.Text = "Selecione o funcionário:";
            // 
            // text_estado
            // 
            this.text_estado.BackColor = System.Drawing.Color.Transparent;
            this.text_estado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_estado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_estado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_estado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_estado.ItemHeight = 30;
            this.text_estado.Items.AddRange(new object[] {
            "Aberto",
            "Encerrado",
            "Pendente",
            "Cancelado"});
            this.text_estado.Location = new System.Drawing.Point(23, 374);
            this.text_estado.Name = "text_estado";
            this.text_estado.Size = new System.Drawing.Size(463, 36);
            this.text_estado.StartIndex = 0;
            this.text_estado.TabIndex = 158;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(84, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 21);
            this.label9.TabIndex = 157;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(19, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 156;
            this.label10.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(249, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 155;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 21);
            this.label2.TabIndex = 154;
            this.label2.Text = "Selecione o departamento:";
            // 
            // text_titulo
            // 
            this.text_titulo.AcceptsReturn = true;
            this.text_titulo.Animated = true;
            this.text_titulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_titulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_titulo.DefaultText = "";
            this.text_titulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_titulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_titulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_titulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_titulo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_titulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_titulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_titulo.Location = new System.Drawing.Point(23, 203);
            this.text_titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_titulo.Name = "text_titulo";
            this.text_titulo.PasswordChar = '\0';
            this.text_titulo.PlaceholderText = "";
            this.text_titulo.SelectedText = "";
            this.text_titulo.Size = new System.Drawing.Size(463, 36);
            this.text_titulo.TabIndex = 153;
            this.text_titulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_titulo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(171, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 152;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(19, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 151;
            this.label7.Text = "Data de abertura:";
            // 
            // text_data_abetura
            // 
            this.text_data_abetura.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.text_data_abetura.BorderSize = 0;
            this.text_data_abetura.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_abetura.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_data_abetura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_abetura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.text_data_abetura.Location = new System.Drawing.Point(23, 291);
            this.text_data_abetura.MinimumSize = new System.Drawing.Size(4, 35);
            this.text_data_abetura.Name = "text_data_abetura";
            this.text_data_abetura.Size = new System.Drawing.Size(220, 35);
            this.text_data_abetura.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_data_abetura.TabIndex = 150;
            this.text_data_abetura.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            // 
            // Form_Modulo_Casos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(508, 566);
            this.Controls.Add(this.panel_formulario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Modulo_Casos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de casos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_formulario.ResumeLayout(false);
            this.panel_formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        public System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_Limpar;
        public Guna.UI2.WinForms.Guna2Button btn_salvar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog_Error;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Panel panel_formulario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public Guna.UI2.WinForms.Guna2TextBox text_descricao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public CustomBox.RJControls.RJDatePicker text_data_fechamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public Guna.UI2.WinForms.Guna2ComboBox text_departamento;
        public Guna.UI2.WinForms.Guna2ComboBox text_investigador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2ComboBox text_estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox text_titulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public CustomBox.RJControls.RJDatePicker text_data_abetura;
        private System.Windows.Forms.Label label_msg_casos;
        private System.Windows.Forms.Label label_msg_descricao;
        public Guna.UI2.WinForms.Guna2Button btn_Atualizar;
    }
}