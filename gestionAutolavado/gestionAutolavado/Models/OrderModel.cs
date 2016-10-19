using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.Models
{
    public class OrderModel
    {
        //Generic parameters
        [PrimaryKey, AutoIncrement]
        public int IdOrder { get; set; }
        [Indexed]
        public DateTime CreationDate { get; set; }
        [Indexed]
        public string CreatedBy { get; set; }
        [Indexed]
        public DateTime ModificationDate { get; set; }
        [Indexed]
        public string ModifiedBy { get; set; }

        //Specific parameters
        //Object: Ventas
        [Indexed]
        public decimal Price { get; set; }
        [Indexed, MaxLength(2500)]
        public string Comment { get; set; }
        [Indexed]
        public DateTime Start { get; set; }
        [Indexed]
        public DateTime End { get; set; }
        [Indexed]
        public DateTime Time { get; set; }

        //Relationship parameters
        [ForeignKey(typeof(ClientModel))]
        public int IdClient { get; set; }
        [ManyToOne]
        public List<ClientModel> Client { get; set; }
        [ForeignKey(typeof(PropertyModel))]
        public int IdProperty { get; set; }
        [ManyToOne]
        public List<PropertyModel> Property { get; set; }
        [ForeignKey(typeof(ProductServiceModel))]
        public int IdProductService { get; set; }
        [ManyToOne]
        public List<ProductServiceModel> ProductService { get; set; }
        [ForeignKey(typeof(EmployeeModel))]
        public int IdEmployee { get; set; }
        [ManyToOne]
        public List<EmployeeModel> Employee { get; set; }

        //Return parameters
        public override string ToString() { return string.Format("{0} {1} {2} {3} {4} {5} {6}", this.IdOrder, this.CreationDate, this.CreatedBy, this.ModificationDate, this.ModifiedBy, this.Price, this.Comment); }
    }
}