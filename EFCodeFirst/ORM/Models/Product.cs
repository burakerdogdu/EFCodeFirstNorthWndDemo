using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.ORM.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Suppliers Suppliers { get; set; }
        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Categories { get; set; }


        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "smallint")]
        public int? UnitsInStock { get; set; }
        [Column(TypeName = "smallint")]
        public int? UnitsOnOrder { get; set; }
        [Column(TypeName = "smallint")]
        public int? ReorderLevel { get; set; }
        public Boolean Discontinued { get; set; }
    }
}
