using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class ServicioNavegacion
    {
        public bool? AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            return nueva.ShowDialog();
        }
    }
}
