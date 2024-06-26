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
    public class ProveeBss
    {
        ProveeDal dal = new ProveeDal();
        public DataTable ListarProveeBss()
        {
            return dal.ListarProveeDal();
        }
        public void InsertarProveeBss(Provee provee)
        {
            dal.InsertarProveeDal(provee);
        }
        public Provee ObtenerProveeIdBss(int id)
        {
            return dal.ObtenerProveeIdDal(id);
        }
        public void EditarProveeBss(Provee provee)
        {
            dal.EditarProveeDal(provee);
        }
        public void EliminarProveeBss(int id)
        {
            dal.EliminarProveeDal(id);
        }
    }
}
