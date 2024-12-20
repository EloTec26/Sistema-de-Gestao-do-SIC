//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_cargos : Validacoes
    {
        dados_cargos d_Cargos = new dados_cargos();
        public DataTable selecionar_Cargos()
        {
            return d_Cargos.selecionar_cargos();
        }
        public DataTable selecionar_Cargos_Combo_Box()
        {
            return d_Cargos.selecionar_Cargos__Combo_Box();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_cargos cargos)
        {
            Validadar_Nomes_Gerais(cargos.nome, "[ERRO] - O campo 'Digite o cargo', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_Cargos(e_comum_cargos cargos)
        {
            try
            {
                validacacoes(cargos);
                d_Cargos.registrar_cargos(cargos);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do cargo já está registrado. Por favor, insira um cargo diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void atualizar_Cargos(e_comum_cargos cargos)
        {
            try
            {
                validacacoes(cargos);
                d_Cargos.atualizar_cargos(cargos);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do cargo já está registrado. Por favor, insira um cargo diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void eliminar_Cargos(e_comum_cargos cargos)
        {
            d_Cargos.eliminar_cargos(cargos);
        }
    }
}
