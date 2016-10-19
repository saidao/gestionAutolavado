using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
using gestionAutolavado.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace gestionAutolavado.ViewModels
{
    public class ProductServiceViewModel
    {
        #region atributos
        private NavigationService navigationService;
        #endregion


        #region Properties
        public ObservableCollection<ProductServiceModel> ProductService { get; set; }
        #endregion

        #region Constructor
        public ProductServiceViewModel()
        {
            ProductService = new ObservableCollection<ProductServiceModel>();
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
                ProductService.Add(new ProductServiceModel
                {
                    IdProductService=i,
                    CreationDate = DateTime.Now,
                    CreatedBy = "Admin",
                    ModificationDate = DateTime.Now,
                    ModifiedBy = "Admin",
                    Price = 50,
                    Description = "Descripción...",
                });
            }
        }
        #endregion
    }
}
