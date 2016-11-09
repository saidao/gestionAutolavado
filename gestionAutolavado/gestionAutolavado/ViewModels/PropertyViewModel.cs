using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
using gestionAutolavado.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace gestionAutolavado.ViewModels
{
    public class PropertyViewModel
    {
        #region atributos
        private NavigationService navigationService;
        #endregion


        #region Properties
        public ObservableCollection<PropertyModel> Properties { get; set; }
        #endregion

        #region Constructor
        public PropertyViewModel()
        {
            Properties = new ObservableCollection<PropertyModel>();
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

        #region Métodos
        private void LoadFakeData()
        {
            for (int i = 0; i < 10; i++)
            {
                Properties.Add(new PropertyModel
                {
                    IdProperty = i,
                    CreationDate = DateTime.Now,
                    CreatedBy = "Admin",
                    ModificationDate = DateTime.Now,
                    ModifiedBy = "Admin",
                    Plate = "AAA-1234",
                    Color = "red",
                    Type = TypeCar.Coche
                });
            }
        }

        #endregion
    }
}