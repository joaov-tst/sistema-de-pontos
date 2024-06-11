using Sistema_de_Pontos.Entidades;
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
    public partial class ItemFuncionario : UserControl
    {
        public Funcionario Item { get; set; }
        public ItemFuncionario(Funcionario item)
        {
            InitializeComponent();
            Item = item;
            campoId.Text = item.Id.ToString();
            campoNome.Text = item.Nome.ToString();
            campoSobrenome.Text = item.Sobrenome.ToString();
            campoCpf.Text = item.Cpf.ToString();
            CampoEndereco.Text = item.Endereco.ToString();
            campoTelefone.Text = item.Telefone.ToString();
        }
    }
}
