using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class VentanaHijaVM:ObservableObject
    {
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public VentanaHijaVM()
        {
            Mensaje = "Soy la ventana hija";
        }
    }
}
