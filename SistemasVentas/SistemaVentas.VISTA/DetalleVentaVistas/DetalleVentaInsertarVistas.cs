﻿using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using SistemaVentas.VISTA.ProductoVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVistas : Form
    {
        public DetalleVentaInsertarVistas()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        public static int IdVentaSeleccionado = 0;
        VentaBss bssv = new VentaBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.IdVenta = Convert.ToInt32(txtIdVenta.Text);
            detalleVenta.IdProducto = Convert.ToInt32(txtIdProducto.Text);
            detalleVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalleVenta.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            detalleVenta.Subtotal = Convert.ToDecimal(txtSubTotal.Text);

            bss.InsertarDetalleVentaBss(detalleVenta);

            MessageBox.Show("Se guardo correctamente");
        }

        private void DetalleVentaInsertarVistas_Load(object sender, EventArgs e)
        {
        }

        private void btnSelecVenta_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssv.ObtenerVentaIdBss(IdVentaSeleccionado);
                txtIdVenta.Text = venta.IdVenta.ToString();
            }
        }

        private void btnSelecProducto_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                txtIdProducto.Text = producto.Nombre;
            }
        }
    }
}
