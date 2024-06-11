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
        private List<ItemRegistro> ItemRegistros = new List<ItemRegistro>();

        public FormListaRegistros()
        {
            InitializeComponent();
            ObterRegistros();
            cargaInicial();
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
            painelListagem.Controls.Clear();
            foreach (ItemRegistro novoItem in ItemRegistros)
            {

                if (novoItem.Item.Data.Date == inputData.Value.Date)
                {
                    painelListagem.Controls.Add(novoItem);
                    ConfiguraItem(novoItem);
                }
            }
        }
        public void ObterRegistros()
        {
            var registros = new List<Registro>();

            using (var connection = DAOSistemaDB.DBConection())
            {
                string query = "SELECT id_registro, nome_funcionario, sobrenome_funcionario, Data, HorarioEntrada, HorarioInicioIntervalo, HorarioFimIntervalo, HorarioSaida FROM VW_REGISTRO_FORMATADO";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var registro = new Registro();

                        registro.Id = reader.GetInt64(0);
                        registro.NomeFuncionario = reader.GetString(1) + " " + reader.GetString(2);
                        registro.Data = reader.GetDateTime(3);
                        registro.Entrada = reader.GetDateTime(4);
                        registro.InicioIntervalo = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                        registro.FimIntervalo = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                        registro.Saida = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7);


                        if (registro.InicioIntervalo.HasValue && registro.FimIntervalo.HasValue)
                        {
                            registro.TotalIntervalo = registro.FimIntervalo.Value - registro.InicioIntervalo.Value;
                        }
                        else
                        {
                            registro.TotalIntervalo = null;
                        }

                        if(registro.Saida.HasValue && registro.TotalIntervalo != null)
                        {
                            registro.TotalExpediente = (registro.Saida.Value - registro.Entrada) - registro.TotalIntervalo;
                        }
                        else
                        {
                            registro.TotalExpediente = null;
                        }

                        ItemRegistros.Add(new ItemRegistro(registro));


                        registros.Add(registro);
                    }
                }
            }
        }
        

        public void LimparFiltros()
        {
           painelListagem.Controls.Clear();
           foreach (ItemRegistro novoItem in ItemRegistros)
            {
                painelListagem.Controls.Add(novoItem);
                ConfiguraItem(novoItem);
            }
        }

        private List<ItemRegistro> RegistrosFiltrados()
        {
            string nomeFuncionario = inputNome.Text.ToUpper();
            DateTime? dataRegistro = inputData.Value;

            return ItemRegistros.Where(r =>
                (string.IsNullOrEmpty(nomeFuncionario) || r.Item.NomeFuncionario.Contains(nomeFuncionario)) &&
                (!dataRegistro.HasValue || r.Item.Data.Date == dataRegistro.Value.Date)).ToList();
        }


        public void AplicarFiltros(List<ItemRegistro> itensFiltrados)
        {
            painelListagem.Controls.Clear();
            foreach (ItemRegistro item in itensFiltrados)
            {
                painelListagem.Controls.Add(item);
                ConfiguraItem(item);
            }
        }

        public void CarregaRegistros()
        {
            //List<ItemModel> listagemRegistros = new List<ItemModel>();
            //int id = 1;

            //ItemRegistro registro1 = new ItemRegistro {
            //    Id = "1",
            //    NomeFuncionario = "João Vitor Carvalho Santos",
            //    DataRegistro = "13/04/2024",
            //    Entrada = "12:20",
            //    InicioIntervalo = "13:30",
            //    FimIntervalo = "14:30",
            //    Saida = "19:30",
            //    TotalIntervalo = "01:00",
            //    TotalExpediente = "6:20"
            //};

            //registrosPontos.Add(registro1);

            //Entidades.Registro novoRegistro = new Entidades.Registro("1", "Gabriel Azevedo", DateTime.Now, new DateTime(1, 1, 1, 8, 0, 0), new DateTime(1, 1, 1, 11, 0, 0), new DateTime(1, 1, 1, 12, 0, 0), new DateTime(1, 1, 1, 17, 0, 0));

            //ItemRegistro registro2 = new ItemRegistro(novoRegistro);

            //registros.Add(registro2);
        }

        private void iconLimparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void aplicarFiltros_Click(object sender, EventArgs e)
        {
            AplicarFiltros(RegistrosFiltrados());
        }


        //private void ExibirRegistros()
        //{
        //    List<Registro> registros = ObterRegistros();

        //    foreach (var registro in registros)
        //    {
        //        string entrada = registro.Entrada.ToString("HH:mm");
        //        string saida = registro.Saida.HasValue ? registro.Saida.Value.ToString("HH:mm") : "-";
        //        string inicioIntervalo = registro.InicioIntervalo.HasValue ? registro.InicioIntervalo.Value.ToString("HH:mm") : "-";
        //        string fimIntervalo = registro.FimIntervalo.HasValue ? registro.FimIntervalo.Value.ToString("HH:mm") : "-";

        //        // Supondo que você esteja adicionando os registros a um DataGridView ou ListView
        //        string[] row = { entrada, saida, inicioIntervalo, fimIntervalo };
        //        dataGridView1.Rows.Add(row); // Exemplo para DataGridView
        //    }
        //}

    }
}
