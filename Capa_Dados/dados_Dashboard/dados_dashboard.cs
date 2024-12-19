using Capa_Dados.Conexao;
using System.Data.SqlClient;

namespace Capa_Dados.Dashboard
{
    public class dados_dashboard : conexao_sql
    {
        // Propriedades
        public int NumeroAfastamento { get; private set; }
        public int NumeroBairrosRuas { get; private set; }
        public int NumeroBeneficoInvestigadores { get; private set; }
        public int NumeroBeneficios { get; private set; }
        public int NumeroCargos { get; private set; }
        public int NumeroCasos { get; private set; }
        public int NumeroContinentes { get; private set; }
        public int NumeroCursos { get; private set; }
        public int NumeroDepartamentos { get; private set; }
        public int NumeroDepartamentoInvestigadores { get; private set; }
        public int NumeroEspecialidades { get; private set; }
        public int NumeroEvidencias { get; private set; }
        public int NumeroFaltas { get; private set; }
        public int NumeroNiveisAcademicos { get; private set; }
        public int NumeroMunicipios { get; private set; }
        public int NumeroFuncionarios { get; private set; }
        public int NumeroHorasExtras { get; private set; }
        public int NumeroFerias { get; private set; }
        public int NumeroPaises { get; private set; }
        public int NumeroPatentes { get; private set; }
        public int NumeroProvincias { get; private set; }
        public int NumeroSuspeitos { get; private set; }
        public int NumeroTestemunhas { get; private set; }
        public int NumeroUsuarios { get; private set; }
        public int NumeroVitimas { get; private set; }

        // Construtor
        public dados_dashboard(){
            contaNumeros();
        }

        // Consultas para contar
        private void contaNumeros()
        {
            using (var connection = conectar())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    // Quantidade afastamentos
                    cmd.CommandText = "select count(id_afastamento)[Afastamentos] from afastamento_tbl";
                    NumeroAfastamento = (int)cmd.ExecuteScalar();

                    // Quantidade Bairros/ruas
                    cmd.CommandText = "select count(id_bairro_rua)[Bairros/ruas] from bairro_rua_tbl";
                    NumeroBairrosRuas = (int)cmd.ExecuteScalar();

                    // Quantidade abeneficio_investigador
                    cmd.CommandText = "select count(id_beneficio_investigador)[Bfs. Func.] from beneficio_investigador_tbl";
                    NumeroBeneficoInvestigadores = (int)cmd.ExecuteScalar();

                    // Quantidade Benefícios
                    cmd.CommandText = "select count(id_beneficio)[Benefícios] from beneficio_tbl";
                    NumeroBeneficios = (int)cmd.ExecuteScalar();

                    // Quantidade Cargos
                    cmd.CommandText = "select count(id_cargo)[Cargos] from cargo_tbl";
                    NumeroCargos = (int)cmd.ExecuteScalar();

                    // Quantidade Casos
                    cmd.CommandText = "select count(id_caso)[Casos] from caso_tbl";
                    NumeroCasos = (int)cmd.ExecuteScalar();

                    // Quantidade Continentes
                    cmd.CommandText = "select count(id_continente)[Continentes] from continente_tbl";
                    NumeroContinentes = (int)cmd.ExecuteScalar();

                    // Quantidade afastamentos
                    cmd.CommandText = "select count(id_afastamento)[Afastamentos] from afastamento_tbl";
                    NumeroAfastamento = (int)cmd.ExecuteScalar();

                    // Quantidade Cursos
                    cmd.CommandText = "select count(id_curso)[Cursos] from curso_tbl";
                    NumeroCursos = (int)cmd.ExecuteScalar();

                    // Quantidade Departamentos
                    cmd.CommandText = "select count(id_departamento)[Departamentos] from departamento_tbl";
                    NumeroDepartamentos = (int)cmd.ExecuteScalar();

                    // Quantidade Deprtamento Funcionário/investigadores
                    cmd.CommandText = "select count(id_departamento_investigador)[Deprt. Func.] from departamento_investigador_tbl";
                    NumeroDepartamentoInvestigadores = (int)cmd.ExecuteScalar();

                    // Quantidade Especialidades
                    cmd.CommandText = "select count(id_especialidade)[Espec.] from especialidade_tbl";
                    NumeroEspecialidades = (int)cmd.ExecuteScalar();

                    // Quantidade Evidências
                    cmd.CommandText = "select count(id_evidencia)[Evidências] from evidencia_tbl";
                    NumeroEvidencias = (int)cmd.ExecuteScalar();

                    // Quantidade Faltas
                    cmd.CommandText = "select count(id_falta)[Faltas] from falta_tbl";
                    NumeroFaltas = (int)cmd.ExecuteScalar();

                    // Quantidade Férias
                    cmd.CommandText = "select count(id_feria)[Férias] from feria_tbl";
                    NumeroFerias = (int)cmd.ExecuteScalar();

                    // Quantidade Horas Extras
                    cmd.CommandText = "select count(id_hora_extra)[H.Extras] from hora_extra_tbl";
                    NumeroHorasExtras = (int)cmd.ExecuteScalar();

                    // Quantidade Horas Funcionários
                    cmd.CommandText = "select count(id_investigador)[Funcionários] from investigador_tbl";
                    NumeroFuncionarios = (int)cmd.ExecuteScalar();

                    // Quantidade Municípios
                    cmd.CommandText = "select count(id_municipio)[Municípios] from municipio_tbl";
                    NumeroMunicipios = (int)cmd.ExecuteScalar();

                    // Quantidade Niveis academicos
                    cmd.CommandText = "select count(id_nivel_academico)[N.acad.] from nivel_academico_tbl";
                    NumeroNiveisAcademicos = (int)cmd.ExecuteScalar();

                    // Quantidade Países
                    cmd.CommandText = "select count(id_pais)[Países] from pais_tbl";
                    NumeroPaises = (int)cmd.ExecuteScalar();

                    // Quantidade Patentes
                    cmd.CommandText = "select count(id_patente)[Patentes] from patente_tbl";
                    NumeroPatentes = (int)cmd.ExecuteScalar();

                    // Quantidade Províncias
                    cmd.CommandText = "select count(id_provincia)[Províncias] from provincia_tbl";
                    NumeroProvincias = (int)cmd.ExecuteScalar();

                    // Quantidade Suspeitos
                    cmd.CommandText = "select count(id_suspeito)[Suspeitos] from suspeito_tbl";
                    NumeroSuspeitos = (int)cmd.ExecuteScalar();

                    // Quantidade Testemunhas
                    cmd.CommandText = "select count(id_testemunha)[Testemunhas] from testemunha_tbl";
                    NumeroTestemunhas = (int)cmd.ExecuteScalar();

                    // Quantidade Usuários
                    cmd.CommandText = "select count(id_usuario)[Usuários] from usuario_tbl";
                    NumeroUsuarios = (int)cmd.ExecuteScalar();

                    // Quantidade Vítimas
                    cmd.CommandText = "select count(id_vitima)[Vítimas] from vitima_tbl";
                    NumeroVitimas = (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}

