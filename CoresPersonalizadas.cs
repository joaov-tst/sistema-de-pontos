using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pontos
{
    internal class CoresPersonalizadas
    {
		private Color vermelhoEscuro;
		private  Color vermelhoHover;


		public Color VermelhoEscuro
		{
			get { return vermelhoEscuro; }
			set { vermelhoEscuro = value; }
		}


		public Color VermelhoHover
        {
			get { return vermelhoHover; }
			set { vermelhoHover = value; }
		}

		public CoresPersonalizadas()
		{
			vermelhoEscuro = Color.FromArgb(166, 3, 3);
            vermelhoHover = Color.FromArgb(166, 37, 37);
        }

	}
}
