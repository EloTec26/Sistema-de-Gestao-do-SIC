using Capa_Comum.Comum_Permissoes.Cache;
using CustomBox.RJControls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Apresentacao
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            carregar_dados_usuarios();
            //--------------------------------------
            btn_Sub_Menu_Enderecos.PrimaryColor = Color.FromArgb(94, 148, 255);
            rjDropdownMenu2.PrimaryColor = Color.FromArgb(94, 148, 255);
            rjDropdownMenu_escolaridades.PrimaryColor = Color.FromArgb(94, 148, 255);
            rjDropdownMenu_eventos_casos.PrimaryColor = Color.FromArgb(94, 148, 255);

            toolTip1.SetToolTip(btn_Fechar, "Encerrar");
            toolTip1.SetToolTip(btn_Restaurar, "Restaurar");
            toolTip1.SetToolTip(btn_Maximizar, "Maximizar");
            toolTip1.SetToolTip(btn_Minimizar, "Minimizar");
            toolTip1.SetToolTip(btn_perfil_cima, "Ocultar perfil");
            toolTip1.SetToolTip(btn_perfil_baixo, "Mostrar perfil");
            toolTip1.SetToolTip(btn_perfil_usuario, "Dados completos do usuaário");

        }
        private void Form_Principal_Load(object sender, EventArgs e)
        {
            btn_Logo_Click(e, null);
        }
        // Métodos privados para mover o formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        // fim dos métodos
        int LX, LY, SW, SH;
        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Funções para mover o formulário.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.WindowState = FormWindowState.Normal;
        }
        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }
        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #region Método para exibir os formulários
        private void AbrirPainelConteudo(object AbrirFormularios)
        {
            // Função para abrir todos os formulários.
            if (this.panel_conteudo.Controls.Count > 0)
                this.panel_conteudo.Controls.RemoveAt(0);
            Form fh = AbrirFormularios as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_conteudo.Controls.Add(fh);
            this.panel_conteudo.Tag = fh;
            fh.Show();
        }
        #endregion
        #region Método para carregar os dados dos usuários
        private void carregar_dados_usuarios()
        {
            label_nome.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.primeiro_nome + " " +
                              comum_cache_permissoes_usuarios.cache_inicio_sessao.ultimo_nome;
            label_cargo.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.tipo_usuario;
            label_email.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.e_mail;
            label_telefone.Text = comum_cache_permissoes_usuarios.cache_inicio_sessao.telefone1;
        }
        #endregion
        private void btn_butao_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 52)
                panel_menu.Width = 235;
            else
                panel_menu.Width = 52;
        }
        private void btn_butao_menu_MouseEnter(object sender, EventArgs e)
        {
            btn_butao_menu.IconColor = Color.DeepSkyBlue;
        }
        private void btn_butao_menu_MouseLeave(object sender, EventArgs e)
        {
            btn_butao_menu.IconColor = Color.Blue;
        }
       

        private void btn_painel_adimistrativo_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Formulario_Dashboard.Form_Painel_Administrativo());
        }
        private void btn_Logo_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Formulario_Dashboard.Form_Dashboard());
        }
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Usuarios());

        }
        private void btn_provincias_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Provincia());
        }
        private void btn_terminar_sessao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tens a certeza de terminar sessão?", "Estás prestes a terminar a sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form_Login login = new Form_Login();
                login.Show();
                this.Hide();
            }
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sbumenu_continentes_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Continentes());
        }

        private void sub_menu_paises_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Paises());

        }
        private void sub_menu_provincias_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Provincia());
        }
        private void sub_menu_municipios_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Municipios());
        }
        private void sub_menu_bairro_ruas_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Bairros_Ruas());

        }
        private void btn_submenu_investigadores_afastamentos_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Afastamentos());
        }
        // Método para abrir o submenu 1
        private void Abrir_Sub_Menu(RJDropdownMenu dropDownMenu, object sender)
        {
            Control control = (Control)sender;
            dropDownMenu.VisibleChanged += new EventHandler((sender2, ev) =>
                DropDownMenu_VisibleChanged(sender2, ev, control));
            dropDownMenu.Show(control, control.Width, 0);
        }
        private void DropDownMenu_VisibleChanged(object sender2, EventArgs ev, Control control)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender2;

            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                {
                    control.BackColor = Color.FromArgb(0, 102, 222);
                }
                else control.BackColor = Color.FromArgb(0, 102, 222);
            }
        }
        private void btn_suspeitos_Click_1(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Suspeitos());
        }
        private void nívelAcadêmicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Niveis_Academicos());
        }
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Cursos());
        }
        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Especialidades());
        }
        private void btn_Mais_Opcoes_Click(object sender, EventArgs e)
        {
            Abrir_Sub_Menu(btn_Sub_Menu_Enderecos, sender);
        }
        private void btn_submenu_casos_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Casos());
        }
        private void btn_submenu_eventos_casos_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Eventos_Casos());
        }
        private void btn_testemunhas_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Testemunhas());
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
        private void btn_submenu_investigadores_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Investigadores());
        }
        private void benefícosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Beneficios());
        }
        private void benefícosInvestigadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Beneficios_Investigadores());
        }
        private void faltasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Faltas());
        }
        private void fériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Ferias());
        }
        private void horasExtrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Horas_Extras());
        }
        private void patentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Patentes());
        }
        private void toolStripMenuItem2_afastamentos_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Afastamentos());
        }
        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Departamentos());
        }
        private void departamentosInvestigadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Departamentos_Investigadores());
        }
        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Cargos());
        }
        private void cargosInvestigadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Cargos_Investigadores());
        }
        private void btn_Evidencias_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Evidencias());
        }
        private void btn_perfil_baixo_Click(object sender, EventArgs e)
        {
            if (panel_panel_perfil.Height == 5)
                panel_panel_perfil.Height = 119;
            btn_perfil_baixo.Visible = false;
            btn_perfil_cima.Visible = true;
        }

        private void btn_perfil_cima_Click(object sender, EventArgs e)
        {
            if (panel_panel_perfil.Height == 119)
                panel_panel_perfil.Height = 5;
            btn_perfil_cima.Visible = false;
            btn_perfil_baixo.Visible = true;
        }
        private void btn_perfil_usuario_Click(object sender, EventArgs e)
        {

            Formularios.Lista_Formularios.Alterar_perfil_usuario.Form_Perfil_Usuario perfil_usuario = new Formularios.Lista_Formularios.Alterar_perfil_usuario.Form_Perfil_Usuario();
            perfil_usuario.ShowDialog();
        }

        private void btn_Vitimas_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Listas_Vitimas());
        }
        private void treinamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPainelConteudo(new Formularios.Lista_Formularios.Form_Lista_Treinamentos());
        }
        private void btn_suspeitos_Click(object sender, EventArgs e)
        {
            Abrir_Sub_Menu(rjDropdownMenu2, sender);
        }
        private void btn_escolaridade_Click(object sender, EventArgs e)
        {
            Abrir_Sub_Menu(rjDropdownMenu_escolaridades, sender);
        }
        private void btn_casos_Click(object sender, EventArgs e)
        {
            Abrir_Sub_Menu(rjDropdownMenu_eventos_casos, sender);
        }
    }
}
