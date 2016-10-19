using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.Models
{
    public class ProductServiceModel
    {
        //Generic parameters
        [PrimaryKey, AutoIncrement]
        public int IdProductService { get; set; }
        [Indexed]
        public DateTime CreationDate { get; set; }
        [Indexed]
        public string CreatedBy { get; set; }
        [Indexed]
        public DateTime ModificationDate { get; set; }
        [Indexed]
        public string ModifiedBy { get; set; }

        //Specific parameters
        //Object: Productos o Servicio
        [Indexed, MaxLength(100)]
        public string Name { get; set; }
        [Indexed, MaxLength(1000)]
        public string Description { get; set; }
        [Indexed, MaxLength(250)]
        public double Price { get; set; }
        [Indexed]
        public bool Favorite { get; set; }

        //Relationship parameters
        [OneToMany]
        public List<OrderModel> Orders { get; set; }

        //Return parameters
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", this.IdProductService, this.CreationDate, this.CreatedBy, this.ModificationDate, this.ModifiedBy, this.Name, this.Description, this.Price, this.Favorite);
        }

    }
}
