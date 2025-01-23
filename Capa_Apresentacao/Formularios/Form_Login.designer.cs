namespace Capa_Apresentacao
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Maximizar = new FontAwesome.Sharp.IconButton();
            this.btn_Fechar = new FontAwesome.Sharp.IconButton();
            this.btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.btn_Restaurar = new FontAwesome.Sharp.IconButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label_erro = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_visualizar_palavra_passe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.text_palavra_passe = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Limpar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_iniciar_sessao = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_minutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.check_caracter_especial = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_letra_maiuscula = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_letra_minuscula = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_numero = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_oito_caracteres = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(74, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "SERVIÇOS DE INVESTIGAÇÃO CRIMINAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btn_Maximizar);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Minimizar);
            this.panel1.Controls.Add(this.btn_Restaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 21);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.FlatAppearance.BorderSize = 0;
            this.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximizar.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn_Maximizar.IconColor = System.Drawing.Color.White;
            this.btn_Maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximizar.IconSize = 20;
            this.btn_Maximizar.Location = new System.Drawing.Point(432, 1);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(15, 15);
            this.btn_Maximizar.TabIndex = 1;
            this.btn_Maximizar.UseVisualStyleBackColor = true;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_Fechar.IconColor = System.Drawing.Color.White;
            this.btn_Fechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Fechar.IconSize = 20;
            this.btn_Fechar.Location = new System.Drawing.Point(458, 2);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(15, 15);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click_1);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimizar.IconColor = System.Drawing.Color.White;
            this.btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimizar.IconSize = 20;
            this.btn_Minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Minimizar.Location = new System.Drawing.Point(411, 2);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(15, 15);
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click_1);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.FlatAppearance.BorderSize = 0;
            this.btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btn_Restaurar.IconColor = System.Drawing.Color.White;
            this.btn_Restaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Restaurar.IconSize = 20;
            this.btn_Restaurar.Location = new System.Drawing.Point(432, 1);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(15, 15);
            this.btn_Restaurar.TabIndex = 14;
            this.btn_Restaurar.UseVisualStyleBackColor = true;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(148, 27);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(162, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label_erro
            // 
            this.label_erro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_erro.AutoSize = true;
            this.label_erro.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_erro.ForeColor = System.Drawing.Color.Tomato;
            this.label_erro.Location = new System.Drawing.Point(12, 261);
            this.label_erro.Name = "label_erro";
            this.label_erro.Size = new System.Drawing.Size(130, 19);
            this.label_erro.TabIndex = 15;
            this.label_erro.Text = "Nome de usuário:";
            this.label_erro.Visible = false;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 300;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 4;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Silver;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_visualizar_palavra_passe
            // 
            this.btn_visualizar_palavra_passe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_visualizar_palavra_passe.Animated = true;
            this.btn_visualizar_palavra_passe.AutoSize = true;
            this.btn_visualizar_palavra_passe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_visualizar_palavra_passe.CheckedState.BorderRadius = 0;
            this.btn_visualizar_palavra_passe.CheckedState.BorderThickness = 0;
            this.btn_visualizar_palavra_passe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_visualizar_palavra_passe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_visualizar_palavra_passe.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar_palavra_passe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_visualizar_palavra_passe.Location = new System.Drawing.Point(14, 239);
            this.btn_visualizar_palavra_passe.Name = "btn_visualizar_palavra_passe";
            this.btn_visualizar_palavra_passe.Size = new System.Drawing.Size(200, 23);
            this.btn_visualizar_palavra_passe.TabIndex = 19;
            this.btn_visualizar_palavra_passe.Text = "  Exibir a palavra-passe...";
            this.btn_visualizar_palavra_passe.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.btn_visualizar_palavra_passe.UncheckedState.BorderRadius = 0;
            this.btn_visualizar_palavra_passe.UncheckedState.BorderThickness = 0;
            this.btn_visualizar_palavra_passe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_visualizar_palavra_passe.CheckedChanged += new System.EventHandler(this.btn_visualizar_palavra_passe_CheckedChanged);
            // 
            // text_palavra_passe
            // 
            this.text_palavra_passe.AcceptsReturn = true;
            this.text_palavra_passe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_palavra_passe.Animated = true;
            this.text_palavra_passe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_palavra_passe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_palavra_passe.DefaultText = "";
            this.text_palavra_passe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_palavra_passe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_palavra_passe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_palavra_passe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_palavra_passe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_palavra_passe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_palavra_passe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_palavra_passe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_palavra_passe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_palavra_passe.Location = new System.Drawing.Point(12, 199);
            this.text_palavra_passe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_palavra_passe.MaxLength = 16;
            this.text_palavra_passe.Name = "text_palavra_passe";
            this.text_palavra_passe.PasswordChar = '\0';
            this.text_palavra_passe.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.text_palavra_passe.PlaceholderText = "Insira a sua palavra-passe de início de sessão...";
            this.text_palavra_passe.SelectedText = "";
            this.text_palavra_passe.Size = new System.Drawing.Size(451, 36);
            this.text_palavra_passe.TabIndex = 129;
            this.text_palavra_passe.TextChanged += new System.EventHandler(this.text_palavra_passe_TextChanged);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Limpar.BorderRadius = 4;
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Limpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Limpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Limpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Limpar.FillColor = System.Drawing.Color.Tomato;
            this.btn_Limpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(164, 364);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(146, 45);
            this.btn_Limpar.TabIndex = 130;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_iniciar_sessao
            // 
            this.btn_iniciar_sessao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_iniciar_sessao.Animated = true;
            this.btn_iniciar_sessao.AnimatedGIF = true;
            this.btn_iniciar_sessao.BorderRadius = 4;
            this.btn_iniciar_sessao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar_sessao.DisabledState.BorderColor = System.Drawing.Color.Tomato;
            this.btn_iniciar_sessao.DisabledState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.btn_iniciar_sessao.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btn_iniciar_sessao.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar_sessao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_sessao.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar_sessao.Location = new System.Drawing.Point(12, 364);
            this.btn_iniciar_sessao.Name = "btn_iniciar_sessao";
            this.btn_iniciar_sessao.Size = new System.Drawing.Size(146, 45);
            this.btn_iniciar_sessao.TabIndex = 129;
            this.btn_iniciar_sessao.Text = "Iniciar sessão";
            this.btn_iniciar_sessao.Click += new System.EventHandler(this.btn_iniciar_sessao_Click_1);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Separator1.Location = new System.Drawing.Point(13, 334);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(451, 10);
            this.guna2Separator1.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(142, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 134;
            this.label7.Text = "- 2024";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 133;
            this.label6.Text = "Copyright";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(379, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 132;
            this.label3.Text = "versão: 1.0.0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(92, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 131;
            this.label4.Text = "© SIC";
            // 
            // label_minutos
            // 
            this.label_minutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_minutos.AutoSize = true;
            this.label_minutos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_minutos.ForeColor = System.Drawing.Color.Tomato;
            this.label_minutos.Location = new System.Drawing.Point(12, 302);
            this.label_minutos.Name = "label_minutos";
            this.label_minutos.Size = new System.Drawing.Size(130, 19);
            this.label_minutos.TabIndex = 135;
            this.label_minutos.Text = "Nome de usuário:";
            this.label_minutos.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "Armindo Tito";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(405, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 137;
            this.label5.Text = "UCC";
            // 
            // check_caracter_especial
            // 
            this.check_caracter_especial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_caracter_especial.Animated = true;
            this.check_caracter_especial.AutoSize = true;
            this.check_caracter_especial.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_caracter_especial.CheckedState.BorderRadius = 0;
            this.check_caracter_especial.CheckedState.BorderThickness = 0;
            this.check_caracter_especial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_caracter_especial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_caracter_especial.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_caracter_especial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.check_caracter_especial.Location = new System.Drawing.Point(16, 412);
            this.check_caracter_especial.Name = "check_caracter_especial";
            this.check_caracter_especial.Size = new System.Drawing.Size(259, 23);
            this.check_caracter_especial.TabIndex = 138;
            this.check_caracter_especial.Text = "  Ao menos um caracter especial;";
            this.check_caracter_especial.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.check_caracter_especial.UncheckedState.BorderRadius = 0;
            this.check_caracter_especial.UncheckedState.BorderThickness = 0;
            this.check_caracter_especial.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_caracter_especial.Visible = false;
            // 
            // check_letra_maiuscula
            // 
            this.check_letra_maiuscula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_letra_maiuscula.Animated = true;
            this.check_letra_maiuscula.AutoSize = true;
            this.check_letra_maiuscula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_letra_maiuscula.CheckedState.BorderRadius = 0;
            this.check_letra_maiuscula.CheckedState.BorderThickness = 0;
            this.check_letra_maiuscula.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_letra_maiuscula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_letra_maiuscula.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_letra_maiuscula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.check_letra_maiuscula.Location = new System.Drawing.Point(14, 412);
            this.check_letra_maiuscula.Name = "check_letra_maiuscula";
            this.check_letra_maiuscula.Size = new System.Drawing.Size(253, 23);
            this.check_letra_maiuscula.TabIndex = 138;
            this.check_letra_maiuscula.Text = "  Ao menos uma letra maiúscula;";
            this.check_letra_maiuscula.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.check_letra_maiuscula.UncheckedState.BorderRadius = 0;
            this.check_letra_maiuscula.UncheckedState.BorderThickness = 0;
            this.check_letra_maiuscula.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_letra_maiuscula.Visible = false;
            // 
            // check_letra_minuscula
            // 
            this.check_letra_minuscula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_letra_minuscula.Animated = true;
            this.check_letra_minuscula.AutoSize = true;
            this.check_letra_minuscula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_letra_minuscula.CheckedState.BorderRadius = 0;
            this.check_letra_minuscula.CheckedState.BorderThickness = 0;
            this.check_letra_minuscula.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_letra_minuscula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_letra_minuscula.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_letra_minuscula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.check_letra_minuscula.Location = new System.Drawing.Point(14, 412);
            this.check_letra_minuscula.Name = "check_letra_minuscula";
            this.check_letra_minuscula.Size = new System.Drawing.Size(252, 23);
            this.check_letra_minuscula.TabIndex = 138;
            this.check_letra_minuscula.Text = "  Ao menos uma letra minúscula;";
            this.check_letra_minuscula.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.check_letra_minuscula.UncheckedState.BorderRadius = 0;
            this.check_letra_minuscula.UncheckedState.BorderThickness = 0;
            this.check_letra_minuscula.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_letra_minuscula.Visible = false;
            // 
            // check_numero
            // 
            this.check_numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_numero.Animated = true;
            this.check_numero.AutoSize = true;
            this.check_numero.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_numero.CheckedState.BorderRadius = 0;
            this.check_numero.CheckedState.BorderThickness = 0;
            this.check_numero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_numero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_numero.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.check_numero.Location = new System.Drawing.Point(14, 412);
            this.check_numero.Name = "check_numero";
            this.check_numero.Size = new System.Drawing.Size(190, 23);
            this.check_numero.TabIndex = 138;
            this.check_numero.Text = "  Ao menos um número;";
            this.check_numero.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.check_numero.UncheckedState.BorderRadius = 0;
            this.check_numero.UncheckedState.BorderThickness = 0;
            this.check_numero.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_numero.Visible = false;
            // 
            // check_oito_caracteres
            // 
            this.check_oito_caracteres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_oito_caracteres.Animated = true;
            this.check_oito_caracteres.AutoSize = true;
            this.check_oito_caracteres.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_oito_caracteres.CheckedState.BorderRadius = 0;
            this.check_oito_caracteres.CheckedState.BorderThickness = 0;
            this.check_oito_caracteres.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_oito_caracteres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_oito_caracteres.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_oito_caracteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.check_oito_caracteres.Location = new System.Drawing.Point(16, 412);
            this.check_oito_caracteres.Name = "check_oito_caracteres";
            this.check_oito_caracteres.Size = new System.Drawing.Size(230, 23);
            this.check_oito_caracteres.TabIndex = 138;
            this.check_oito_caracteres.Text = "  No mínio oito (8) caracteres.";
            this.check_oito_caracteres.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.check_oito_caracteres.UncheckedState.BorderRadius = 0;
            this.check_oito_caracteres.UncheckedState.BorderThickness = 0;
            this.check_oito_caracteres.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_oito_caracteres.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(178, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 139;
            this.label8.Text = "MENONGUE";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(476, 482);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.check_oito_caracteres);
            this.Controls.Add(this.check_numero);
            this.Controls.Add(this.check_letra_minuscula);
            this.Controls.Add(this.check_letra_maiuscula);
            this.Controls.Add(this.check_caracter_especial);
            this.Controls.Add(this.btn_visualizar_palavra_passe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label_minutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_palavra_passe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label_erro);
            this.Controls.Add(this.btn_iniciar_sessao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Separator1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        private FontAwesome.Sharp.IconButton btn_Minimizar;
        private FontAwesome.Sharp.IconButton btn_Restaurar;
        private FontAwesome.Sharp.IconButton btn_Maximizar;
        private System.Windows.Forms.Label label_erro;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CheckBox btn_visualizar_palavra_passe;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox text_palavra_passe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_Limpar;
        private Guna.UI2.WinForms.Guna2Button btn_iniciar_sessao;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_minutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2CheckBox check_oito_caracteres;
        private Guna.UI2.WinForms.Guna2CheckBox check_numero;
        private Guna.UI2.WinForms.Guna2CheckBox check_letra_minuscula;
        private Guna.UI2.WinForms.Guna2CheckBox check_letra_maiuscula;
        private Guna.UI2.WinForms.Guna2CheckBox check_caracter_especial;
        private System.Windows.Forms.Label label8;
    }
}

