using Sistema_de_Pontos.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pontos
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private RetornoRegistro ChamaRegistrar(string cpf, string tipo_registro)
        {
            RetornoRegistro result = new RetornoRegistro();
            DateTime dataHora = DateTime.Now;
            TimeSpan time = new TimeSpan(dataHora.Hour, dataHora.Minute, dataHora.Second);
            dataHora = dataHora.Date;
            try
            {
                SQLiteConnection conn = DAOSistemaDB.DBConection();
                using (conn)
                {

                    // Consulta para obter o id_funcionario a partir do cpf
                    string query = "SELECT id_funcionario, Nome FROM TB_FUNCIONARIO WHERE cpf = @cpf";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                result.Status = false;
                                result.Message = "FUNCIONÁRIO NÃO ENCONTRADO";
                                return result;
                            }

                            string idFuncionario = reader["id_funcionario"].ToString();
                            result.NomeFuncionario = reader["Nome"].ToString();

                            // Montar a consulta de inserção com base no tipo de registro
                            switch (tipo_registro)
                            {
                                case "Início do Expediente":
                                    query = "INSERT INTO TB_REGISTRO (FuncionarioID, HorarioEntrada, Data) VALUES (@id_funcionario, @data_hora, @data)";
                                    break;

                                case "Início do Intervalo":
                                    query = "INSERT INTO TB_REGISTRO (FuncionarioID, HorarioInicioIntervalo, Data) VALUES (@id_funcionario, @data_hora, @data)";
                                    break;

                                case "Fim do Intervalo":
                                    query = "INSERT INTO TB_REGISTRO (FuncionarioID, HorarioFimIntervalo, Data) VALUES (@id_funcionario, @data_hora, @data)";
                                    break;

                                case "Fim do Expediente":
                                    query = "INSERT INTO TB_REGISTRO (FuncionarioID, HorarioSaida, Data) VALUES (@id_funcionario, @data_hora, @data)";
                                    break;

                                default:
                                    MessageBox.Show("Opção inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return result; // Saia da função após mensagem de erro
                            }

                            // Inserir o novo registro na tabela TB_REGISTRO
                            using (SQLiteCommand cmd2 = new SQLiteCommand(query, conn))
                            {
                                cmd2.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                                cmd2.Parameters.AddWithValue("@data_hora", time);
                                cmd2.Parameters.AddWithValue("@data", dataHora);

                                int resultado = cmd2.ExecuteNonQuery();
                                if (resultado > 0)
                                {
                                    result.Status = true;
                                    result.Message = "Registro inserido com sucesso.";
                                }
                                else
                                {
                                    result.Status = false;
                                    result.Message = "Falha ao inserir registro.";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        private void personalizaMensagem(RetornoRegistro retorno)
        {
            if (retorno.Status)
            {
                this.pnlMessage.BackColor = Color.MediumSeaGreen;
                this.lblMessage.Text = retorno.Message + $", {retorno.NomeFuncionario}!";
            }
            else
            {
                this.pnlMessage.BackColor = Color.Tomato;
                this.lblMessage.Text = retorno.Message;
            }

            this.pnlMainMessage.Visible = true;
            timerMessage.Start();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Chamar método que verifica os inputs e faz o registro se estiver tudo certo

            //pega o retorno do método para personalizar a mensagemd e resposta
            timerMessage.Interval = 4000;
            timerMessage.Tick += timerMessage_Tick;
            string cpf = inputCPF.Text.ToString();
            string tipoRegisro = inputTopoRegistro.Text.ToString();

            personalizaMensagem(ChamaRegistrar(cpf, tipoRegisro));

        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            this.pnlMainMessage.Visible = false;
            timerMessage.Stop();
        }
    }
}
