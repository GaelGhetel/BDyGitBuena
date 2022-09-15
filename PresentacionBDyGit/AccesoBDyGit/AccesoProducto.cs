using System;
using System.Collections.Generic;
using System.Data;
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
        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertProducto({0}, '{1}', '{2}', '{3}'",
                Entidad.IdProducto, Entidad.Nombre, Entidad.Descripcion, Entidad.Precio));
        }
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showProducto('%{0}%')", filtro), "producto");
        }
    }
}
