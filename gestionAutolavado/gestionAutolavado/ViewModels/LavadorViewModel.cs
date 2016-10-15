using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.ViewModels
{
    public class LavadorViewModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdLavador { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Indexed, MaxLength(100)]
        public string Nombres { get; set; }
        [Indexed, MaxLength(100)]
        public string Apellidos { get; set; }
        [Indexed]
        public string NombreCompleto { get { return string.Format("{0} {1}", this.Nombres, this.Apellidos); } }
        [Indexed, MaxLength(250)]
        public string CorreoElectronico { get; set; }
        [MaxLength(50)]
        public string NumTelefonico { get; set; }
        [MaxLength(250)]
        public string Domicilio { get; set; }
        [OneToMany]
        public List<ServicioViewModel> Servicios { get; set; }
        public override string ToString() { return string.Format("{0} {1} {2} {3} {4} {5}", this.IdLavador, this.FechaRegistro, this.NombreCompleto, this.CorreoElectronico, this.NumTelefonico, this.Domicilio); }
    }
}
