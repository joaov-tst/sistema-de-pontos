using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pontos
{
    internal class RetornoRegistro
    {
        private bool status;
        private string message;
        private string nomeFuncionario;

        public string NomeFuncionario
        {
            get { return nomeFuncionario; }
            set { nomeFuncionario = value; }
        }


        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public RetornoRegistro()
        {
            status = true;
            message = "Ponto registrado";
        }
    }
}
