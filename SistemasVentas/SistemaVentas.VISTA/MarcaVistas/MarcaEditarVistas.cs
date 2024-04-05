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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.MarcaVistas
{
    public partial class MarcaEditarVistas : Form
    {
        int idx = 0;
        Marca marca = new Marca();
        MarcaBss bss = new MarcaBss();
        public MarcaEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void MarcaEditarVistas_Load(object sender, EventArgs e)
        {
            marca = bss.ObtenerMarcaIdBss(idx);
            txtNombre.Text = marca.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marca.Nombre = txtNombre.Text;

            bss.EditarMarcaBss(marca);

            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
