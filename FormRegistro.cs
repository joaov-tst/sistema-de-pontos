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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private RetornoRegistro ChamaRegistrar(string cpf, string tipo_registro)
        {
            RetornoRegistro result = new RetornoRegistro();

            if (cpf != "123456")
            {
                result.Status = false;
                result.Message = "FUNCIONÁRIO NÃO ENCONTRADO";

            }
            
            //faz as verificações e tratamentos de entrada e chama o metodo que registra no banco

            return result;
        }

        private void personalizaMensagem(RetornoRegistro retorno)
        {
            if (retorno.Status)
            {
                this.pnlMessage.BackColor = Color.MediumSeaGreen;
                this.lblMessage.Text = retorno.Message +", {USER_NAME}!";
            }
            else {
                this.pnlMessage.BackColor = Color.Tomato;
                this.lblMessage.Text = retorno.Message; }

            this.pnlMainMessage.Visible = true;
            timerMessage.Start();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Chamar método que verifica os inputs e faz o registro se estiver tudo certo

            //pega o retorno do método para personalizar a mensagemd e resposta
            timerMessage.Interval = 4000;
            timerMessage.Tick += timerMessage_Tick;
            personalizaMensagem(ChamaRegistrar(inputCPF.Text, inputTopoRegistro.Text));

        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            this.pnlMainMessage.Visible = false;
            timerMessage.Stop();
        }
    }
}
