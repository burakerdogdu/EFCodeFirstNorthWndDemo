using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.ORM.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }

    }
}
