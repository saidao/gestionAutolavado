using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.Models
{
    public class ClientModel
    {
        //Generic parameters
        [PrimaryKey, AutoIncrement]
        public int IdClient { get; set; }
        [Indexed]
        public DateTime CreationDate { get; set; }
        [Indexed]
        public string CreatedBy { get; set; }
        [Indexed]
        public DateTime ModificationDate { get; set; }
        [Indexed]
        public string ModifiedBy { get; set; }

        //Specific parameters
        //Object: Clientes
        [Indexed, MaxLength(100)]
        public string Names { get; set; }
        [Indexed, MaxLength(100)]
        public string LastName { get; set; }
        [Indexed]
        public string FullName { get { return string.Format("{0} {1}", this.Names, this.LastName); } }
        [Indexed, MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string HomePhone { get; set; }
        [MaxLength(50)]
        public string CellPhone { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }

        //Relationship parameters
        [OneToMany]
        public List<PropertyModel> Properties { get; set; }
        [OneToMany]
        public List<OrderModel> Orders { get; set; }

        //Return parameters
        public override string ToString() { return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", this.IdClient, this.CreationDate, this.CreatedBy, this.ModificationDate, this.ModifiedBy, this.FullName, this.Email, this.HomePhone, this.CellPhone, this.Address); }

        //Search parameters
        public override int GetHashCode() { return IdClient; }
    }
}
