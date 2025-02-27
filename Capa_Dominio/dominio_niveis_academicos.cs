﻿
using Capa_Comum.Entidades;
using Capa_Dados;
using System;
using Capa_Dominio.Dominio_Validacoes;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Dominio
{
    public class dominio_niveis_academicos : Validacoes
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
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_nivel_academicos nivel_Academicos)
        {
            Validadar_Nomes_Gerais(nivel_Academicos.nome, "[ERRO] - O campo 'Selecione o nível acadêmico', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_niveis_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            try
            {
                validacacoes(nivel_Academicos);
                d_niveis_academicos.inserir_nivel_academicos(nivel_Academicos);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new ArgumentException("O nome do nível acadêmico já está registrado. Por favor, insira um nível acadêmico diferente.");
                }
                else
                {
                    throw new ArgumentException("Um erro ocorreu" + ex.Message); // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void atualizar_niveis_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            try
            {
                validacacoes(nivel_Academicos);
                d_niveis_academicos.atualizar_nivel_academicos(nivel_Academicos);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new ArgumentException("O nome do nível acadêmico já está registrado. Por favor, insira um nível acadêmico diferente.", "Erro de redudância");
                }
                else
                {
                    throw new ArgumentException("Um erro ocorreu" + ex.Message); // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void eliminar_niveis_academicos(e_comum_nivel_academicos nivel_Academicos)
        {
            try
            {
                d_niveis_academicos.eliminar_nivel_academicos(nivel_Academicos);
            }
            catch (SqlException ex) when(ex.Number == 457)
            {

                throw new ArgumentException("Não é possível eliminar este nível acadêmico, pois existem - no sistema -, dados que estão vinculados à ele", "Erro de exclusão");
            }
        }
    }
}
