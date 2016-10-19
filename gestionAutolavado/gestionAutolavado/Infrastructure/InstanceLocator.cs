using gestionAutolavado.ViewModels;

namespace gestionAutolavado.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public ClientViewModel Client { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public ProductServiceViewModel ProductService { get; set; }
        public PropertyViewModel Property { get; set; }
        public OrderViewModel Orders { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
            Client = new ClientViewModel();
            Employee = new EmployeeViewModel();
            ProductService = new ProductServiceViewModel();
            Property = new PropertyViewModel();
            Orders = new OrderViewModel();
        }
    }
}
