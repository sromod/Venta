using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Models.Dao;
using Ventas.Views;

namespace Ventas.Controllers
{
    class ComisionController
    {
        ComisionView vista;
        public ComisionController(ComisionView view)
        {
            vista = view;
            vista.Load += new EventHandler(CargarMes);
            vista.btnConsultarComision.Click += new EventHandler(ListaComisionesVendedor);

        }
        private void ListaComisionesVendedor(object sender, EventArgs e)
        {
            ComisionDao db = new ComisionDao();
            string anio = vista.cmbAnio.SelectedItem.ToString();
            string mes = vista.cmbMes.SelectedValue.ToString();

            vista.dgvComision.DataSource =
                db.ListarComisionesVendedor(anio, mes);
        }

        private void CargarMes(object sender, EventArgs e)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(01, "Enero");
            myDictionary.Add(02, "Febrero");
            myDictionary.Add(03, "Marzo");
            myDictionary.Add(04, "Abril");
            myDictionary.Add(05, "Mayo");
            myDictionary.Add(06, "Junio");
            myDictionary.Add(07, "Julio");
            myDictionary.Add(08, "Agosto");
            myDictionary.Add(09, "Septiembre");
            myDictionary.Add(10, "Octubre");
            myDictionary.Add(11, "Noviembre");
            myDictionary.Add(12, "Diciembre");

            vista.cmbMes.DataSource = new BindingSource(myDictionary, null);

            vista.cmbMes.DisplayMember = "Value";
            vista.cmbMes.ValueMember = "Key";
        }
    }
}
