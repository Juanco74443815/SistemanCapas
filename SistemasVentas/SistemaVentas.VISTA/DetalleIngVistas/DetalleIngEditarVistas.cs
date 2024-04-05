using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using SistemaVentas.VISTA.IngresoVistas;
using SistemaVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngEditarVistas : Form
    {
        int idx = 0;
        DetalleIng detalleIng = new DetalleIng();
        DetalleIngBss bss = new DetalleIngBss();
        public DetalleIngEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssin = new IngresoBss();
        private void DetalleIngEditarVistas_Load(object sender, EventArgs e)
        {
            detalleIng = bss.ObtenerDetalleIngIdBss(idx);
            txtIngreso.Text = detalleIng.IdIngreso.ToString();
            txtProducto.Text = detalleIng.IdProducto.ToString();
            dateTimePicker1.Value = detalleIng.FechaVenc;
            txtCantidad.Text = detalleIng.Cantidad.ToString();
            txtPrecioCosto.Text = detalleIng.PrecioCosto.ToString();
            txtPrecioVenta.Text = detalleIng.PrecioVenta.ToString();
            txtSubTotal.Text = detalleIng.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleIng.IdIngreso = IdIngresoSeleccionado;
            detalleIng.IdProducto = IdProductoSeleccionado;
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalleIng.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
            detalleIng.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            detalleIng.SubTotal = Convert.ToDecimal(txtSubTotal.Text);

            bss.EditarDetalleIngBss(detalleIng);

            MessageBox.Show("Datos Actualizados");
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            IngresoListarVistas fr = new IngresoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssin.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                txtIngreso.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                txtProducto.Text = producto.Nombre;
            }
        }
    }
}
