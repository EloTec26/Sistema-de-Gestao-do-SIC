using Capa_Dominio.Dominio_Permissoes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Capa_Apresentacao
{
    public partial class Form_Login : Form
    {
        private int attemptCount = 0;
        private Timer lockoutTimer;
        private int remainingSeconds;
        private bool bloqueado = false;
        public Form_Login()
        {
            InitializeComponent();
            InitializeLockoutTimer();

            this.AcceptButton = btn_iniciar_sessao;

            toolTip1.SetToolTip(btn_Fechar, "Encerrar");
            toolTip1.SetToolTip(btn_Restaurar, "Restaurar");
            toolTip1.SetToolTip(btn_Maximizar, "Maximizar");
            toolTip1.SetToolTip(btn_Minimizar, "Minimizar");

            FormClosing += Form_Login_FormClosing;
        }

        private void InitializeLockoutTimer()
        {
            lockoutTimer = new Timer();
            lockoutTimer.Interval = 70; // 1 segundo em milissegundos (para contagem regressiva)
            lockoutTimer.Tick += LockoutTimer_Tick;
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
        private void btn_iniciar_sessao_Click_1(object sender, EventArgs e)
        {
            if (text_palavra_passe.Text == "")
            {
                label_erro.Text = "[ERRO] - Por favor, insira a palavra-passe e tente novamente!";
                label_erro.Visible = true;
                text_palavra_passe.Focus();
                return;
            }
            if (text_palavra_passe.Text.Length < 6)
            {
                label_erro.Text = "[ERRO] - A palavra-passe deve ter no mínimo 6 caracteres!";
                label_erro.Visible = true;
                text_palavra_passe.Focus();
                return;
            }
            else
            {
                try
                {
                    dominio_permissoes_usuario usuario = new dominio_permissoes_usuario();
                    var validar = usuario.Verificar_Login(text_palavra_passe.Text);
                    if (validar == true)
                    {
                        Form_Principal principal = new Form_Principal();
                        principal.Show();
                        this.Hide();
                        label_erro.Visible = false;
                        attemptCount = 0; // Resetar o contador em caso de sucesso
                    }
                    else
                    {
                        attemptCount++;
                        label_erro.Text = "[ERRO] - A palavra-passe inserida é inválida. Por favor, verifique-a\ne tente novamente!";
                        label_erro.Visible = true;

                        if (attemptCount >= 3)
                        {
                            btn_iniciar_sessao.Enabled = false;
                            btn_Fechar.Enabled = false;
                            btn_Limpar.Visible = false;
                            text_palavra_passe.ReadOnly = true;

                            text_palavra_passe.BorderColor = Color.Tomato;
                            text_palavra_passe.ForeColor = Color.Tomato;
                            text_palavra_passe.HoverState.BorderColor = Color.Tomato;
                            text_palavra_passe.FocusedState.BorderColor = Color.Tomato;


                            remainingSeconds = 1000; // Defina o tempo de bloqueio desejado em segundos
                            label_minutos.Text = $"O sistema será desbloquado dentro de {remainingSeconds} segundos.";
                            label_minutos.Visible = true;
                            lockoutTimer.Start();
                            bloqueado = true;
                            label_erro.Text = "[ERRO] - Excedeste o número máximo de tentativas.\nO sistema foi bloqueado temporariamente.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    label_erro.Text = $"[ERRO] - Ocorreu um erro ao tentar iniciar a sessão: {ex.Message}";
                    label_erro.Visible = true;
                }
            }
        }
        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;

            if (remainingSeconds > 0)
            {
                label_minutos.Text = $"Será desbloqueado dentro de {remainingSeconds} segundos.";
                label_minutos.ForeColor = Color.Tomato;
            }
            else
            {
                btn_iniciar_sessao.Enabled = true;
                btn_Fechar.Enabled = true;
                text_palavra_passe.ReadOnly = false;
                btn_Limpar.Visible = true;

                text_palavra_passe.BorderColor = Color.FromArgb(23, 35, 49);
                text_palavra_passe.ForeColor = Color.FromArgb(68, 88, 100);
                text_palavra_passe.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                text_palavra_passe.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);

                lockoutTimer.Stop(); // Para o temporizador após a reativação do botão
                attemptCount = 0; // Resetar o contador de tentativas
                label_minutos.Visible = false;
                bloqueado = false;
                label_erro.Text = "O sistema foi desbloqueado. Por favor, tente novamente.";
                label_erro.ForeColor = Color.Green;
            }
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bloqueado)
            {
                e.Cancel = true; // Cancela o fechamento do formulário
                label_erro.Text= "O aplicativo está bloqueado. Você não pode fechá-lo agora.";
                label_erro.Visible = true;
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            text_palavra_passe.Text = String.Empty;
        }

        private void btn_visualizar_palavra_passe_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_visualizar_palavra_passe.Checked)
                text_palavra_passe.PasswordChar = '\0';
            else
                text_palavra_passe.PasswordChar = '*';
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }
        private void btn_Fechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
