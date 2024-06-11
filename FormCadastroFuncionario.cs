using Sistema_de_Pontos.ClassesDAO;
using Sistema_de_Pontos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pontos
{
    public partial class FormCadastroFuncionario : Form
    {
        private Endereco NovoEndereco =  new Endereco();
        private Funcionario NovoFuncionario = new Funcionario();
        public FormCadastroFuncionario()
        {
            InitializeComponent();

            lblRua.TextChanged += new EventHandler(CheckFormFields);
            lblNumero.TextChanged += new EventHandler(CheckFormFields);
            lblNome.TextChanged += new EventHandler(CheckFormFields);
            lblSobrenome.TextChanged += new EventHandler(CheckFormFields);
            lblCpf.TextChanged += new EventHandler(CheckFormFields);
            lblBairro.TextChanged += new EventHandler(CheckFormFields);
            lblTelefone.TextChanged += new EventHandler(CheckFormFields);
            lblCidade.TextChanged += new EventHandler(CheckFormFields);

            // Verificar os campos inicialmente
            CheckFormFields(null, null);
        }

        private void CheckFormFields(object sender, EventArgs e)
        {
            btnSalvar.Enabled = !string.IsNullOrWhiteSpace(lblRua.Text) &&
                                 !string.IsNullOrWhiteSpace(lblNumero.Text) &&
                                 !string.IsNullOrWhiteSpace(lblNome.Text) &&
                                 !string.IsNullOrWhiteSpace(lblSobrenome.Text) &&
                                 !string.IsNullOrWhiteSpace(lblCpf.Text) &&
                                 !string.IsNullOrWhiteSpace(lblTelefone.Text) &&
                                 !string.IsNullOrWhiteSpace(lblBairro.Text) &&
                                 !string.IsNullOrWhiteSpace(lblCidade.Text);
            string n = lblCidade.Text;
        }

        private void LimparCampos()
        {
            NovoFuncionario.Cpf = "";
            lblRua.Text = lblNumero.Text = lblNome.Text = lblSobrenome.Text = lblCpf.Text = lblBairro.Text = lblTelefone.Text = lblCidade.Text = "";
        }
        
        private void btnCancela_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CriarFuncionario()
        {
            if (string.IsNullOrWhiteSpace(lblComplemento.Text)) lblComplemento.Text = "";



            try
            {
                using (var connection = DAOSistemaDB.DBConection())
                {

                    long enderecoId = 0;

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Inserir Endereço
                            using (var cmdInsertEndereco = connection.CreateCommand())
                            {
                                cmdInsertEndereco.CommandText = "INSERT INTO TB_ENDERECO (cidade, bairro, rua, numero, complemento) VALUES (@cidade, @bairro, @rua, @numero, @complemento); SELECT last_insert_rowid();";
                                cmdInsertEndereco.Parameters.AddWithValue("@cidade", lblCidade.Text.ToUpper());
                                cmdInsertEndereco.Parameters.AddWithValue("@bairro", lblBairro.Text.ToUpper());
                                cmdInsertEndereco.Parameters.AddWithValue("@rua", lblRua.Text.ToUpper());
                                cmdInsertEndereco.Parameters.AddWithValue("@numero", long.Parse(lblNumero.Text));
                                cmdInsertEndereco.Parameters.AddWithValue("@complemento", lblComplemento.Text.ToUpper());

                                enderecoId = (long)cmdInsertEndereco.ExecuteScalar();
                            }

                            // Inserir Funcionário
                            using (var cmdInsertFuncionario = connection.CreateCommand())
                            {
                                cmdInsertFuncionario.CommandText = "INSERT INTO TB_FUNCIONARIO (nome, sobrenome, cpf, endereco, telefone) VALUES (@nome, @sobrenome, @cpf, @endereco, @telefone)";
                                cmdInsertFuncionario.Parameters.AddWithValue("@nome", lblNome.Text.ToUpper());
                                cmdInsertFuncionario.Parameters.AddWithValue("@sobrenome", lblSobrenome.Text.ToUpper());
                                cmdInsertFuncionario.Parameters.AddWithValue("@cpf", lblCpf.Text.ToUpper());
                                cmdInsertFuncionario.Parameters.AddWithValue("@endereco", enderecoId);
                                cmdInsertFuncionario.Parameters.AddWithValue("@telefone", lblTelefone.Text);

                                cmdInsertFuncionario.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            timerMessage.Interval = 4000;
                            timerMessage.Tick += timerMessage_Tick;
                            lblMessage.Text = $"{lblNome.Text.ToUpper()} FOI CADASTRADO COM SUCESSO!";
                            pnlMessage.Visible = true;
                            timerMessage.Start();

                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                        }
                    }
                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CriarFuncionario();
            LimparCampos();
        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            this.pnlMessage.Visible = false;
            timerMessage.Stop();
        }
    }
}
