using System;
using gestionAutolavado.Pages;

namespace gestionAutolavado.Services
{
    public class NavigationService
    {
        public async void Navigate(string PageName)
        {
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "GenericConfigurationPage":
                    await App.Navigator.PushAsync(new GenericConfigurationPage());
                    break;
                case "GenericIncomeExpenses":
                    await App.Navigator.PushAsync(new GenericIncomeExpenses());
                    break;
                case "GenericReportsPage":
                    await App.Navigator.PushAsync(new GenericReportsPage());
                    break;
                case "ListOfClientsPage":
                    await App.Navigator.PushAsync(new ListOfClientsPage());
                    break;
                case "ListOfEmployeesPage":
                    await App.Navigator.PushAsync(new ListOfEmployeesPage());
                    break;
                case "ListOfOrdersPage":
                    await App.Navigator.PushAsync(new ListOfOrdersPage());
                    break;
                case "ListOfProductsServicesPage":
                    await App.Navigator.PushAsync(new ListOfProductsServicesPage());
                    break;
                case "ListOfPropertiesPage":
                    await App.Navigator.PushAsync(new ListOfPropertiesPage());
                    break;
                case "NewClientPage":
                    await App.Navigator.PushAsync(new NewClientPage());
                    break;
                case "NewEmployeePage":
                    await App.Navigator.PushAsync(new NewEmployeePage());
                    break;
                case "NewOrderPage":
                    await App.Navigator.PushAsync(new NewOrderPage());
                    break;
                case "NewProductServicePage":
                    await App.Navigator.PushAsync(new NewPropertyPage());
                    break;
                case "NewPropertyPage":
                    await App.Navigator.PushAsync(new NewPropertyPage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }

        internal void SetMainPage()
        {
            App.Current.MainPage = new MasterPage();
        }
    }
}
