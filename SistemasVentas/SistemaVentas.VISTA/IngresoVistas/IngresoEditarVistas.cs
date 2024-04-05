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
    public partial class IngresoEditarVistas : Form
    {
        int idx = 0;
        Ingreso ingreso = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bsspv = new ProveedorBss();
        private void IngresoEditarVistas_Load(object sender, EventArgs e)
        {
            ingreso = bss.ObtenerIngresoIdBss(idx);
            txtIdProveedor.Text = ingreso.IdProveedor.ToString();
            dateTimePicker1.Value = ingreso.FechaIngreso;
            txtTotal.Text = ingreso.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso.IdProveedor = IdProveedorSeleccionado;
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = Convert.ToDecimal(txtTotal.Text);

            bss.EditarIngresoBss(ingreso);

            MessageBox.Show("Datos Actualizados");
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
