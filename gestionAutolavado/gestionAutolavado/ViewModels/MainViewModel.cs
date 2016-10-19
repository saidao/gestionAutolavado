using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace gestionAutolavado.ViewModels
{
    public class MainViewModel
    {
        #region atributos
        private NavigationService navigationService;
        #endregion


        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<ServicioViewModel> Servicios { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Servicios = new ObservableCollection<ServicioViewModel>();

            navigationService = new NavigationService();

            LoadMenu();
            LoadFakeData();
        }
        #endregion

        #region comandos
        public ICommand GoToCommand { get { return new RelayCommand<string>(GoTo); } }
        
        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }
        #endregion

        #region Metodos
        private void LoadFakeData()
        {
            for (int i = 0; i < 10; i++)
            {
                Servicios.Add(new ServicioViewModel
                {
                    IdServicio = i,
                    IdCliente = 1,
                    IdLavador = 1,
                    IdVehiculo = 1,
                    IdProducto = 1,
                    FechaRegistro = DateTime.Now,
                    Precio = 50,
                    Comentarios = "Vinil",
                });
            }
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel
            {
            });

            Menu.Add(new MenuItemViewModel
            {
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "servicios.png",
                PageName = "MasterPage",
                Title = "Inicio",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "servicios.png",
                PageName = "ServiciosPage",
                Title = "Servicios",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "clientes.png",
                PageName = "ClientesPage",
                Title = "Clientes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "vehiculos.png",
                PageName = "VehiculosPage",
                Title = "Vehiculos",
            });


            Menu.Add(new MenuItemViewModel
            {
                Icon = "lavadores.png",
                PageName = "LavadoresPage",
                Title = "Personal",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "gastoingreso.png",
                PageName = "GastosIngresoPage",
                Title = "Gastos / Ingresos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "reportes.png",
                PageName = "ReportesPage",
                Title = "Reportes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "configuracion.png",
                PageName = "ConfiguracionPage",
                Title = "Configuración",
            });
        }
        #endregion
    }
}
