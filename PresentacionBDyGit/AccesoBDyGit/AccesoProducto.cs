using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoBDyGit
{
    public class AccesoProducto
    {
        Base b = new Base("Localhost", "root","", "ajedrez",3306);
        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deleteProducto({0)", Entidad.IdProducto));
        }
    }
}
