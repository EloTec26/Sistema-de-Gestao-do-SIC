using System;
using System.Text.RegularExpressions;

namespace Capa_Dominio.Dominio_Validacoes
{
    public class Validacoes
    {
        public void Validar_Email(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("[ERRO] - O campo 'Email' não está em um formato válido.");
        }
        public void Validar_Email_Emergencia(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("[ERRO] - O campo 'Email de emergência' não está em um formato válido.");
        }
        public void Validar_Bilhete_Identidade(string bilhete)
        {
            if (!Regex.IsMatch(bilhete, @"^\d{9}[A-Z]{2}\d{3}$"))
                throw new ArgumentException("[ERRO] - O campo 'Bilhete de Identidade' não está em um formato válido.");
        }
        public void Validadar_Nomes_Gerais(string nomes_gerais, string mensagem)
        {
            // Validação do formato de nomes gerais
            if (!Regex.IsMatch(nomes_gerais, @"^[A-Za-zÀ-ÿ\s,;:\-+]{3,}$"))
                throw new ArgumentException(mensagem);
        }
        public void Validadar_Telefone(string telefone)
        {
            // Validação do formato do número de telefone
            if (!Regex.IsMatch(telefone, @"^\d{9}$"))
                throw new ArgumentException("[ERRO] - O campo 'Telefone' deve conter exatamente 9 dígitos numéricos.");
        }
        public void Validadar_Telefone_Emergencia(string telefone)
        {
            // Validação do formato do número de telefone
            if (!Regex.IsMatch(telefone, @"^\d{9}$"))
                throw new ArgumentException("[ERRO] - O campo 'Telefone de emergência' deve conter exatamente 9 dígitos numéricos.");
        }
        public void Validar_Numero_Peso(string peso)
        {
            // Validação do formato do peso
            if (!Regex.IsMatch(peso, @"^\d{1,3},\d{2}$"))
                throw new ArgumentException("[ERRO] - O campo 'Peso' deve conter no máximo 3 dígitos antes da vírgula e exatamente 2 dígitos após a vírgula.");
        }
        public void Validar_Palavra_Passe(string palavra_passe)
        {
            // Validação do formato da palavra-passe
            if (!Regex.IsMatch(palavra_passe, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                throw new ArgumentException("[ERRO] - A palavra-passe deve ter no mínimo 8 caracteres, incluindo pelo menos 1 letra minúscula, 1 letra maiúscula, 1 número e 1 caractere especial.");
        }
    }
}
