using Sistema_de_Pontos.Entidades;
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
    public partial class ItemRegistro : UserControl
    {
        private Registro item;

        public Registro Item
        {
            get { return item; }
            set { item = value; }
        }


        public ItemRegistro(Registro item)
        {
            InitializeComponent();
            Item = item;
            campoId.Text = item.Id.ToString();
            campoNomeFuncionario.Text = item.NomeFuncionario;
            campoData.Text = item.Data.ToString("d");
            campoEntrada.Text = item.Entrada.ToString("HH:mm");
            CampoIntervalo.Text = item.InicioIntervalo.ToString("HH:mm");
            campoFimIntervalo.Text = item.FimIntervalo.ToString("HH:mm");
            CampoSaida.Text = item.Saida.ToString("HH:mm");
            DurIntervalo.Text = string.Format("{0:D2}:{1:D2}", item.TotalIntervalo.Hours, item.TotalIntervalo.Minutes);
            durExpediente.Text = string.Format("{0:D2}:{1:D2}", item.TotalExpediente.Hours, item.TotalExpediente.Minutes);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
