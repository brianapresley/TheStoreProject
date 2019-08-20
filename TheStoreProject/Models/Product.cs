using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheStoreProject.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public int Qty { get; set; }

        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }
    }
}
