using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.Models
{
    public class PropertyModel
    {
        //Generic parameters
        [PrimaryKey, AutoIncrement]
        public int IdProperty { get; set; }
        [Indexed]
        public DateTime CreationDate { get; set; }
        [Indexed]
        public string CreatedBy { get; set; }
        [Indexed]
        public DateTime ModificationDate { get; set; }
        [Indexed]
        public string ModifiedBy { get; set; }

        //Specific parameters
        //Object: Vehiculo
        [Indexed, MaxLength(10)]
        public string Plate { get; set; }
        [Indexed, MaxLength(20)]
        public string Color { get; set; }
        [Indexed, MaxLength(20)]
        public TypeCar Type { get; set; }

        //Relationship parameters
        [ForeignKey(typeof(ClientModel))]
        public int IdClient { get; set; }
        [ManyToOne]
        public List<ClientModel> Clients { get; set; }
        [OneToMany]
        public List<OrderModel> Orders { get; set; }

        //Return parameters
        public override string ToString() { return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", this.IdProperty, this.CreationDate, this.CreatedBy, this.ModificationDate, this.ModifiedBy, this.IdClient, this.Plate, this.Color, this.Type); }
    }

    //Specific Class
    //Object: Tipo
    public enum TypeCar
    {
        Coche,
        CamionetaChica,
        CamionetaMediana,
        CamionetaGrande,
        ServicioPúblico
    }
}