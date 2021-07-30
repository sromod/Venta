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
    public partial class ComisionView : Form
    {
        public ComisionView()
        {
            InitializeComponent();
            ComisionController ctrl = new ComisionController(this);
        }

        private void ComisionView_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresarComision_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ventasView = new Inicio();
            ventasView.Show();
        }
    }
}
