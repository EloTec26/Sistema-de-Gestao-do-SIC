namespace Capa_Apresentacao.Formularios.Modulos
{
    partial class Form_Modulo_Bairro_Rua
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
            this.text_municipio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.text_bairro_rua = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Limpar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_salvar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageDialog_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label_msg_bairro_rua = new System.Windows.Forms.Label();
            this.btn_Atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_municipio
            // 
            this.text_municipio.BackColor = System.Drawing.Color.Transparent;
            this.text_municipio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_municipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_municipio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_municipio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_municipio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_municipio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text_municipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_municipio.ItemHeight = 30;
            this.text_municipio.Location = new System.Drawing.Point(16, 84);
            this.text_municipio.Name = "text_municipio";
            this.text_municipio.Size = new System.Drawing.Size(450, 36);
            this.text_municipio.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(192, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 21);
            this.label10.TabIndex = 82;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 21);
            this.label9.TabIndex = 81;
            this.label9.Text = "Selecione o munícipio:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(376, 48);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 80;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 28);
            this.panel1.TabIndex = 69;
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
            this.btn_Fechar.Location = new System.Drawing.Point(462, 1);
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
            this.label5.Text = "Registrar bairro/rua";
            // 
            // text_bairro_rua
            // 
            this.text_bairro_rua.AcceptsReturn = true;
            this.text_bairro_rua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_bairro_rua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_bairro_rua.DefaultText = "";
            this.text_bairro_rua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_bairro_rua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_bairro_rua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_bairro_rua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_bairro_rua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_bairro_rua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(223)))));
            this.text_bairro_rua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_bairro_rua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_bairro_rua.Location = new System.Drawing.Point(16, 167);
            this.text_bairro_rua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_bairro_rua.Name = "text_bairro_rua";
            this.text_bairro_rua.PasswordChar = '\0';
            this.text_bairro_rua.PlaceholderText = "";
            this.text_bairro_rua.SelectedText = "";
            this.text_bairro_rua.Size = new System.Drawing.Size(450, 36);
            this.text_bairro_rua.TabIndex = 71;
            this.text_bairro_rua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_bairro_rua_KeyPress);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(16, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Insira o nome de um bairro/rua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(272, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "*";
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
            this.btn_Limpar.Location = new System.Drawing.Point(172, 263);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(146, 45);
            this.btn_Limpar.TabIndex = 139;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click_1);
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
            this.btn_salvar.Location = new System.Drawing.Point(15, 263);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(146, 45);
            this.btn_salvar.TabIndex = 138;
            this.btn_salvar.Text = "Registrar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 134;
            this.label4.Text = "Os campos com o (";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(18, 252);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(451, 10);
            this.guna2Separator1.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(157, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 135;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(168, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 19);
            this.label6.TabIndex = 136;
            this.label6.Text = ") são de preenchimento obrigatório.";
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
            // guna2MessageDialog_Confirm
            // 
            this.guna2MessageDialog_Confirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog_Confirm.Caption = null;
            this.guna2MessageDialog_Confirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog_Confirm.Parent = this;
            this.guna2MessageDialog_Confirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog_Confirm.Text = null;
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
            // label_msg_bairro_rua
            // 
            this.label_msg_bairro_rua.AutoSize = true;
            this.label_msg_bairro_rua.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_bairro_rua.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_bairro_rua.Location = new System.Drawing.Point(19, 207);
            this.label_msg_bairro_rua.Name = "label_msg_bairro_rua";
            this.label_msg_bairro_rua.Size = new System.Drawing.Size(120, 17);
            this.label_msg_bairro_rua.TabIndex = 197;
            this.label_msg_bairro_rua.Text = "mensagem de erro";
            this.label_msg_bairro_rua.Visible = false;
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
            this.btn_Atualizar.Location = new System.Drawing.Point(15, 263);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_Atualizar.TabIndex = 198;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // Form_Modulo_Bairro_Rua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(487, 327);
            this.Controls.Add(this.label_msg_bairro_rua);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_municipio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_bairro_rua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Atualizar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Modulo_Bairro_Rua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Modulo_Bairro_Rua";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ComboBox text_municipio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        public Guna.UI2.WinForms.Guna2TextBox text_bairro_rua;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Limpar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog_Error;
        public Guna.UI2.WinForms.Guna2Button btn_salvar;
        private System.Windows.Forms.Label label_msg_bairro_rua;
        public Guna.UI2.WinForms.Guna2Button btn_Atualizar;
    }
}