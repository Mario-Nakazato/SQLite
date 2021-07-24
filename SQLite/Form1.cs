using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //File

// SQLite
using System.Data.SQLite;

namespace SQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            string bancoDados = Application.StartupPath + @"\SQLite.db";
            string conexao = @"Data Source = " + bancoDados + "; Version = 3";

            labelmsg.Text = ": ";

            if (!File.Exists(bancoDados))
            {
                SQLiteConnection.CreateFile(bancoDados);
                labelmsg.Text = labelmsg.Text +"Criando banco de dados SQLite, ";
            }

            SQLiteConnection conectar = new SQLiteConnection(conexao);

            try
            {
                conectar.Open();
                labelmsg.Text = labelmsg.Text + "Conectado SQLite";
            }
            catch (Exception ex)
            {
                labelmsg.Text = labelmsg.Text + "Erro ao conectar SQLite \n" + ex;
                //throw;
            }
            finally
            {
                conectar.Close();
            }
        }

        private void buttonTabela_Click(object sender, EventArgs e)
        {
            string bancoDados = Application.StartupPath + @"\SQLite.db";
            string conexao = @"Data Source = " + bancoDados + "; Version = 3";

            labelmsg.Text = ": ";

            SQLiteConnection conectar = new SQLiteConnection(conexao);

            try
            {
                conectar.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conectar;
                comando.CommandText = "CREATE TABLE pessoa (id INT NOT NULL PRIMARY KEY, nome VARCHAR(64), sobrenome VARCHAR(64))";
                comando.ExecuteNonQuery();
                labelmsg.Text = labelmsg.Text + "Tabela criada SQLite";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelmsg.Text = labelmsg.Text + "Erro ao criar tabela SQLite " + ex.Message;
            }
            finally
            {
                conectar.Close();
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            string bancoDados = Application.StartupPath + @"\SQLite.db";
            string conexao = @"Data Source = " + bancoDados + "; Version = 3";

            labelmsg.Text = ": ";

            SQLiteConnection conectar = new SQLiteConnection(conexao);

            try
            {
                conectar.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conectar;
                
                int id = new Random(DateTime.Now.Millisecond).Next(0,2048);//Temporario apenas para funcionar
                string nome = textBoxNome.Text;
                string sobrenome = textBoxSobrenome.Text;
                
                comando.CommandText = "INSERT INTO pessoa VALUES " +
                    "(" +id +", '" +nome +"', '" +sobrenome +"')";
                comando.ExecuteNonQuery();
                labelmsg.Text = labelmsg.Text + "Registro inserido SQLite";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelmsg.Text = labelmsg.Text + "Erro ao inserir registro SQLite " + ex.Message;
            }
            finally
            {
                conectar.Close();
            }
        }
    }
}
