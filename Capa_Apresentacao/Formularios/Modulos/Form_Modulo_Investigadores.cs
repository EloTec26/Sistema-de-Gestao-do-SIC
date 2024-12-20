using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Comum_Permissoes.Cache;
//-----------------------------------------
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Investigadores : Form
    {
        #region Instanciação de classes e métodos...
        dominio_continentes d_Continentes = new dominio_continentes();
        dominio_paises d_Paises = new dominio_paises();
        dominio_provincias d_Provincias = new dominio_provincias();
        dominio_municipios d_Municipios = new dominio_municipios();
        dominio_bairro_rua d_Bairro_Ruas = new dominio_bairro_rua();
        dominio_niveis_academicos d_Niveis_Academicos = new dominio_niveis_academicos();
        dominio_cursos d_Cursos = new dominio_cursos();
        dominio_especialidades d_Especialidades = new dominio_especialidades();
        dominio_patentes d_Patentes = new dominio_patentes();
        e_comum_investigadores c_Investigadores = new e_comum_investigadores();
        dominio_investigadores d_Invstigadores = new dominio_investigadores();
        #endregion
        public Form_Modulo_Investigadores()
        {
            InitializeComponent();
            // Inicialização dos métodos
            selecionar_dados_comboBoxs();
            filtrar();
            filtro_curso();
        }
        #region Método para selecionar os dados e trazê-los nos seus respectivos comboBox´s
        private void filtrar()
        {
            // buscarS continentes
            text_continente.DataSource = d_Continentes.selecionar_continentes();
            text_continente.DisplayMember = "nome";
            text_continente.ValueMember = "id_continente";
        }
        private void carregar_Paises(int Id_Continente)
        {
            // buscar paises
            text_pais.DataSource = d_Paises.selecionar_paises_comboBox_Filtro(Id_Continente);
            text_pais.DisplayMember = "nome";
            text_pais.ValueMember = "id_pais";
        }
        private void carregar_Provincias(int Id_Provincia)
        {
            // buscar provincias
            text_provincias.DataSource = d_Provincias.selecionar_provincias_ComboBox_Filtros(Id_Provincia);
            text_provincias.DisplayMember = "nome";
            text_provincias.ValueMember = "id_provincia";
        }
        private void carregar_Municipios(int Id_Municipio)
        {
            // buscar municipios
            text_municipio.DataSource = d_Municipios.Selecionar_Municipios_Fitrod(Id_Municipio);
            text_municipio.DisplayMember = "nome";
            text_municipio.ValueMember = "id_municipio";
        }
        private void carregar_Bairro_Ruas(int Id_Bairro_Rua)
        {
            // buscar bairros/ruas
            text_bairro_rua.DataSource = d_Bairro_Ruas.selecionar_bairros_ruas_filtro(Id_Bairro_Rua);
            text_bairro_rua.DisplayMember = "nome";
            text_bairro_rua.ValueMember = "id_bairro_rua";
        }
        private void filtro_curso()
        {
            // buscar cursos
            text_curso.DataSource = d_Cursos.selecionar_Cursos();
            text_curso.DisplayMember = "nome";
            text_curso.ValueMember = "id_curso";
        }
        private void filtro_especialidade(int IdCurso)
        {
            // buscar especialidades
            text_especialidades.DataSource = d_Especialidades.selecionar_Especialidades_Combo_Box_Filtro(IdCurso);
            text_especialidades.DisplayMember = "nome";
            text_especialidades.ValueMember = "id_especialidade";
        }
        private void text_continente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_continente.SelectedValue is int idPaises)
            {
                carregar_Paises(idPaises);
            }
        }

        private void text_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_pais.SelectedValue is int Id_Provincia)
            {
                carregar_Provincias(Id_Provincia);
            }
        }

        private void text_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_provincias.SelectedValue is int Id_Municipio)
            {
                carregar_Municipios(Id_Municipio);
            }
        }

        private void text_municipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_municipio.SelectedValue is int Id_Bairro_Rua)
                carregar_Bairro_Ruas(Id_Bairro_Rua);
        }
        private void text_curso_SelectedIndexChanged(object sender, EventArgs e)
        {if (text_curso.SelectedValue is int idCurso)
                filtro_especialidade(idCurso);
        }
        private void selecionar_dados_comboBoxs()
        {
            // buscar níveis acadêmicos
            text_nivel_academico.DataSource = d_Niveis_Academicos.selecionar_niveis_academicos();
            text_nivel_academico.DisplayMember = "nome";
            text_nivel_academico.ValueMember = "id_nivel_academico";

           

            // buscar patentes
            text_patente.DataSource = d_Patentes.selecionar_patentes_combobox();
            text_patente.DisplayMember = "nome";
            text_patente.ValueMember = "id_patente";
        }
        #endregion
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerificarCamposVazios()
        {
            if (text_primeiro_nome.Text == "" || text_ultimo_nome.Text == ""
              || text_continente.Text == "" || text_pais.Text == "" || text_provincias.Text == "" ||
              text_municipio.Text == "" || text_bairro_rua.Text == "" || text_nivel_academico.Text == "" ||
              text_curso.Text == "" || text_especialidades.Text == "" || text_patente.Text == "" ||
              text_sexo.Text == "" || text_numero_bi.Text == "" || text_primerio_numero_telefone.Text == "")
            {
                MessageDialog_Error.Show("Todos os campos com o asterísco(*) são de preenchimento obrigatório. Por favor, preencha-os e tente novamente!", "Erro ao salvar os dados");
                return false;
            }
            return true;
        }
        private void CapturarDadosFormulario()
        {
            // capturar os dados digitados no formulário

            int continente = Convert.ToInt32(text_continente.SelectedValue);
            int pais = Convert.ToInt32(text_pais.SelectedValue);
            int provincia = Convert.ToInt32(text_provincias.SelectedValue);
            int municipio = Convert.ToInt32(text_municipio.SelectedValue);
            int bairro_rua = Convert.ToInt32(text_bairro_rua.SelectedValue);
            int nivel_Academico = Convert.ToInt32(text_nivel_academico.SelectedValue);
            int curso = Convert.ToInt32(text_curso.SelectedValue);
            int especialidade = Convert.ToInt32(text_especialidades.SelectedValue);
            int patente = Convert.ToInt32(text_patente.SelectedValue);
            string primeiro_Nome = text_primeiro_nome.Text;
            string nome_Meio = text_nome_meio.Text;
            string ultimo_Nome = text_ultimo_nome.Text;
            DateTime data_nascimento = text_data_nascimento.Value;
            string sexo = text_sexo.Text;
            string numero_Bi = text_numero_bi.Text;
            string primeiro_Numero_Telefone = text_primerio_numero_telefone.Text;
            string segundo_Numero_Telefone = text_segundo_numero_telefone.Text;
            string e_Email = text_e_mail.Text;
            DateTime data_Inicio_Contrato = text_data_inicio_contrato.Value;
            DateTime data_Fim_Contrato = text_data_fim_contrato.Value;

            // Salvar os dados capturados
            c_Investigadores.id_continente = continente;
            c_Investigadores.id_pais = pais;
            c_Investigadores.id_provincia = provincia;
            c_Investigadores.id_municipio = municipio;
            c_Investigadores.id_bairro_rua = bairro_rua;
            c_Investigadores.id_nivel_academico = nivel_Academico;
            c_Investigadores.id_curso = curso;
            c_Investigadores.id_especialidade = especialidade;
            c_Investigadores.id_patente = patente;
            c_Investigadores.id_usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            c_Investigadores.primeiro_nome = primeiro_Nome;
            c_Investigadores.nome_meio = nome_Meio;
            c_Investigadores.ultimo_nome = ultimo_Nome;
            c_Investigadores.data_nascimento = data_nascimento;
            c_Investigadores.sexo = sexo;
            c_Investigadores.bi = numero_Bi;
            c_Investigadores.telefone1 = primeiro_Numero_Telefone;
            c_Investigadores.telefone2 = segundo_Numero_Telefone;
            c_Investigadores.e_mail = e_Email;
            c_Investigadores.data_inicio_contrato = data_Inicio_Contrato;
            c_Investigadores.data_fim_contrato = data_Fim_Contrato;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    CapturarDadosFormulario();
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Investigadores.data_registro = data_Registro;
                    c_Investigadores.data_atualizacao = data_Atualizacao;
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este funcinário?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Invstigadores.inserir_investigadores(c_Investigadores);
                        guna2MessageDialog_Inform.Show(
                            $"O funcionário {text_primeiro_nome.Text + " " + text_nome_meio.Text + " " + text_ultimo_nome.Text}" +
                            $" foi registrado com sucesso!", "Registro bem sucedido");

                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar este funcionário!", Ex.Message);
                }
            }

        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    // capturar os dados digitados no formulário
                    int id_Investigadores = Convert.ToInt32(label_id.Text);
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Investigadores.data_atualizacao = data_Atualizacao;
                    CapturarDadosFormulario();
                    // atualizar os dados capturados
                    c_Investigadores.id_investigador = id_Investigadores;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este funcionário?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Invstigadores.atualizar_investigadores(c_Investigadores);
                        guna2MessageDialog_Inform.Show(
                            $"O funcionário {text_primeiro_nome.Text + " " + text_nome_meio.Text + " " + text_ultimo_nome.Text}" +
                            $" foi atualizado com sucesso!", "Atualização bem sucedida");

                        limpar_Campos();
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este funcinário!", Ex.Message);
                }
            }
        }
        private void limpar_Campos()
        {
            text_continente.SelectedIndex = -1;
            text_pais.SelectedIndex = -1;
            text_provincias.SelectedIndex = -1;
            text_municipio.SelectedIndex = -1;
            text_bairro_rua.SelectedIndex = -1;
            text_nivel_academico.SelectedIndex = -1;
            text_curso.SelectedIndex = -1;
            text_especialidades.SelectedIndex = -1;
            text_patente.SelectedIndex = -1;
            text_primeiro_nome.Text = "";
            text_nome_meio.Text = "";
            text_ultimo_nome.Text = "";
            text_sexo.Text = "";
            text_numero_bi.Text = "";
            text_primerio_numero_telefone.Text = "";
            text_segundo_numero_telefone.Text = "";
            text_e_mail.Text = "";
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void text_primeiro_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_primeiro_nome, label_msg_primeiro_nome, "Apenas letras são permitidas!");
        }
        private void text_nome_meio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_nome_meio, label_msg_nome_meio, "Apenas letras são permitidas!");
        }
        private void text_ultimo_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_ultimo_nome, label_msg_ultimo_nome, "Apenas letras são permitidas!");
        }
        private void text_numero_bi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarBilheteIdentidade(text_numero_bi, label_msg_erro_bi, "Número do BI inválido!");
        }
        private void text_primerio_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_primerio_numero_telefone, label_msg_telefone1, "Apenas números são permitidas!");
        }
        private void text_segundo_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_segundo_numero_telefone, label_msg_telefone2, "Apenas números são permitidas!");
        }
        private void text_e_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarEmail(text_e_mail, label_msg_email, "Email inválido!");
        }
    }
}
