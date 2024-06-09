using Sistema_de_Pontos.ClassesDAO;
using Sistema_de_Pontos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pontos
{
    public partial class FormListaRegistros : Form
    {
        private List<ItemRegistro> registros = new List<ItemRegistro>();
        public FormListaRegistros()
        {
            InitializeComponent();
            cargaInicial();
            //label2.Text = inputData.Value.Date.ToString("d");
        }

        private void ConfiguraItem( ItemRegistro novoItem)
        {
            Padding margin = new Padding();
            margin = Padding.Empty;
            margin.Bottom = 1;
            novoItem.Margin = Padding.Empty;
            novoItem.Margin = margin;
            novoItem.Dock = DockStyle.Top;
        }
        public void cargaInicial()
        {
            foreach (ItemRegistro novoItem in registros)
            {
                painelListagem.Controls.Clear();
                if (novoItem.Item.Data.Date == inputData.Value.Date)
                {
                    painelListagem.Controls.Add(novoItem);

                    ConfiguraItem(novoItem);
                }
            }
        }
        

        public void LimparFiltros()
        {
            painelListagem.Controls.Clear();
            foreach (ItemRegistro novoItem in registros)
            {
                painelListagem.Controls.Add(novoItem);
                ConfiguraItem(novoItem);
            }
        }

        private void ObterRegistrosFiltrados()
        {
            string nomeFuncionario = inputNome.Text;
            DateTime? dataRegistro = inputData.Value;
            DateTime? horarioInicio = inputHora.Value;
            DateTime? periodoInicio = dataInicio.Value;
            DateTime? periodoFim = dataFim.Value;

            var registrosFiltrados = registros.Where(r =>
                (string.IsNullOrEmpty(nomeFuncionario) || r.Item.NomeFuncionario.Contains(nomeFuncionario)) &&
                (!dataRegistro.HasValue || r.Item.Data.Date == dataRegistro.Value.Date) &&
                (!horarioInicio.HasValue || r.Item.Entrada.Hour == horarioInicio.Value.Date.Hour) &&
                (!periodoInicio.HasValue || r.Item.Data.Date >= periodoInicio.Value.Date) &&
                (!periodoFim.HasValue || r.Item.Data.Date <= periodoFim.Value.Date)
            ).ToList();
        }

       

        private void iconLimparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }
    }
}
