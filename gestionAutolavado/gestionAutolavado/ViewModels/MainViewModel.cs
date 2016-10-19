using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
using gestionAutolavado.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace gestionAutolavado.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
        }
        #endregion

        #region Metodos
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
                Icon = "icono.png",
                PageName = "MasterPage",
                Title = "Inicio",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "servicios.png",
                PageName = "ListOfSalesPage",
                Title = "Ventas",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "clientes.png",
                PageName = "ListOfClientsPage",
                Title = "Clientes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "vehiculos.png",
                PageName = "ListOfPropertiesPage",
                Title = "Vehiculos",
            });


            Menu.Add(new MenuItemViewModel
            {
                Icon = "lavadores.png",
                PageName = "ListOfEmployeesPage",
                Title = "Personal",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "gastoingreso.png",
                PageName = "GenericIncomeExpenses",
                Title = "Gastos / Ingresos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "reportes.png",
                PageName = "GenericReportsPage",
                Title = "Reportes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "configuracion.png",
                PageName = "GenericConfigurationPage",
                Title = "Configuración",
            });
        }
        #endregion
    }
}
