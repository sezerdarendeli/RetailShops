using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RetailShops.Domain.Entities
{
    [Table("DiscountType")]
    public class DiscountTypeEntity:EntityBase
    {
        public string DiscountTypeName { get; set; }

        public decimal Rate { get; set; }

        public bool IsPercentage { get; set; }
    }
}
