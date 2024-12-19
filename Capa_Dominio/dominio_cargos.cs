//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System;
using System.Data;


namespace Capa_Dominio
{
    public class dominio_cargos
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
        public void inserir_Cargos(e_comum_cargos cargos)
        {
            try
            {
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
