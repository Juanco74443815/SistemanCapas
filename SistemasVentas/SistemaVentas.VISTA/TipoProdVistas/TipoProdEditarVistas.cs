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

namespace SistemaVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdEditarVistas : Form
    {
        int idx = 0;
        TipoProd tipoPro = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        public TipoProdEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoPro.Nombre = txtNombre.Text;

            bss.EditarTipoProdBss(tipoPro);
            MessageBox.Show("Datos Actualizados");
        }

        private void TipoProdEditarVistas_Load(object sender, EventArgs e)
        {
            tipoPro = bss.ObtenerTipoProdIdBss(idx);
            txtNombre.Text = tipoPro.Nombre;
        }
    }
}
