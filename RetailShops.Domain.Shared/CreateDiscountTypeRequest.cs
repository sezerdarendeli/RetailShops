using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Domain.Shared
{
    public class CreateDiscountTypeRequest
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public string DiscountTypeName { get; set; }

        public int Rate { get; set; }

        public bool IsPercentage { get; set; }
    }
}
