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
    public partial class PainelAdmin : MetroFramework.Forms.MetroForm
    {
        public PainelAdmin()
        {
            InitializeComponent();
            this.DisplayHeader = false;
            this.Padding = new System.Windows.Forms.Padding(0,0,0,0);
            
        }
    }
}
