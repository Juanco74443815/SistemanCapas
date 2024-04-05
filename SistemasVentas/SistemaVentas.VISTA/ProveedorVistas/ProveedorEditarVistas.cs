using SistemaVentas.BSS;
using SistemaVentas.Modelo;
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

namespace SistemaVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorEditarVistas : Form
    {
        int idx = 0;
        Proveedor proveedor = new Proveedor();
        ProveedorBss bss = new ProveedorBss();
        public ProveedorEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveedorEditarVistas_Load(object sender, EventArgs e)
        {
            proveedor = bss.ObtenerProveedorIdBss(idx);
            txtNombre.Text = proveedor.Nombre;
            txtTelefono.Text = proveedor.Telefono;
            txtDireccion.Text = proveedor.Direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proveedor.Nombre = txtNombre.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Direccion = txtDireccion.Text;

            bss.EditarProveedorBss(proveedor);

            MessageBox.Show("Datos Actualizados");
        }
    }
}
