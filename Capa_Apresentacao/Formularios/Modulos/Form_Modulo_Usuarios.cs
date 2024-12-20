//-----------------------------------------
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Usuarios : Form
    {

        #region Instanciar as classes e os métodos
        e_comum_usuarios c_Usuarios = new e_comum_usuarios();
        dominio_usuarios d_Usuarios = new dominio_usuarios();
        dominio_continentes d_Continentes = new dominio_continentes();
        dominio_paises d_Paises = new dominio_paises();
        dominio_provincias d_Provincias = new dominio_provincias();
        dominio_municipios d_Municipios = new dominio_municipios();
        dominio_bairro_rua d_Bairro_Ruas = new dominio_bairro_rua();
        #endregion
        public Form_Modulo_Usuarios()
        {
            InitializeComponent();
            // chamar o método
            filtrar();

        }
        #region M´étodo para selecionar os dados e trazê-los nos seus respectivos comboBox´s
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
        #endregion
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerificarCamposVazios()
        {
            if (text_continente.Text == String.Empty || text_pais.Text == String.Empty ||
              text_provincias.Text == String.Empty || text_municipio.Text == String.Empty
              || text_bairro_rua.Text == String.Empty || text_primeiro_nome.Text == String.Empty
              || text_ultimo_nome.Text == String.Empty || text_numero_bi.Text == String.Empty ||
              text_sexo.Text == String.Empty || text_primerio_numero_telefone.Text == String.Empty ||
              text_tipo_usuario.Text == String.Empty || text_palavra_passe.Text == String.Empty)
            {
                MessageDialog_Error.Show("Os campos com (*) são de preechimento obrigatórios!\n" +
                    "Por favor, preencha-os e tente novamente!", "Ocorreu um erro ao salvar os dados");
                return false;
            }
            return true;
        }
        private void CapturarDadosFormulario()
        {
            // Capturar os dados do formulário
            int continente = Convert.ToInt32(text_continente.SelectedValue);
            int pais = Convert.ToInt32(text_pais.SelectedValue);
            int provincia = Convert.ToInt32(text_provincias.SelectedValue);
            int municipio = Convert.ToInt32(text_municipio.SelectedValue);
            int bairro_Rua = Convert.ToInt32(text_bairro_rua.SelectedValue);
            string primeiro_Nome = text_primeiro_nome.Text;
            string nome_Meio = text_nome_meio.Text;
            string ultimo_nome = text_ultimo_nome.Text;
            //DateTime data_Nascimento = text_data_nascimento.Value;
            string numero_Bi = text_numero_bi.Text;
            string sexo = text_sexo.Text;
            string primeiro_Numero_Telefone = text_primerio_numero_telefone.Text;
            string segundo_Numero_Telefone = text_segundo_numero_telefone.Text;
            string E_Mail = text_e_mail.Text;
            string tipo_Usuario = text_tipo_usuario.Text;
            string palavra_Passe = text_palavra_passe.Text;

            // Salvar os dados capturados
            c_Usuarios.id_continente = continente;
            c_Usuarios.id_pais = pais;
            c_Usuarios.id_provincia = provincia;
            c_Usuarios.id_municipio = municipio;
            c_Usuarios.id_bairro_rua = bairro_Rua;
            c_Usuarios.primeiro_nome = primeiro_Nome;
            c_Usuarios.nome_meio = nome_Meio;
            c_Usuarios.ultimo_nome = ultimo_nome;
            c_Usuarios.bi = numero_Bi;
            c_Usuarios.sexo = sexo;
            c_Usuarios.telefone1 = primeiro_Numero_Telefone;
            c_Usuarios.telefone2 = segundo_Numero_Telefone;
            c_Usuarios.e_mail = E_Mail;
            c_Usuarios.tipo_usuario = tipo_Usuario;
            c_Usuarios.palavra_passe = palavra_Passe;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    CapturarDadosFormulario();
                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este usuário?", "Mensagem de registro") == DialogResult.Yes)
                    {
                        d_Usuarios.inserir_usuarios(c_Usuarios);
                        guna2MessageDialog_Inform.Show($"O usuário {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi registrado com sucesso",
                            "Registro bem sucedido");
                        limpar_Campos();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    string erro_Duplicacao = ex.Message;
                    if (erro_Duplicacao.Contains("bi"))
                    {
                        MessageDialog_Error.Show("O 'Nº do bilhete de identidade' inserido já existe!\nPor favor, insira um outro 'Nº do bilhete de identidade' e tente novamente!", "Erro de duplicação");
                        text_primerio_numero_telefone.Focus();
                    }
                    if (erro_Duplicacao.Contains("telefone1"))
                    {
                        MessageDialog_Error.Show("O 'Nº de telefone' inserido já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação");
                        text_primerio_numero_telefone.Focus();
                    }
                    if (erro_Duplicacao.Contains("telefone2"))
                    {
                        MessageDialog_Error.Show("O 'Nº de telefone alternativo' inserido já existe!\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Erro de duplicação");
                        text_segundo_numero_telefone.Focus();
                    }
                    if (erro_Duplicacao.Contains("e_mail"))
                    {
                        MessageDialog_Error.Show("O 'E-mail' inserido já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");
                        text_e_mail.Focus();
                    }
                    if (erro_Duplicacao.Contains("palavra_passe"))
                    {
                        MessageDialog_Error.Show("A 'Palavra-passe' inserida já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");
                        text_palavra_passe.Focus();
                    }
                    else
                    {
                        MessageDialog_Error.Show("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação");
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este usuário!", Ex.Message);
                }
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                try
                {
                    int id_Usuario = Convert.ToInt32(label_id.Text);
                    CapturarDadosFormulario();
                    c_Usuarios.id_usuario = id_Usuario;

                    if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar este usuário?", "Mensagem de atualização") == DialogResult.Yes)
                    {
                        d_Usuarios.atualizar_usuarios(c_Usuarios);
                        guna2MessageDialog_Inform.Show($"O usuário {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi atualizado com sucesso!",
                            "Atualização bem sucedida");
                        limpar_Campos();
                        this.Dispose();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    string erro_Duplicacao = ex.Message;
                    if (erro_Duplicacao.Contains("bi"))
                    {
                        MessageDialog_Error.Show("O 'Nº do bilhete de identidade' inserido já existe!\nPor favor, insira um outro 'Nº do bilhete de identidade' e tente novamente!", "Erro de duplicação");
                        text_primerio_numero_telefone.Focus();
                    }
                    if (erro_Duplicacao.Contains("telefone1"))
                    {
                        MessageDialog_Error.Show("O 'Nº de telefone' inserido já existe!\nPor favor, insira um outro 'Nº de telefone' e tente novamente!", "Erro de duplicação");
                        text_primerio_numero_telefone.Focus();
                    }
                    if (erro_Duplicacao.Contains("telefone2"))
                    {
                        MessageDialog_Error.Show("O 'Nº de telefone alternativo' inserido já existe!\nPor favor, insira um outro 'Nº de telefone alternativo' e tente novamente!", "Erro de duplicação");
                        text_segundo_numero_telefone.Focus();
                    }
                    if (erro_Duplicacao.Contains("e_mail"))
                    {
                        MessageDialog_Error.Show("O 'E-mail' inserido já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");
                        text_e_mail.Focus();
                    }
                    if (erro_Duplicacao.Contains("palavra_passe"))
                    {
                        MessageDialog_Error.Show("A 'Palavra-passe' inserida já existe!\nPor favor, insira um outro 'E-mail' e tente novamente!", "Erro de duplicação");
                        text_palavra_passe.Focus();
                    }
                    else
                    {
                        MessageDialog_Error.Show("Ocorreu um erro de duplicação de dados.\nVerifique os dados inseridos e tente novamente!", "Erro de duplicação");
                    }
                }
                catch (Exception Ex)
                {
                    MessageDialog_Error.Show("Não foi possível atualizar este usuário!", Ex.Message);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }
        private void limpar_Campos()
        {
            text_continente.SelectedIndex = -1;
            text_pais.SelectedIndex = -1;
            text_provincias.SelectedIndex = -1;
            text_municipio.SelectedIndex = -1;
            text_bairro_rua.SelectedIndex = -1;
            text_primeiro_nome.Text = String.Empty;
            text_nome_meio.Text = String.Empty;
            text_ultimo_nome.Text = String.Empty;
            text_numero_bi.Text = String.Empty;
            text_sexo.Text = String.Empty;
            text_primerio_numero_telefone.Text = String.Empty;
            text_segundo_numero_telefone.Text = String.Empty;
            text_e_mail.Text = String.Empty;
            text_tipo_usuario.Text = String.Empty;
            text_palavra_passe.Text = String.Empty;
        }
        #region Validações de campos

        private void text_primerio_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_primerio_numero_telefone, label_msg_telefone1, "Apenas números são permitidas!");
        }
        private void text_segundo_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_segundo_numero_telefone, label_msg_telefone2, "Apenas números são permitidas!");
        }

        private void text_numero_bi_TextChanged(object sender, EventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarBilheteIdentidade(text_numero_bi, label_msg_bi, "Número do BI inválido!");
        }

        private void text_e_mail_TextChanged_1(object sender, EventArgs e)
        {
            validacao_campos_formularios.ValidadorCampos.ValidarEmail(text_e_mail, label_msg_email, "Email inválido!");
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
        #endregion


    }
}
