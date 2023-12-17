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
    public partial class Formulario : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Formulario()
        {
            InitializeComponent();
            panelNavegacionFormulario.MouseDown += PanelNavegacion_MouseDown;
            panelNavegacionFormulario.MouseUp += PanelNavegacion_MouseUp;
            panelNavegacionFormulario.MouseMove += PanelNavegacion_MouseMove;
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
    }
}
