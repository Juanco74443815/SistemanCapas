﻿using SistemasVentas.Dal;
using SistemaVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol usuarioRol)
        {
            dal.InsertarUsuarioRolDal(usuarioRol);
        }
        public UsuarioRol ObtenerUsuarioRolIdBss(int id)
        {
            return dal.ObtenerUsuarioRolIdDal(id);
        }
        public void EditarUsuarioRolBss(UsuarioRol usuarioRol)
        {
            dal.EditarUsuarioRolDal(usuarioRol);
        }
        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }
    }
}
