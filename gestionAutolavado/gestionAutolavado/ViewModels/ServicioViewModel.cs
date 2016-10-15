using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.ViewModels
{
    public class ServicioViewModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdServicio { get; set; }
        [Indexed]
        public DateTime FechaRegistro { get; set; }
        [ForeignKey(typeof(ClienteViewModel))]
        public int IdCliente { get; set; }
        [ForeignKey(typeof(VehiculoViewModel))]
        public int IdVehiculo { get; set; }
        [ForeignKey(typeof(ProductoViewModel))]
        public int IdProducto { get; set; }
        [ForeignKey(typeof(LavadorViewModel))]
        public int IdLavador { get; set; }

        [Indexed]
        public decimal Precio { get; set; }
        [Indexed, MaxLength(250)]
        public string Comentarios { get; set; }

        [ManyToOne]
        public List<ClienteViewModel> Cliente { get; set; }
        [ManyToOne]
        public List<VehiculoViewModel> Vehiculo { get; set; }
        [ManyToOne]
        public List<ProductoViewModel> Producto { get; set; }
        [ManyToOne]
        public List<LavadorViewModel> Lavador { get; set; }

        //public override string ToString() { return string.Format("{0} {1} {2} {3}", this.IdServicio, this.FechaRegistro, this.Precio, this.Comentarios); }
    }
}