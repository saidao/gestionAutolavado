using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace gestionAutolavado.Models
{
    public class EmployeeModel
    {
        //Generic parameters
        [PrimaryKey, AutoIncrement]
        public int IdEmployee { get; set; }
        [Indexed]
        public DateTime CreationDate { get; set; }
        [Indexed]
        public string CreatedBy { get; set; }
        [Indexed]
        public DateTime ModificationDate { get; set; }
        [Indexed]
        public string ModifiedBy { get; set; }

        //Specific parameters
        //Object: Empleados
        [Indexed, MaxLength(100)]
        public string Names { get; set; }
        [Indexed, MaxLength(100)]
        public string LastName { get; set; }
        [Indexed]
        public string FullName { get { return string.Format("{0} {1}", this.Names, this.LastName); } }
        [Indexed, MaxLength(100)]
        public string Alias { get; set; }
        [Indexed, MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string HomePhone { get; set; }
        [MaxLength(50)]
        public string CellPhone { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }

        //Relationship parameters
        [ForeignKey(typeof(ClientModel))]
        public int IdClient { get; set; }
        [OneToMany]
        public List<OrderModel> Orders { get; set; }

        //Return parameters
        public override string ToString() { return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", this.IdEmployee, this.CreationDate, this.CreatedBy, this.ModificationDate, this.ModifiedBy, this.FullName, this.Alias, this.Email, this.HomePhone, this.CellPhone, this.Address); }
    }
}
