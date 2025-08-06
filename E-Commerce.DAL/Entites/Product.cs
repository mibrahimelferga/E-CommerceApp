using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entites
{
    public class Product
    {
        [Key,Column("ProductId")]
        public int ProductId { get; set; }
        [Column("ProductName")]
        public string ProductName { get; set; }
        [Column("ProductDescription")]
        public string ProductDescription { get; set; }
        [Column("ProductPrice")]
        public decimal ProductPrice { get; set; }
        [Column("ProductStock")]
        public int ProductStock { get; set; }
    }
}
