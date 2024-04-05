using SistemaVentas.VISTA.ClienteVistas;
using SistemaVentas.VISTA.DetalleIngVistas;
using SistemaVentas.VISTA.DetalleVentaVistas;
using SistemaVentas.VISTA.IngresoVistas;
using SistemaVentas.VISTA.PersonaVistas;
using SistemaVentas.VISTA.ProductoVistas;
using SistemaVentas.VISTA.ProveeVistas;
using SistemaVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PantallaVistas
{
    public partial class CajeroVistas : Form
    {
        public CajeroVistas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista person = new PersonaListarVista();
            person.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteListarVistas cliente = new ClienteListarVistas();
            cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresoListarVistas ingreso = new IngresoListarVistas();
            ingreso.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentaListarVistas venta = new VentaListarVistas();
            venta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductoListarVistas producto = new ProductoListarVistas();
            producto.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProveeListarVistas provee = new ProveeListarVistas();
            provee.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetalleVentaListarVistas detalleVenta = new DetalleVentaListarVistas();
            detalleVenta.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetalleIngListarVistas detalleIng = new DetalleIngListarVistas();
            detalleIng.Show();
        }
    }
}
