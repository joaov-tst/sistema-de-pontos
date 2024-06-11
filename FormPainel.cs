using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pontos
{
    public partial class FormPainel : Form
    {
        public FormPainel()
        {
            InitializeComponent();
            LoadForm(new FormListaRegistros());
            this.StartPosition = FormStartPosition.CenterScreen;
            AddClickEventToPanelAndChildren(pnlRegistros, pnlRegistros_Click);
            AddClickEventToPanelAndChildren(pnlFuncionarios, pnlFuncionarios_Click);
            AddClickEventToPanelAndChildren(pnlAjuda, pnlAjuda_Click);
            AddClickEventToPanelAndChildren(pnlSettings, pnlSettings_Click);
        }

        public void LimpaFundoSideBar()
        {
            pnlRegistros.BackColor = pnlFuncionarios.BackColor = pnlAjuda.BackColor = pnlSettings.BackColor =  Color.Gainsboro;
        }
        public void TrocaSelecao(int  idOpcao)
        {
            if(idOpcao == 1) {
                LimpaFundoSideBar();
                pnlRegistros.BackColor = Color.DarkSalmon;
            } else if(idOpcao == 2)
            {
                LimpaFundoSideBar();
                pnlFuncionarios.BackColor = Color.DarkSalmon;
            }
            else if (idOpcao == 3)
            {
                LimpaFundoSideBar();
                pnlAjuda.BackColor = Color.DarkSalmon;
            }
            else
            {
                LimpaFundoSideBar();
                pnlSettings.BackColor = Color.DarkSalmon;
            }
        }

        private void LoadForm(object Form)
        {
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            this.pnlContent.Controls.Add(f);
            this.pnlContent.Tag = f;
            f.Show();
        }

        private void pnlRegistros_Click(object sender, EventArgs e)
        {
            TrocaSelecao(1);
            LoadForm(new FormListaRegistros());
        }

        private void pnlFuncionarios_Click(object sender, EventArgs e)
        {
            TrocaSelecao(2);
            LoadForm(new FormListaFuncionarios());
        }

        private void pnlAjuda_Click(object sender, EventArgs e)
        {
            TrocaSelecao(3);
            LoadForm(new FormCadastroFuncionario());
        }

        private void pnlSettings_Click(object sender, EventArgs e)
        {
            TrocaSelecao(4);
            LoadForm(new FormSettings());
        }

        private void AddClickEventToPanelAndChildren(Control control, EventHandler eventHandler)
        {
            control.Click += eventHandler;

            foreach (Control child in control.Controls)
            {
                AddClickEventToPanelAndChildren(child, eventHandler);
            }
        }
    }
}
