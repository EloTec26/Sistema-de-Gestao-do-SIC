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
    public class dominio_investigadores : Validacoes
    {
        dados_investigadores d_investigadores = new dados_investigadores();
        public DataTable selecionar_investigadores_combobox()
        {
            return d_investigadores.selecionar_investigadores_combobox();
        }
        public DataTable selecionar_investigadores()
        {
            return d_investigadores.selecionar_investigadores();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_investigadores investigadores)
        {
            Validadar_Nomes_Gerais(investigadores.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(investigadores.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(investigadores.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Telefone(investigadores.telefone1);
            Validadar_Telefone(investigadores.telefone2);
            Validar_Email(investigadores.e_mail);
            Validar_Bilhete_Identidade(investigadores.bi);
        }
        public void inserir_investigadores(e_comum_investigadores investigadores)
        {
            validacacoes(investigadores);
            d_investigadores.inserir_investigadores(investigadores);
        }
        public void atualizar_investigadores(e_comum_investigadores investigadores)
        {
            validacacoes(investigadores);
            d_investigadores.atualizar_investigadores(investigadores);
        }
        public void eliminar_investigadores(e_comum_investigadores investigadores)
        {
            d_investigadores.eliminar_investigadores(investigadores);
        }
    }
}
