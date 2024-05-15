using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pontos
{
    internal static class CoresPersonalizadas
    {
		private static Color vermelhoEscuro = Color.FromArgb(166, 3, 3);
		private static Color vermelhoHover = Color.FromArgb(166, 37, 37);


		public static Color VermelhoEscuro
		{
			get { return vermelhoEscuro; }
			set { vermelhoEscuro = value; }
		}

		public static Color VermelhoHover
        {
			get { return vermelhoHover; }
			set { vermelhoHover = value; }
		}

	}
}
