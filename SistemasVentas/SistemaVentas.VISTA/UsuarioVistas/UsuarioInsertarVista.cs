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

namespace SistemaVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        UsuarioBss bssu = new UsuarioBss();
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = new Usuario();
                usuario.IdPersona = IdPersonaSeleccionada;
                usuario.NombreUser = textBox1.Text;
                usuario.Contraseña = textBox2.Text;
                usuario.FechaReg = dateTimePicker1.Value;

                bssu.InsertarUsuarioBss(usuario);

                MessageBox.Show("Usuario Registrado");
            }
        }
        UsuarioBss bssuser = new UsuarioBss();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
