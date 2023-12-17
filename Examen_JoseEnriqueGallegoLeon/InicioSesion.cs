using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_JoseEnriqueGallegoLeon
{
    public partial class formInicioSesion : Form
    {
        public static string HOST = "localhost";
        public static string BASEDATOS = "";
        public static string USUARIO = "";
        public static string CONTRASENA = "";


        public MySqlCommand Comando { get; private set; }
        public MySqlDataReader Lector { get; private set; }

        public MySqlConnection connection;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public formInicioSesion()
        {
            InitializeComponent();
            panelNavegacion.MouseDown += PanelNavegacion_MouseDown;
            panelNavegacion.MouseUp += PanelNavegacion_MouseUp;
            panelNavegacion.MouseMove += PanelNavegacion_MouseMove;

            txtHost.Text = HOST;
            txtBaseDatos.Text = BASEDATOS;
            txtUsuario.Text = USUARIO;
            txtContrasena.Text = CONTRASENA;
        }
        private void PanelNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void PanelNavegacion_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PanelNavegacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
                Location = p3;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            HOST = txtHost.Text;
            BASEDATOS = txtBaseDatos.Text;
            USUARIO = txtUsuario.Text;
            CONTRASENA = txtContrasena.Text;

            string CadenaConexion = $"server={HOST};user id={USUARIO};password={CONTRASENA};database={BASEDATOS};persistsecurityinfo=True";

            try
            {
                formMenu menu = new formMenu();

                string Consulta = "SELECT * FROM presupuestos"; // Declaración de la consulta

                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        //menu.DataGridView.DataSource = ds.Tables[0];
                    }
                }

                menu.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show(CadenaConexion);
            }
        }
    }
}
