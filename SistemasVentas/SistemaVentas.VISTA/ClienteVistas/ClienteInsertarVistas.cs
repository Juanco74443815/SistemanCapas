using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using SistemaVentas.VISTA.PersonaVistas;
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

namespace SistemaVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVistas : Form
    {
        public ClienteInsertarVistas()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdPersona = Convert.ToInt32(txtIdPersona.Text);
            cliente.TipoCliente = txtTipoCliente.Text;
            cliente.CodigoClie = txtCodigoCliente.Text;

            bss.InsertarClienteBss(cliente);

            MessageBox.Show("Se guardo correctamente");
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerIdBss(IdPersonaSeleccionada);
                txtIdPersona.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
