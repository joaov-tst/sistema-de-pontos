using Sistema_de_Pontos.ClassesDAO;
using Sistema_de_Pontos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pontos
{
    public partial class FormListaFuncionarios : Form
    {
        public List<ItemFuncionario> itemFuncionarios = new List<ItemFuncionario>();
        public FormListaFuncionarios()
        {
            InitializeComponent();
            ObterRegistros();
            cargaInicial();
        }

        private void ConfiguraItem(ItemFuncionario novoItem)
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
            painelListagem.Controls.Clear();
            foreach (ItemFuncionario novoItem in itemFuncionarios)
            {
                    painelListagem.Controls.Add(novoItem);
                    ConfiguraItem(novoItem);
            }
        }

        public void ObterRegistros()
        {
            using (var connection = DAOSistemaDB.DBConection())
            {
                string query = "SELECT id_funcionario, nome, sobrenome, cpf, telefone, rua, numero, bairro, cidade FROM VW_ENDERECO_FORMATADO";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var funcionario = new Funcionario();

                        funcionario.Id = reader.GetInt64(0);
                        funcionario.Nome = reader.GetString(1);
                        funcionario.Sobrenome = reader.GetString(2);
                        funcionario.Cpf = reader.GetString(3);
                        funcionario.Endereco = "RUA " + reader.GetString(5) + ", " + reader.GetInt32(6).ToString() + ", BAIRRO " + reader.GetString(7) + ", " + reader.GetString(8);
                        funcionario.Telefone = reader.GetString(4);

                        itemFuncionarios.Add(new ItemFuncionario(funcionario));

                    }
                }
            }
        }

        private List<ItemFuncionario> RegistrosFiltrados()
        {
            string nomeFuncionario = inputNome.Text.ToUpper();

            return itemFuncionarios.Where(r =>
                (string.IsNullOrEmpty(nomeFuncionario) || r.Item.Nome.Contains(nomeFuncionario))
                ).ToList();
        }

        public void LimparFiltros()
        {
            painelListagem.Controls.Clear();
            foreach (ItemFuncionario novoItem in itemFuncionarios)
            {
                painelListagem.Controls.Add(novoItem);
                ConfiguraItem(novoItem);
            }
            inputNome.Text = "";
        }

        public void AplicarFiltros(List<ItemFuncionario> itensFiltrados)
        {
            painelListagem.Controls.Clear();
            foreach (ItemFuncionario item in itensFiltrados)
            {
                painelListagem.Controls.Add(item);
                ConfiguraItem(item);
            }
        }

        private void aplicarFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros(RegistrosFiltrados());
        }

        private void iconLimparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }
    }
}
