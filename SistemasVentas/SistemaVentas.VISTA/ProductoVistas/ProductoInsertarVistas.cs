using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using SistemaVentas.VISTA.MarcaVistas;
using SistemaVentas.VISTA.TipoProdVistas;
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

namespace SistemaVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        public static int IdTipoProdSeleccionado = 0;
        TipoProdBss bsstp = new TipoProdBss();
        public static int IdMarcaSeleccionado = 0;
        MarcaBss bssm = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdTipoProd = IdTipoProdSeleccionado;
            producto.IdMarca = IdMarcaSeleccionado;
            producto.Nombre = txtNombre.Text;
            producto.CodigoBarra = txtCodigoBarra.Text;
            producto.Unidad = Convert.ToInt32(txtUnidad.Text);
            producto.Descripcion = txtDescripcion.Text;

            bss.InsertarProductoBss(producto);

            MessageBox.Show("Se guardo correctamente");
        }

        private void btnSelecTiProd_Click(object sender, EventArgs e)
        {
            TipoProdListarVistas fr = new TipoProdListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = bsstp.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                txtIdTipoProd.Text = tipoprod.Nombre;
            }
        }

        private void btnSelecMarca_Click(object sender, EventArgs e)
        {
            MarcaListarVistas fr = new MarcaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssm.ObtenerMarcaIdBss(IdMarcaSeleccionado);
                txtIdMarca.Text = marca.Nombre;
            }
        }
    }
}
