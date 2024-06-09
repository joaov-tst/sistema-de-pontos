using Sistema_de_Pontos.ClassesDAO;
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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void CarregaDados()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DAOSistemaDB.getTeste();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
