﻿using SistemasVentas.Dal;
using SistemasVentas.DAL;
using SistemaVentas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolDal();
        }
        public void InsertarRolBss(Rol rol)
        {
            dal.InsertarRolDal(rol);
        }
        public Rol ObtenerIdBss(int id)
        {
            return dal.ObtenerRolId(id);
        }
        public void EditarRolBss(Rol rol)
        {
            dal.EditarRolDal(rol);
        }
        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }
    }
}
