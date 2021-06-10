using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace conexionPGSSQL
{
    public partial class Form1 : Form
    {
        public NpgsqlConnection conexion = new NpgsqlConnection() {};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ConnectionString = "Username = postgres; Password = admin; Host = localhost; Port = 5432; Database = Turnos";
                conexion.Open();
                MessageBox.Show("Ya se conecto");
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            try {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Ya se desconecto");
                }
                else {
                    MessageBox.Show("no esta conectada wey! xd");
                }
            } catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }
    }
}
