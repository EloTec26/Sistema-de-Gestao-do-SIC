using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Comum_Permissoes.Cache;
//-----------------------------------------
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{

    public partial class Form_Modulo_Vitimas : Form
    {
        #region Instanciar as classes e os métodos
        dominio_vitimas d_Vitimas = new dominio_vitimas();
        e_comum_vitimas c_Vitimas = new e_comum_vitimas();
        dominio_continentes d_Continentes = new dominio_continentes();
        dominio_paises d_Paises = new dominio_paises();
        dominio_provincias d_Provincias = new dominio_provincias();
        dominio_municipios d_Municipios = new dominio_municipios();
        dominio_bairro_rua d_Bairro_Ruas = new dominio_bairro_rua();
        dominio_niveis_academicos d_Nivel_Academino = new dominio_niveis_academicos();
        dominio_cursos d_Curso = new dominio_cursos();
        dominio_casos d_Caso = new dominio_casos();
        #endregion
        public Form_Modulo_Vitimas()
        {
            InitializeComponent();
            selecionar_dados();
            filtrar();
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
        private void selecionar_dados()
        {
            // buscar casos
            text_caso.DataSource = d_Caso.selecionar_Casos_Combo_Box();
            text_caso.DisplayMember = "titulo";
            text_caso.ValueMember = "id_caso";
            // buscar nivel academico
            text_nivel_academico.DataSource = d_Nivel_Academino.selecionar_niveis_academicos_combo_box();
            text_nivel_academico.DisplayMember = "nome";
            text_nivel_academico.ValueMember = "id_nivel_academico";
            // buscar curso
            text_curso.DataSource = d_Curso.selecionar_Cursos_Combo_Box();
            text_curso.DisplayMember = "nome";
            text_curso.ValueMember = "id_curso";
        }
        #endregion
        private void text_continente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_continente.SelectedValue is int idPais)
            {
                carregar_Paises(idPais);
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
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCamposVazios()
        {
            if (text_continente.Text == String.Empty || text_pais.Text == String.Empty ||
              text_provincias.Text == String.Empty || text_municipio.Text == String.Empty
              || text_bairro_rua.Text == String.Empty || text_nivel_academico.Text == String.Empty ||
              text_primeiro_nome.Text == String.Empty || text_curso.Text == String.Empty
              || text_ultimo_nome.Text == String.Empty || text_sexo.Text == String.Empty ||
              text_primerio_numero_telefone.Text == String.Empty ||
              text_caso.Text == String.Empty || text_declaracao.Text == String.Empty)
            {
                MessageDialog_Error.Show("Os campos com (*) são de preechimento obrigatório!\n" +
                    "Por favor, preencha-os e tente novamente!", "Ocorreu um erro ao salvar os dados");
                return false;
            }
            return true;
        }

        private void CapturarDadosDigitadosFormulario()
        {
            // Capturar os dados do formulário
            int id_Caso = Convert.ToInt32(text_caso.SelectedValue);
            int id_Continente = Convert.ToInt32(text_continente.SelectedValue);
            int id_Pais = Convert.ToInt32(text_pais.SelectedValue);
            int id_Provincia = Convert.ToInt32(text_provincias.SelectedValue);
            int id_Municipio = Convert.ToInt32(text_municipio.SelectedValue);
            int id_Bairro_Rua = Convert.ToInt32(text_bairro_rua.SelectedValue);
            int id_Nivel_Academico = Convert.ToInt32(text_nivel_academico.SelectedValue);
            int id_Curso = Convert.ToInt32(text_curso.SelectedValue);
            int id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            string primeiro_Nome = text_primeiro_nome.Text;
            string nome_Meio = text_nome_meio.Text;
            string ultimo_nome = text_ultimo_nome.Text;
            DateTime data_Nascimento = text_data_nascimento.Value;
            string sexo = text_sexo.Text;
            string primeiro_Numero_Telefone = text_primerio_numero_telefone.Text;
            string segundo_Numero_Telefone = text_segundo_numero_telefone.Text;
            string E_Mail = text_e_mail.Text;
            string declaracao = text_declaracao.Text;

            // Salvar os dados capturados
            c_Vitimas.id_caso = id_Caso;
            c_Vitimas.id_continente = id_Continente;
            c_Vitimas.id_pais = id_Pais;
            c_Vitimas.id_provincia = id_Provincia;
            c_Vitimas.id_municipio = id_Municipio;
            c_Vitimas.id_bairro_rua = id_Bairro_Rua;
            c_Vitimas.id_nivel_academico = id_Nivel_Academico;
            c_Vitimas.id_curso = id_Curso;
            c_Vitimas.id_usuario = id_Usuario;
            c_Vitimas.primeiro_nome = primeiro_Nome;
            c_Vitimas.nome_meio = nome_Meio;
            c_Vitimas.ultimo_nome = ultimo_nome;
            c_Vitimas.data_nascimento = data_Nascimento;
            c_Vitimas.sexo = sexo;
            c_Vitimas.telefone1 = primeiro_Numero_Telefone;
            c_Vitimas.telefone2 = segundo_Numero_Telefone;
            c_Vitimas.e_mail = E_Mail;
            c_Vitimas.descricao = declaracao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVazios())
            {
                try
                {
                    DateTime data_Registro = DateTime.Now;
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Vitimas.data_registro = data_Registro;
                    c_Vitimas.data_atualizacao = data_Atualizacao;

                    CapturarDadosDigitadosFormulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar esta vítima?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Vitimas.inserir_vitimas(c_Vitimas);
                        guna2MessageDialog_Inform.Show($"A vítima {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi registrada com sucesso",
                            "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível salvar esta vítima!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVazios())
            {
                try
                {
                    int id_Vitima = Convert.ToInt32(label_id.Text);
                    DateTime data_Atualizacao = DateTime.Now;
                    c_Vitimas.data_atualizacao = data_Atualizacao;

                    CapturarDadosDigitadosFormulario();
                    c_Vitimas.id_vitima = id_Vitima;
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar esta vítima?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Vitimas.atualizar_vitimas(c_Vitimas);
                        guna2MessageDialog_Inform.Show($"A vítima {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi atualizada com sucesso!",
                            "Atualização bem sucedida");
                        limpar_Campos();
                        this.Dispose();
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar esta vítima.", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_caso.Text = String.Empty;
            text_continente.Text = String.Empty;
            text_pais.Text = String.Empty;
            text_provincias.Text = String.Empty;
            text_municipio.Text = String.Empty;
            text_bairro_rua.Text = String.Empty;
            text_nivel_academico.Text = String.Empty;
            text_curso.Text = String.Empty;
            text_primeiro_nome.Text = String.Empty;
            text_nome_meio.Text = String.Empty;
            text_ultimo_nome.Text = String.Empty;
            text_data_nascimento.Value = DateTime.Now;
            text_sexo.Text = String.Empty;
            text_primerio_numero_telefone.Text = String.Empty;
            text_segundo_numero_telefone.Text = String.Empty;
            text_e_mail.Text = String.Empty;
            text_declaracao.Text = String.Empty;
        }
        #region Validação de campos
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
        private void text_primerio_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_primerio_numero_telefone, label_msg_telefone1, "Apenas números são permitidos!");
        }
        private void text_segundo_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_segundo_numero_telefone, label_msg_telefone2, "Apenas números são permitidos!");
        }
        private void text_e_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarEmail(text_e_mail, label_msg_email, "Email inválido!");
        }
        private void text_declaracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_declaracao, label_msg_erro_descricao, "Apenas letras são permitidas!");
        }
        #endregion
    }
}
