﻿using SistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.ClienteVistas
{
    public partial class ClienteVistas : Form
    {
        public ClienteVistas()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }
    }
}
