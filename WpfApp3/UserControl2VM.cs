using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class UserControl2VM : ObservableRecipient
    {
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }
        public UserControl2VM()
        {
            Mensaje = WeakReferenceMessenger.Default.Send<TextoInicialRequestMessage>();

        }
    }
}
