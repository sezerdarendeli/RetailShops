using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RetailShops.Domain.Entities
{
    [Table("InvoiceDetail")]
    public class InvoiceDetailEntity:EntityBase
    {

        [Required]
        public int ProductId { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPrice { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public InvoicesEntity Invoice { get; set; }
    }
}
