using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_suspeitos : Validacoes
    {
        dados_suspeitos d_suspeitos = new dados_suspeitos();
        public DataTable selecionar_suspeitos_combo_boxs()
        {
            return d_suspeitos.selecionar_suspeitos_combo_box();
        }
        public DataTable selecionar_suspeitos()
        {
            return d_suspeitos.selecionar_suspeitos();
        }
        private void validacacoes(e_comum_suspeitos suspeitos)
        {
            //Validade a quantidade de letras no campo
            Validadar_Nomes_Gerais(suspeitos.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(suspeitos.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(suspeitos.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validar_Email(suspeitos.e_mail);
        }
        public void inserir_suspeitos(e_comum_suspeitos suspeitos)
        {
            validacacoes(suspeitos);
             d_suspeitos.inserir_suspeitos(suspeitos);
        }
        public void atualizar_suspeitos(e_comum_suspeitos suspeitos)
        {
            validacacoes(suspeitos);
            d_suspeitos.atualizar_suspeitos(suspeitos);
        }
        public void eliminar_suspeitos(e_comum_suspeitos suspeitos)
        {
             d_suspeitos.eliminar_suspeitos(suspeitos);
        }
    }
}
