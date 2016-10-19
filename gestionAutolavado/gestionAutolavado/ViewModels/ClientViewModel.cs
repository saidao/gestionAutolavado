using GalaSoft.MvvmLight.Command;
using gestionAutolavado.Services;
using gestionAutolavado.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace gestionAutolavado.ViewModels
{
    public class ClientViewModel
    {
        #region atributos
        private NavigationService navigationService;
        #endregion


        #region Properties
        public ObservableCollection<ClientModel> Clients { get; set; }
        #endregion

        #region Constructor
        public ClientViewModel()
        {
            Clients = new ObservableCollection<ClientModel>();
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
                Clients.Add(new ClientModel
                {
                    IdClient=i,
                    CreationDate = DateTime.Now,
                    CreatedBy = "Admin",
                    ModificationDate = DateTime.Now,
                    ModifiedBy = "Admin",
                    Names = "Said",
                    LastName = "Aquino Ortega",
                    Email = "said.aquino@gmail.com",
                    CellPhone = "(044)55-3733-5379",
                    HomePhone = "(+01)55-5842-0061",
                    Address = "Alberto Dominguez",
                });
            }
        }

        #endregion
    }
}
