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

            return dal.LIstarRolDal();
        }
        public void InsertarRolbss(Rol rol)
        {
            dal.InsertarRolDal(rol);
        }
    }
}
