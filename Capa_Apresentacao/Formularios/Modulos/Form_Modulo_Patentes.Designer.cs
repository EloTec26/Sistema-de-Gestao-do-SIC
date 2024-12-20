namespace Capa_Apresentacao.Formularios.Modulos
{
    partial class Form_Modulo_Patentes
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.text_descricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_patentes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_msg_patente = new System.Windows.Forms.Label();
            this.label_msg_descricao = new System.Windows.Forms.Label();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MessageDialog_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btn_Atualizar = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.Size = new System.Drawing.Size(487, 28);
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
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Registrar patente";
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
            this.btn_Limpar.Location = new System.Drawing.Point(173, 335);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(146, 45);
            this.btn_Limpar.TabIndex = 155;
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
            this.btn_salvar.Location = new System.Drawing.Point(19, 335);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(146, 45);
            this.btn_salvar.TabIndex = 154;
            this.btn_salvar.Text = "Registrar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(19, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 150;
            this.label4.Text = "Os campos com o (";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(19, 319);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(450, 10);
            this.guna2Separator1.TabIndex = 153;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(158, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 151;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(169, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 19);
            this.label6.TabIndex = 152;
            this.label6.Text = ") são de preenchimento obrigatório.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(154, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 21);
            this.label10.TabIndex = 145;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(15, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 21);
            this.label9.TabIndex = 144;
            this.label9.Text = "Digite a patente:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Red;
            this.label_id.Location = new System.Drawing.Point(379, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 143;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
            // 
            // text_descricao
            // 
            this.text_descricao.AcceptsReturn = true;
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
            this.text_descricao.Location = new System.Drawing.Point(19, 166);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_descricao.Multiline = true;
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.PasswordChar = '\0';
            this.text_descricao.PlaceholderText = "";
            this.text_descricao.SelectedText = "";
            this.text_descricao.Size = new System.Drawing.Size(450, 101);
            this.text_descricao.TabIndex = 140;
            this.text_descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_descricao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(19, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 141;
            this.label1.Text = "Descrição:";
            // 
            // text_patentes
            // 
            this.text_patentes.AcceptsReturn = true;
            this.text_patentes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_patentes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_patentes.DefaultText = "";
            this.text_patentes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_patentes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_patentes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_patentes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_patentes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_patentes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(223)))));
            this.text_patentes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_patentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.text_patentes.Location = new System.Drawing.Point(19, 76);
            this.text_patentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_patentes.Name = "text_patentes";
            this.text_patentes.PasswordChar = '\0';
            this.text_patentes.PlaceholderText = "";
            this.text_patentes.SelectedText = "";
            this.text_patentes.Size = new System.Drawing.Size(450, 36);
            this.text_patentes.TabIndex = 156;
            this.text_patentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_patentes_KeyPress);
            // 
            // label_msg_patente
            // 
            this.label_msg_patente.AutoSize = true;
            this.label_msg_patente.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_patente.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_patente.Location = new System.Drawing.Point(22, 116);
            this.label_msg_patente.Name = "label_msg_patente";
            this.label_msg_patente.Size = new System.Drawing.Size(120, 17);
            this.label_msg_patente.TabIndex = 194;
            this.label_msg_patente.Text = "mensagem de erro";
            this.label_msg_patente.Visible = false;
            // 
            // label_msg_descricao
            // 
            this.label_msg_descricao.AutoSize = true;
            this.label_msg_descricao.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_msg_descricao.ForeColor = System.Drawing.Color.Tomato;
            this.label_msg_descricao.Location = new System.Drawing.Point(22, 271);
            this.label_msg_descricao.Name = "label_msg_descricao";
            this.label_msg_descricao.Size = new System.Drawing.Size(120, 17);
            this.label_msg_descricao.TabIndex = 195;
            this.label_msg_descricao.Text = "mensagem de erro";
            this.label_msg_descricao.Visible = false;
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
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 4;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.9D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btn_Atualizar.Location = new System.Drawing.Point(19, 335);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_Atualizar.TabIndex = 196;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // Form_Modulo_Patentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(487, 396);
            this.Controls.Add(this.label_msg_descricao);
            this.Controls.Add(this.label_msg_patente);
            this.Controls.Add(this.text_patentes);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.text_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Atualizar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Modulo_Patentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Modulo_Patentes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Fechar;
        private Guna.UI2.WinForms.Guna2Button btn_Limpar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label_id;
        public Guna.UI2.WinForms.Guna2TextBox text_descricao;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox text_patentes;
        public System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2Button btn_salvar;
        private System.Windows.Forms.Label label_msg_patente;
        private System.Windows.Forms.Label label_msg_descricao;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog_Error;
        public Guna.UI2.WinForms.Guna2Button btn_Atualizar;
    }
}