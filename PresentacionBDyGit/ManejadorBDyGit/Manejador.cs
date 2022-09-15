using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesrBDyGit;
using AccesoBDyGit;
using Crud;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorBDyGit
{
    
    public class Manejador
    {
        AccesoProducto ap = new AccesoProducto();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(String.Format(String.Format("Estas seguro de borrar: {0}", Entidad.Nombre)),
                "!Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }
        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Producto Guardado", "!Atencion", MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["Producto"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
            

        }
    }
}
