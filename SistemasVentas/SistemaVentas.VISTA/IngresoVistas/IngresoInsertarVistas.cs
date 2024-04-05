using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using SistemaVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVistas : Form
    {
        public IngresoInsertarVistas()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bsspv = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = Convert.ToDecimal(txtTotal.Text);

            bss.InsertarIngresoBss(ingreso);

            MessageBox.Show("Se guardo correctamente");
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            ProveedorListarVistas fr = new ProveedorListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bsspv.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                txtIdProveedor.Text = proveedor.Nombre;
            }
        }
    }
}
