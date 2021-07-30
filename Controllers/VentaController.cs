using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Models.Dao;
using Ventas.Models.Dto;
using Ventas.Views;


namespace Ventas.Controllers
{
    class VentaController
    {
        VentaView vista;
        public VentaController(VentaView view)
        {
            vista = view;
            //vista.Load += new EventHandler(ListaVentasAcumuladas);
            vista.btnConsultarVA.Click += new EventHandler(ListaVentasAcumuladas);

        }
        private void ListaVentasAcumuladas(object sender, EventArgs e)
        {
            VentaDao db = new VentaDao();
            string fechaInicial = vista.dtpFechaInicialVA.Value.ToString("yyyy-MM-dd");
            string fechaFinal= vista.dtpFechaFinalVA.Value.ToString("yyyy-MM-dd");

            vista.dgvVentasAcumuladas.DataSource =
                db.ListarVentasAcumuladas(fechaInicial, fechaFinal);
        }

    }
}
