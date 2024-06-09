using MetroFramework.Controls;
using Sistema_de_Pontos.ClassesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pontos
{
    public partial class MainForm : Form
    {
        //private Color laranjaForte;
        //public Color laranjaClaro = Color.FromArgb(0, 255, 0);
        //public Color vermelhoPrincipal = Color.FromArgb(166, 3, 3);
        //public Color VermelhoError = Color.FromArgb(0, 255, 0);
        //public Color VerdeSucess = Color.FromArgb(0, 255, 0);
        //public Color CinzaFundo = Color.FromArgb(235, 236, 239);
        bool changeController = true;
        public MainForm()
        {
            InitializeComponent();
            ConfiguraFormInicial();
            LoadForm(new FormRegistro());
            

        }


        public void ConfiguraFormInicial()
        {
            #region Mensagem de boas vindas.
            lblBemVindo.ForeColor = lblUsuario.ForeColor = CoresPersonalizadas.VermelhoEscuro;
            #endregion

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadForm(object Form)
        {
            if (this.pnlMainForm.Controls.Count > 0)
                this.pnlMainForm.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            this.pnlMainForm.Controls.Add(f);
            this.pnlMainForm.Tag = f;
            f.Show();
        }

        private void MudarForm_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (changeController)
            {
                LoadForm(new FormLoginAdmin());
                changeController = !changeController;
                MudarForm.Text = "Voltar";
            }
            else
            {
                LoadForm(new FormRegistro());
                changeController = !changeController;
                MudarForm.Text = "Entrar como Gerente";
            }
        }

        private void pnlMainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DAOSistemaDB.CriarBanco();
            DAOSistemaDB.DBConection();
            //DAOSistemaDB.CreateTables();
            //DAOSistemaDB.TesteInserts();
            //DAOSistemaDB.CreateViews();
        }
    }

}
