using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.Views
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnVentasAcumuladas_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentaView ventasView = new VentaView();
            ventasView.Show();
        }

        private void btnComisionesVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComisionView comisionView = new ComisionView();
            comisionView.Show();
        }
    }
}
