
using Capa_Comum.Entidades;
using Capa_Dados;
using System;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_niveis_academicos
    {
        dados_niveis_academicos d_niveis_academicos = new dados_niveis_academicos();
        public DataTable selecionar_niveis_academicos_combo_box()
        {
            return d_niveis_academicos.selecionar_niveis_academicos_Combo_Box();
        }
        public DataTable selecionar_niveis_academicos()
        {
            return d_niveis_academicos.selecionar_niveis_academicos();
        }
        public void inserir_niveis_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            try
            {
                d_niveis_academicos.inserir_nivel_academicos(nivel_Academicos);
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do nível acadêmico já está registrado. Por favor, insira um nível acadêmico diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void atualizar_niveis_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            try
            {
                d_niveis_academicos.atualizar_nivel_academicos(nivel_Academicos);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do nível acadêmico já está registrado. Por favor, insira um nível acadêmico diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void eliminar_niveis_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            d_niveis_academicos.eliminar_nivel_academicos(nivel_Academicos);
        }
    }
}
