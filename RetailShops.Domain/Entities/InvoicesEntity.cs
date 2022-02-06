using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RetailShops.Domain.Entities
{
    [Table("Invoices")]
    public class InvoicesEntity : EntityBase
    {

        [Required]
        public string InvoiceSerialNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OrderTotal { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
        public UserEntity Users { get; set; }

        public ICollection<InvoiceDetailEntity> InvoiceDetails { get; set; }

    }
}
