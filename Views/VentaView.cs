using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Controllers;

namespace Ventas.Views
{
    public partial class VentaView : Form
    {
        public VentaView()
        {
            InitializeComponent();
            VentaController ctrl = new VentaController(this);
        }

        private void VentaView_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresarVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ventasView = new Inicio();
            ventasView.Show();
        }
    }
}
