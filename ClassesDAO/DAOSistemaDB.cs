using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Pontos.ClassesDAO
{
    public class DAOSistemaDB
    {
        public static string path = Directory.GetCurrentDirectory() + "\\database.sqlite"; //Diretorio do arquivo sql

        public static SQLiteConnection sqliteConection;

        public static SQLiteConnection DBConection()
        {
            sqliteConection = new SQLiteConnection("Data Source=" + path); //cria uma conexão informando que o caminho do banco de dados é path
            sqliteConection.Open(); // Abre a conexão
            return sqliteConection;
        }

        public static void CriarBanco()
        {
            try
            {
                if (!File.Exists(path))
                    SQLiteConnection.CreateFile(path); // Se não existir o arquivo no caminho path ele será criado
            }
            catch
            {
                throw;
            }
        }


        internal static void CreateTables()
        {
            try
            {
                using (var connection = DBConection()) // Certifique-se de que DBConnection() está retornando uma conexão válida
                {
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS TB_ADMIN (
                                id_admin INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nome VARCHAR(100) NOT NULL, 
                                sobrenome VARCHAR(100) NOT NULL, 
                                usuario VARCHAR(11) UNIQUE NOT NULL, 
                                senha VARCHAR(11) NOT NULL, 
                                is_logado INTEGER NOT NULL
                            );
                            CREATE TABLE IF NOT EXISTS TB_ENDERECO (
                                id_endereco INTEGER PRIMARY KEY AUTOINCREMENT, 
                                cidade VARCHAR(45) NOT NULL, 
                                bairro VARCHAR(45) NOT NULL, 
                                rua VARCHAR(45) NOT NULL, 
                                numero BIGINT, 
                                complemento VARCHAR(60)
                            );
                            CREATE TABLE IF NOT EXISTS TB_FUNCIONARIO (
                                id_funcionario INTEGER PRIMARY KEY AUTOINCREMENT, 
                                nome VARCHAR(100) NOT NULL, 
                                sobrenome VARCHAR(100) NOT NULL, 
                                cpf VARCHAR(11) UNIQUE NOT NULL, 
                                endereco INTEGER, 
                                telefone VARCHAR, 
                                FOREIGN KEY (endereco) REFERENCES TB_ENDERECO (id_endereco)
                            );

                            CREATE TABLE IF NOT EXISTS TB_REGISTRO (
                                id_registro INTEGER PRIMARY KEY AUTOINCREMENT, 
                                FuncionarioId INTEGER NOT NULL,
                                Data DATE NOT NULL,
                                HorarioEntrada TIME,
                                HorarioInicioIntervalo TIME,
                                HorarioFimIntervalo TIME,
                                HorarioSaida TIME,
                                TotalIntervalo TIME,
                                TotalExpediente TIME,
                                FOREIGN KEY (FuncionarioId) REFERENCES TB_FUNCIONARIO (id_funcionario)
                            );
                        ";
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = connection.CreateCommand())
                    {
                        // Inserindo o primeiro admin
                        cmd.CommandText = "INSERT INTO TB_ADMIN (nome, sobrenome, usuario, senha, is_logado) VALUES ('First', 'Admin', 'Admin', '123456', 0);";
                        cmd.ExecuteNonQuery();
                    }

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = connection.CreateCommand())
                            {
                                cmd.CommandText = "INSERT INTO TB_ENDERECO (cidade, bairro, rua, numero, complemento) VALUES ('Belo Horizonte', 'Ouro Preto', 'Boaventura', 67, '')";
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao inserir registro: " + ex.Message);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void TesteInserts()
        {
            try
            {
                using (var connection = DBConection())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = connection.CreateCommand())
                            {
                                //cmd.CommandText = @"DELETE FROM TB_ENDERECO WHERE id_endereco IN (2, 3, 4);";
                                //cmd.CommandText = @"INSERT INTO TB_FUNCIONARIO (nome, sobrenome, cpf, endereco, telefone) VALUES ('Carlos', 'Silva', '123456789', 1, '31988776655')";
                                cmd.CommandText = @"INSERT INTO TB_REGISTRO (FuncionarioId, Data, HorarioEntrada, HorarioInicioIntervalo, HorarioFimIntervalo, HorarioSaida) VALUES (1, '2024-06-15', '08:00', '11:00', '12:00', '17:00')";
                                //cmd.CommandText = @"DROP VIEW VW_REGISTRO_FORMATADO;";
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao inserir registro: " + ex.Message);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void CreateViews()
        {
            try
            {
                using (var connection = DBConection()) // Certifique-se de que DBConnection() está retornando uma conexão válida
                {
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"
                            CREATE VIEW VW_REGISTRO_FORMATADO AS
                            SELECT 
                                TR.*,
                                TF.nome AS nome_funcionario,
                                TF.sobrenome AS sobrenome_funcionario
                            FROM TB_REGISTRO TR
                            INNER JOIN TB_FUNCIONARIO TF ON TR.FuncionarioId = TF.id_funcionario;
                            
                            CREATE VIEW VW_ENDERECO_FORMATADO AS
                            SELECT 
                                TF.*,
                                TE.cidade,
                                TE.bairro,
                                TE.rua,
                                TE.numero,
                                TE.complemento
                            FROM TB_FUNCIONARIO TF
                            INNER JOIN TB_ENDERECO TE ON TF.endereco = TE.id_endereco;
                        ";
                        cmd.ExecuteNonQuery();
                    }

                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static DataTable getTeste()
        {
            SQLiteDataAdapter adapter = null;
            DataTable datatable = new DataTable();
            DBConection();
            try
            {
                using (var cmd = sqliteConection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM VW_REGISTRO_FORMATADO";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, sqliteConection);
                    adapter.Fill(datatable);
                    return datatable;
                }
            }
            catch (Exception e)
            {
              MessageBox.Show(e.Message);
               throw;
            }
        }
    }
}
