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
    public class dominio_testemunhas :  Validacoes
    {
        dados_testemunhas d_testemunhas = new dados_testemunhas();
        public DataTable selecionar_testemunhas_combo_box()
        {
            return d_testemunhas.selecionar_testemunhas_combo_boxs();
        }
        public DataTable selecionar_testemunhas()
        {
            return d_testemunhas.selecionar_testemunhas();
        }
        private void validacacoes(e_comum_testemunhas testemunhas)
        {
            //Validade a quantidade de letras no campo
            Validadar_Nomes_Gerais(testemunhas.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(testemunhas.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(testemunhas.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(testemunhas.e_mail, "[ERRO] - O campo 'E-mail', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_testemunhas(e_comum_testemunhas testemunhas)
        {
            validacacoes(testemunhas);
            d_testemunhas.inserir_testemunhas(testemunhas);
        }
        public void atualizar_testemunhas(e_comum_testemunhas testemunhas)
        {
            validacacoes(testemunhas);
            d_testemunhas.atualizar_testemunhas(testemunhas);
        }
        public void eliminar_testemunhas(e_comum_testemunhas testemunhas)
        {
            d_testemunhas.eliminar_testemunhas(testemunhas);
        }
    }
}
