using gestionAutolavado.Pages;

namespace gestionAutolavado.Services
{
    public class NavigationService
    {
        public  void Navigate( string PageName)
        {
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "ConfiguracionPage":
                    App.Navigator.PushAsync(new ConfiguracionPage());
                    break;
                case "ServiciosPageServiciosPage":
                    App.Navigator.PushAsync(new ServiciosPage());
                    break;
                case "ClientesPage":
                    App.Navigator.PushAsync(new ClientesPage());
                    break;
                case "VehiculosPage":
                    App.Navigator.PushAsync(new VehiculosPage());
                    break;
                case "LavadoresPage":
                    App.Navigator.PushAsync(new LavadoresPage());
                    break;
                case "GastosIngresoPage":
                    App.Navigator.PushAsync(new GastosIngresoPage());
                    break;
                case "ReportesPage":
                    App.Navigator.PushAsync(new ReportesPage());
                    break;
                case "NuevoServicioPage":
                    App.Navigator.PushAsync(new NuevoServicioPage());
                    break;
                case "MainPage":
                    App.Navigator.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }

    }
}
