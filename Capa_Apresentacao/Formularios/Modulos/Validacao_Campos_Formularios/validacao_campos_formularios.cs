using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios
{
    public class validacao_campos_formularios
    {
        public class ValidadorCampos
        {
            // Validação de texto (apenas letras)
            public static void ValidarTexto (KeyPressEventArgs e, Guna2TextBox textBox, System.Windows.Forms.Label labelMsg, string mensagemErro)
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    // Formato válido
                    e.Handled = false;
                    labelMsg.Visible = false;
                    textBox.BorderColor = Color.FromArgb(23, 35, 49);
                    textBox.ForeColor = Color.FromArgb(68, 88, 100);
                    textBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    textBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    // Formato válido
                    labelMsg.Text = mensagemErro;
                    textBox.BorderColor = Color.Tomato;
                    textBox.ForeColor = Color.Tomato;
                    textBox.HoverState.BorderColor = Color.Tomato;
                    textBox.FocusedState.BorderColor = Color.Tomato;
                    labelMsg.Visible = true;
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    labelMsg.Visible = false;
                }
            }

            // Validação de número (apenas dígitos)
            public static void ValidarNumero(KeyPressEventArgs e, Guna2TextBox textBox, System.Windows.Forms.Label labelMsg, string mensagemErro)
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    // Formato válido
                    e.Handled = false;
                    labelMsg.Visible = false;
                    textBox.BorderColor = Color.FromArgb(23, 35, 49);
                    textBox.ForeColor = Color.FromArgb(68, 88, 100);
                    textBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    textBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                }
                else
                {
                    // Formato inválido
                    labelMsg.Text = mensagemErro;
                    textBox.BorderColor = Color.Tomato;
                    textBox.ForeColor = Color.Tomato;
                    textBox.HoverState.BorderColor = Color.Tomato;
                    textBox.FocusedState.BorderColor = Color.Tomato;
                    labelMsg.Visible = true;
                    e.Handled = true;
                }
            }

            // Validação de email (usando Regex)
            public static void ValidarEmail(Guna2TextBox textBox, System.Windows.Forms.Label labelMsg, string mensagemErro)
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (Regex.IsMatch(textBox.Text, pattern))
                {
                    // Formato válido
                    labelMsg.Visible = false;
                    textBox.BorderColor = Color.FromArgb(23, 35, 49);
                    textBox.ForeColor = Color.FromArgb(68, 88, 100);
                    textBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    textBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                }
                else
                {
                    // Formato inválido
                    labelMsg.Text = mensagemErro;
                    textBox.BorderColor = Color.Tomato;
                    textBox.ForeColor = Color.Tomato;
                    textBox.HoverState.BorderColor = Color.Tomato;
                    textBox.FocusedState.BorderColor = Color.Tomato;
                    labelMsg.Visible = true;
                }
            }
            // Validação de BI (usando Regex)
            public static void ValidarBilheteIdentidade(Guna2TextBox textBox, System.Windows.Forms.Label labelMsg, string mensagemErro)
            {
                // Expressão regular para validar o formato do número de bilhete de identidade
                string pattern = @"^\d{9}[A-Z]{2}\d{3}$";

                if (Regex.IsMatch(textBox.Text, pattern))
                {
                    // Formato válido
                    labelMsg.Visible = false;
                    textBox.BorderColor = Color.FromArgb(23, 35, 49); // Restaura a cor da borda para a cor padrão
                    textBox.ForeColor = Color.FromArgb(68, 88, 100); // Restaura a cor do texto
                    textBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    textBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                }
                else
                {
                    // Formato inválido
                    labelMsg.Text = mensagemErro;
                    textBox.BorderColor = Color.Tomato;
                    textBox.ForeColor = Color.Tomato;
                    textBox.HoverState.BorderColor = Color.Tomato;
                    textBox.FocusedState.BorderColor = Color.Tomato;
                    labelMsg.Visible = true;
                }
            }
            public static void ValidarTextoNumeroSimbolo(KeyPressEventArgs e, Guna2TextBox textBox, System.Windows.Forms.Label labelMsg, string mensagemErro)
            {
                // Verifica se o caractere é letra, número, controle ou o símbolo "º" (código 186 em ASCII)
                if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 'º')
                {
                    e.Handled = false; // Permite o caractere
                    labelMsg.Visible = false; // Oculta a mensagem de erro
                    textBox.BorderColor = Color.FromArgb(23, 35, 49);
                    textBox.ForeColor = Color.FromArgb(68, 88, 100);
                    textBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    textBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                }
                else
                {
                    // Exibe a mensagem de erro e impede a inserção do caractere inválido
                    labelMsg.Text = mensagemErro;
                    textBox.BorderColor = Color.Tomato;
                    textBox.ForeColor = Color.Tomato;
                    textBox.HoverState.BorderColor = Color.Tomato;
                    textBox.FocusedState.BorderColor = Color.Tomato;
                    labelMsg.Visible = true;
                    e.Handled = true; // Bloqueia o caractere
                }
            }

        }
    }
}
