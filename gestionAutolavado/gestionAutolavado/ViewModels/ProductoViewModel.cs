using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.ViewModels
{
    public class ProductoViewModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Unique, Indexed, MaxLength(250)]
        public string Nombre { get; set; }
        [Indexed, MaxLength(1000)]
        public string Descripcion { get; set; }
        [Indexed, MaxLength(250)]
        public int Precio { get; set; }
        [Indexed]
        public bool Favorito { get; set; }
        [OneToMany]
        public List<ServicioViewModel> Servicios { get; set; }
        public override string ToString() { return string.Format("{0} {1} {2} {3}", this.IdProducto, this.FechaRegistro, this.Nombre, this.Descripcion); }

    }
}
