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
        public UserControl1 ObtenerUC1()
        {
            return new UserControl1();
        }
        public UserControl2 ObtenerUC2()
        {
            return new UserControl2();
        }
    }
}
