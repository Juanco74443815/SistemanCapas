﻿using SistemaVentas.BSS;
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

namespace SistemaVentas.VISTA.RolVistas
{
    public partial class RolInsertarVistas : Form
    {
        public RolInsertarVistas()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Nombre = txtNombre.Text;

            bss.InsertarRolBss(rol);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
