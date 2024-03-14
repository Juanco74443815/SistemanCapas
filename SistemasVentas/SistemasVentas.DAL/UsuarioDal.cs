using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Dal
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from Usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
