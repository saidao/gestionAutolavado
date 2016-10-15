using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.ViewModels
{
    public class VehiculoViewModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdVehiculo { get; set; }
        public DateTime FechaRegistro { get; set; }
        [ForeignKey(typeof(ClienteViewModel))]     // Specify the foreign key
        public int IdCliente { get; set; }
        [Indexed, MaxLength(10)]
        public string Placa { get; set; }
        [Indexed, MaxLength(20)]
        public string Color { get; set; }
        [Indexed, MaxLength(20)]
        public string Tipo { get; set; }
        [ManyToOne]
        public List<ClienteViewModel> Cliente { get; set; }
        [OneToMany]
        public List<ServicioViewModel> Servicios { get; set; }

        public override string ToString() { return string.Format("{0} {1} {2} {3} {4}", this.Cliente, this.Placa, this.Color, this.Tipo); }
    }
}
