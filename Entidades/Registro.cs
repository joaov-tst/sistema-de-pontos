using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pontos.Entidades
{
    public class Registro
    {
        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nomeFuncionario;
        public string NomeFuncionario
        {
            get { return nomeFuncionario; }
            set { nomeFuncionario = value; }
        }

        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }


        private DateTime entrada;

        public DateTime Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        private DateTime? inicioIntervalo;
        public DateTime? InicioIntervalo
        {
            get { return inicioIntervalo; }
            set { inicioIntervalo = value; }
        }

        private DateTime? fimIntervalo;

        public DateTime? FimIntervalo
        {
            get { return fimIntervalo; }
            set { fimIntervalo = value; }
        }

        private DateTime? saida;

        public DateTime? Saida
        {
            get { return saida; }
            set { saida = value; }
        }

        private TimeSpan? totalIntervalo;

        public TimeSpan? TotalIntervalo
        {
            get { return totalIntervalo; }
            set { totalIntervalo = value; }
        }

        private TimeSpan? totalExpediente;

        public TimeSpan? TotalExpediente
        {
            get { return totalExpediente; }
            set { totalExpediente = value; }
        }
        //public Registro(string id, string nomeFuncionario, DateTime data, DateTime entrada, DateTime inicioIntervalo, DateTime fimIntervalo, DateTime saida)
        //{
        //    Id = id;
        //    NomeFuncionario = nomeFuncionario;
        //    Data = data;
        //    Entrada = entrada;
        //    InicioIntervalo = inicioIntervalo;
        //    FimIntervalo = fimIntervalo;
        //    Saida = saida;

        //    TotalIntervalo = fimIntervalo - inicioIntervalo;
        //    TotalExpediente = (saida - entrada) - TotalIntervalo;
        //}
    }
}
