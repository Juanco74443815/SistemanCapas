﻿using SistemaVentas.VISTA.ClienteVistas;
using SistemaVentas.VISTA.IngresoVistas;
using SistemaVentas.VISTA.MarcaVistas;
using SistemaVentas.VISTA.ProductoVistas;
using SistemaVentas.VISTA.ProveedorVistas;
using SistemaVentas.VISTA.TipoProdVistas;
using SistemaVentas.VISTA.UsuarioRolVistas;
using SistemaVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PantallaVistas
{
    public partial class GerenteVistas : Form
    {
        public GerenteVistas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioListarVistas user = new UsuarioListarVistas();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioRolListarVistas userRol = new UsuarioRolListarVistas();
            userRol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaListarVistas marca = new MarcaListarVistas();
            marca.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TipoProdListarVistas tipoProd = new TipoProdListarVistas();
            tipoProd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteListarVistas cliente = new ClienteListarVistas();
            cliente.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProveedorListarVistas proveedor = new ProveedorListarVistas();
            proveedor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IngresoListarVistas ingreso = new IngresoListarVistas();
            ingreso.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductoListarVistas producto = new ProductoListarVistas();
            producto.Show();
        }
    }
}
