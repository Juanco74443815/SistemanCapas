﻿using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using SistemaVentas.VISTA.RolVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVistas : Form
    {
        public UsuarioRolInsertarVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssu = new UsuarioBss();
        public static int IdRolSeleccionado = 0;
        RolBss bssr = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            usuarioRol.IdRol = Convert.ToInt32(txtIdRol.Text);
            usuarioRol.FechaAsigna = dateTimePicker1.Value;

            bss.InsertarUsuarioRolBss(usuarioRol);

            MessageBox.Show("Se guardó correctamente a UsuarioRol");
        }

        private void btnSelecTiProd_Click(object sender, EventArgs e)
        {
            UsuarioListarVistas fr = new UsuarioListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssu.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                txtIdUsuario.Text = usuario.NombreUser;
            }
        }

        private void btnSelecMarca_Click(object sender, EventArgs e)
        {
            RolListarVistas fr = new RolListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssr.ObtenerIdBss(IdRolSeleccionado);
                txtIdRol.Text = rol.Nombre;
            }
        }
    }
}
