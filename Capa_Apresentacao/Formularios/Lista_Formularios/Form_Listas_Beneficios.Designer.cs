namespace Capa_Apresentacao.Formularios.Lista_Formularios
{
    partial class Form_Listas_Beneficios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.text_pesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_atualizar = new FontAwesome.Sharp.IconButton();
            this.btn_cadastrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_beneficios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2MessageDialog1_Error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog_Inform = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_beneficios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.text_pesquisar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 40);
            this.panel1.TabIndex = 18;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(490, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(36, 36);
            this.iconButton3.TabIndex = 43;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // text_pesquisar
            // 
            this.text_pesquisar.AcceptsReturn = true;
            this.text_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_pesquisar.Animated = true;
            this.text_pesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_pesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pesquisar.DefaultText = "";
            this.text_pesquisar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_pesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_pesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pesquisar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.text_pesquisar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pesquisar.ForeColor = System.Drawing.Color.Gainsboro;
            this.text_pesquisar.Location = new System.Drawing.Point(527, 2);
            this.text_pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_pesquisar.MaxLength = 10;
            this.text_pesquisar.Name = "text_pesquisar";
            this.text_pesquisar.PasswordChar = '\0';
            this.text_pesquisar.PlaceholderText = "Pesquisar...";
            this.text_pesquisar.SelectedText = "";
            this.text_pesquisar.Size = new System.Drawing.Size(234, 36);
            this.text_pesquisar.TabIndex = 42;
            this.text_pesquisar.TextChanged += new System.EventHandler(this.text_pesquisar_TextChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btn_eliminar.IconColor = System.Drawing.Color.Tomato;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 20;
            this.btn_eliminar.Location = new System.Drawing.Point(204, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(46, 31);
            this.btn_eliminar.TabIndex = 41;
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.btn_atualizar.IconColor = System.Drawing.Color.SeaGreen;
            this.btn_atualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_atualizar.IconSize = 20;
            this.btn_atualizar.Location = new System.Drawing.Point(147, 5);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(51, 31);
            this.btn_atualizar.TabIndex = 40;
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btn_cadastrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_cadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cadastrar.IconSize = 20;
            this.btn_cadastrar.Location = new System.Drawing.Point(90, 6);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(51, 31);
            this.btn_cadastrar.TabIndex = 39;
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Benefícios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_beneficios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 263);
            this.panel2.TabIndex = 19;
            // 
            // dgv_beneficios
            // 
            this.dgv_beneficios.AllowUserToAddRows = false;
            this.dgv_beneficios.AllowUserToDeleteRows = false;
            this.dgv_beneficios.AllowUserToOrderColumns = true;
            this.dgv_beneficios.AllowUserToResizeColumns = false;
            this.dgv_beneficios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.dgv_beneficios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_beneficios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_beneficios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_beneficios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_beneficios.ColumnHeadersHeight = 35;
            this.dgv_beneficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_beneficios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_beneficios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(222)))));
            this.dgv_beneficios.Location = new System.Drawing.Point(0, 1);
            this.dgv_beneficios.MultiSelect = false;
            this.dgv_beneficios.Name = "dgv_beneficios";
            this.dgv_beneficios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_beneficios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_beneficios.RowHeadersVisible = false;
            this.dgv_beneficios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_beneficios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_beneficios.Size = new System.Drawing.Size(762, 262);
            this.dgv_beneficios.TabIndex = 30;
            this.dgv_beneficios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_beneficios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_beneficios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_beneficios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_beneficios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_beneficios.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.dgv_beneficios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(222)))));
            this.dgv_beneficios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_beneficios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_beneficios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_beneficios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_beneficios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_beneficios.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_beneficios.ThemeStyle.ReadOnly = true;
            this.dgv_beneficios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_beneficios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_beneficios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_beneficios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_beneficios.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_beneficios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_beneficios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_beneficios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_beneficios_CellDoubleClick);
            // 
            // guna2MessageDialog1_Error
            // 
            this.guna2MessageDialog1_Error.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1_Error.Caption = null;
            this.guna2MessageDialog1_Error.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1_Error.Parent = null;
            this.guna2MessageDialog1_Error.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1_Error.Text = null;
            // 
            // guna2MessageDialog_Confirm
            // 
            this.guna2MessageDialog_Confirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog_Confirm.Caption = null;
            this.guna2MessageDialog_Confirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog_Confirm.Parent = null;
            this.guna2MessageDialog_Confirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog_Confirm.Text = null;
            // 
            // guna2MessageDialog_Inform
            // 
            this.guna2MessageDialog_Inform.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog_Inform.Caption = null;
            this.guna2MessageDialog_Inform.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog_Inform.Parent = null;
            this.guna2MessageDialog_Inform.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog_Inform.Text = null;
            // 
            // Form_Listas_Beneficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(762, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Listas_Beneficios";
            this.Text = "Form_Listas_Beneficios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_beneficios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_atualizar;
        private FontAwesome.Sharp.IconButton btn_cadastrar;
        private FontAwesome.Sharp.IconButton iconButton3;
        public Guna.UI2.WinForms.Guna2TextBox text_pesquisar;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_beneficios;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1_Error;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Confirm;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog_Inform;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}