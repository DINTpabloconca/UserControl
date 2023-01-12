using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp3
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand AbrirCommand { get; }
        public RelayCommand UC1Command { get; }
        public RelayCommand UC2Command { get; }

        private UserControl contenidoVentana;

        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }

        private ServicioNavegacion servicioNavegacion;
        public MainWindowVM()
        {

            servicioNavegacion = new ServicioNavegacion();
            AbrirCommand = new RelayCommand(AbrirVentanaHija);
            UC1Command = new RelayCommand(CargarUC1);
            UC2Command = new RelayCommand(CargarUC2);

        }
        public void AbrirVentanaHija()
        {
            servicioNavegacion.AbrirVentanaHija();
        }
        public void CargarUC1()
        {
            ContenidoVentana = new UserControl1();
        }
        public void CargarUC2()
        {
            ContenidoVentana = new UserControl2();
        }
    }
}
