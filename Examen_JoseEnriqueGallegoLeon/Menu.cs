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
    public partial class formMenu : Form
    {
        public MySqlCommand Comando { get; private set; }
        public MySqlDataReader Lector { get; private set; }

        public MySqlConnection connection;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public void VerTabla()
        {
            /*string Consulta = "SELECT * FROM presupuestos"; // Declaración de la consulta

            using (MySqlConnection conn = new MySqlConnection($"server={Login.HOST};user id={Login.ID};password={Login.PASSWORD};database=clientes;persistsecurityinfo=True"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    //DataGridView.DataSource = ds.Tables[0];
                }
            }*/
        }

        public void InsertarDatos()
        {
            /*Formulario formulario = new Formulario();
            formulario.ShowDialog();

            string COD_PRESUPUESTO = form3.txtCodFact.Text;
            string COD_ARTICULO = form3.txtCodArt.Text;
            string DESCRIPCION = form3.txtDescripcion.Text;
            string CANTIDAD = form3.txtCantidad.Text;
            string PRECIO = form3.txtPrecio.Text;
            string DATE = form3.txtFecha.Text;

            if (formulario.DialogResult == DialogResult.OK)
            {
                string Consulta = $"INSERT INTO lineas (COD_PRESUPUESTO, COD_ARTICULO, DESCRIPCION, CANTIDAD, PRECIO) VALUES ('{COD_PRESUPUESTO}', '{COD_ARTICULO}', '{DESCRIPCION}', '{CANTIDAD}', '{PRECIO}')"; // Declaración de la consulta
                string Consulta2 = $"INSERT INTO presupuestos (COD, FECHA, TOTAL) VALUES ((SELECT COD_PRESUPUESTO FROM lineas WHERE COD_PRESUPUESTO = '{COD_PRESUPUESTO}'), ('{DATE}'), (SELECT (CANTIDAD * PRECIO) AS TOTAL FROM lineas WHERE COD_PRESUPUESTO = '{COD_PRESUPUESTO}'))"; // Declaración de la consulta

                connection = new MySqlConnection($"server={Login.HOST};user id={Login.ID};password={Login.PASSWORD};database=clientes;persistsecurityinfo=True");
                connection.Open();
                MySqlCommand comando = new MySqlCommand(Consulta, connection);
                MySqlCommand comando2 = new MySqlCommand(Consulta2, connection);

                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();

                connection.Close();
                VerTabla();
            }*/
        }

        public void BorrarDatos()
        {
            /*
            if (DataGridView.SelectedRows.Count > 0)
            {
                string Consulta = "DELETE FROM presupuestos WHERE COD = '" + label1.Text + "'"; // Declaración de la consulta
                string ConsultaNotas = "DELETE FROM lineas WHERE COD_PRESUPUESTO = '" + label1.Text + "'"; // Declaración de la consulta


                connection = new MySqlConnection($"server={Login.HOST};user id={Login.ID};password={Login.PASSWORD};database=clientes;persistsecurityinfo=True");
                connection.Open();

                MySqlCommand comando = new MySqlCommand(Consulta, connection);
                MySqlCommand comandoNotas = new MySqlCommand(ConsultaNotas, connection);

                DialogResult comprobar = MessageBox.Show("¿Quieres borrar el presupuesto y sus datos?", "Borrar", MessageBoxButtons.YesNo);
                if (comprobar == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    comandoNotas.ExecuteNonQuery();

                    connection.Close();
                    VerTabla();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila completa");
            }*/
        }

        public void ModificarDatos()
        {
            /*if (DataGridView.SelectedRows.Count > 0)
            {
                int row = DataGridView.SelectedRows[0].Index;

                string id = DataGridView.Rows[row].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                string id_student = DataGridView.Rows[row].Cells["dataGridViewTextBoxColumn9"].Value.ToString();
                string description = DataGridView.Rows[row].Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                string note = DataGridView.Rows[row].Cells["dataGridViewTextBoxColumn8"].Value.ToString();

                Form form = new Form();

                form.txtID.Text = id;
                form.txtUser.Text = id_student;
                form.txtSurname.Text = description;
                form.txtQuarter.Text = note;
                form.lbName.Text = "ID Student";
                form.lbPhone.Text = "Description";
                form.lbDirection.Text = "Note";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string ID = form.txtID.Text;
                    string ID_STUDENT = form.txtUser.Text;
                    string DESCRIPTION = form.txtSurname.Text;
                    string NOTE = form.txtQuarter.Text;

                    string Consulta = $"UPDATE notas SET ID = '{ID}', DESCRIPTION = '{DESCRIPTION}', NOTE = '{NOTE}', ID_STUDENT = '{ID_STUDENT}' WHERE ID = '{ID}'"; // Declaración de la consulta

                    label2.Text = Consulta;

                    connection = new MySqlConnection(CadenaConexion);
                    connection.Open();
                    MySqlCommand comando = new MySqlCommand(Consulta, connection);
                    comando.ExecuteNonQuery();

                    CalcularMediaAlumno();
                    CalcularMediaClase();
                    LeerNotas();
                    connection.Close();
                }
            }*/
        }

        public void HacerUnaMedia()
        {
            /*string Consulta = $"UPDATE instituto SET AVERAGE = (SELECT AVG(NOTE) FROM notas WHERE ID_STUDENT = instituto.ID)"; // Declaración de la consulta

            label2.Text = Consulta;

            connection = new MySqlConnection(CadenaConexion);
            connection.Open();
            MySqlCommand comando = new MySqlCommand(Consulta, connection);
            comando.ExecuteNonQuery();

            LeerDeBaseDeDatos();
            LeerNotas();
            connection.Close();*/
        }

        public formMenu()
        {
            InitializeComponent();
            panelNavegacionMenu.MouseDown += PanelNavegacion_MouseDown;
            panelNavegacionMenu.MouseUp += PanelNavegacion_MouseUp;
            panelNavegacionMenu.MouseMove += PanelNavegacion_MouseMove;
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

        private void oP1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario formulario = new Formulario();
            formulario.Show();
        }
    }
}
