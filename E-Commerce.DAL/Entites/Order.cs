using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entites
{
    public class Order
    {
        [Key, Column("OrderId")]
        public int OrderId { get; set; }
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }
        [Column("OrderStatus")]
        public string OrderStatus { get; set; }
        [Column("OrderTotalPrice")]
        public decimal OrderTotalPrice { get; set; }
        [Column("CustomerId"), ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
