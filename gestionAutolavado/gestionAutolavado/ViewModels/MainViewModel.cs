using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
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
        //public ObservableCollection<SaleModel> Sales { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            //Sales = new ObservableCollection<SaleModel>();

            navigationService = new NavigationService();

            LoadMenu();
            //LoadFakeData();
        }
        #endregion

        #region comandos
        public ICommand StartCommand { get { return new RelayCommand(Start); } }

        private void Start()
        {
            navigationService.SetMainPage();
        }
        
        //public ICommand GoToCommand { get { return new RelayCommand<string>(GoTo); } }

        //private void GoTo(string pageName)
        //{
        //    navigationService.Navigate(pageName);
        //}
        #endregion

        #region Metodos
        //private void LoadFakeData()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Sales.Add(new SaleModel
        //        {
        //            IdSale = i,
        //            CreationDate = DateTime.Now,
        //            CreatedBy = "Admin",
        //            ModificationDate = DateTime.Now,
        //            ModifiedBy = "Admin",
        //            Price = 50,
        //            Comment = "Comentarios ...",
        //        });
        //    }
        //}

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Actividad.png",
                PageName = "MasterPage",
                Title = "Actividad",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Cliente.png",
                PageName = "ListOfClientsPage",
                Title = "Clientes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Vehiculo.png",
                PageName = "ListOfPropertiesPage",
                Title = "Vehiculos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Venta.png",
                PageName = "ListOfOrdersPage",
                Title = "Ventas",
            });


            Menu.Add(new MenuItemViewModel
            {
                Icon = "Empleado.png",
                PageName = "ListOfEmployeesPage",
                Title = "Empleados",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "GastosIngresos.png",
                PageName = "GenericIncomeExpenses",
                Title = "Gastos / Ingresos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Estadisticas.png",
                PageName = "GenericReportsPage",
                Title = "Estadisticas",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Info.png",
                PageName = "GenericReportsPage",
                Title = "Acerca de",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "configuracion.png",
                PageName = "GenericConfigurationPage",
                Title = "Ajustes",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "Salir.png",
                PageName = "GenericConfigurationPage",
                Title = "Salir",
            });
        }
        #endregion
    }
}
