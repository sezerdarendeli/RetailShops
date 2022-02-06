using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RetailShops.Domain.Shared
{
   public class CreateInvoiceDetailRequest
    {

        public int Id { get; set; }

        public int ProductId { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }

        public decimal DiscountPrice { get; set; }

        public int InvoiceId { get; set; }
        public string ProductName { get; set; }
        public object CreatedDate { get; set; }
    }
}
