using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entites
{
    public class Customer
    {
        [Key, Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("CustomerName")]
        public string CustomerName { get; set; }
        [Column("CustomerEmail"),Index(IsUnique = true)]
        public string CustomerEmail { get; set; }
        [Column("CustomerPhone")]
        public string CustomerPhone { get; set; }
    }
}
