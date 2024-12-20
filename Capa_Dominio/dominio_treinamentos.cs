using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_treinamentos : Validacoes
    {
        dados_treinamentos d_treinamentos = new dados_treinamentos();
        private void validacacoes(e_comum_treinamentos treinamentos)
        {
            //Validade a quantidade de letras no campo
            Validadar_Nomes_Gerais(treinamentos.titulo, "[ERRO] - O campo 'Título', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(treinamentos.descricao, "[ERRO] - O campo 'Descrição', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void cadastrar_treinamentos(e_comum_treinamentos treinamentos)
        {
            validacacoes(treinamentos);
            d_treinamentos.Cadastrar_Treinamentos(treinamentos);
        }
        public System.Data.DataTable selecionar_treinamentos()
        {
            return d_treinamentos.Selecionar_Treinamentos();
        }
        public void atualizar_treinamentos(e_comum_treinamentos treinamentos)
        {
            validacacoes(treinamentos);
            d_treinamentos.Atualizar_Treinamentos(treinamentos);
        }
        public void eliminar_treinamentos(e_comum_treinamentos treinamentos)
        {
            d_treinamentos.Eliminar_Treinamentos(treinamentos);
        }
    }
}
