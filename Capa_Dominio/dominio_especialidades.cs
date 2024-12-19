﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using Capa_Dados.Dados_Pesquisas;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_especialidades
    {
        dados_especialidades d_Especialidades = new dados_especialidades();
        public DataTable selecionar_Especialidades_Combo_Box_Filtro(int IdCurso)
        {
            return d_Especialidades.selecionar_especialidades_combobox_filtro(IdCurso);
        }
        public DataTable selecionar_Especialidades_Combo_Box()
        {
            return d_Especialidades.selecionar_especialidades_combobox();
        }
        public DataTable selecionar_Especialidades()
        {
            return d_Especialidades.selecionar_especialidades();
        }
        public void inserir_Especialidades(e_comum_especialidades especialidades)
        {
            try
            {
                d_Especialidades.inserir_especialidades(especialidades);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome da especialidade já está registrado.\nPor favor, insira uma especialidade diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void atualizar_Especialidades(e_comum_especialidades especialidades)
        {
            try
            {
                d_Especialidades.atualizar_especialidades(especialidades);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome da especialidade já está registrado.\nPor favor, insira uma especialidade diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void eliminar_Especialidades(e_comum_especialidades especialidades)
        {
            d_Especialidades.eliminar_especialidades(especialidades);
        }
    }
}
