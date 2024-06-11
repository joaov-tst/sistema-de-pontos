using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pontos.Entidades
{
    public class Endereco
    {
            public int IdEndereco { get; set; }
            public string Cidade { get; set; }
            public string Bairro { get; set; }
            public string Rua { get; set; }
            public long Numero { get; set; }
            public string Complemento { get; set; }
    }
    
}
