using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
using gestionAutolavado.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace gestionAutolavado.ViewModels
{
    public class OrderViewModel
    {
        #region atributos
        private NavigationService navigationService;
        #endregion


        #region Properties
        public ObservableCollection<OrderModel> Orders { get; set; }
        #endregion

        #region Constructor
        public OrderViewModel()
        {
            Orders = new ObservableCollection<OrderModel>();
            navigationService = new NavigationService();

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
                Orders.Add(new OrderModel
                {
                    IdOrder = i,
                    CreationDate = DateTime.Now,
                    CreatedBy = "Admin",
                    ModificationDate = DateTime.Now,
                    ModifiedBy = "Admin",
                    Price = 50,
                    Comment = "Comentarios ...",
                });
            }
        }
        
        #endregion
    }
}
