using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Domain.Shared
{
    
    public class InvoiceResponse
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public string InvoiceSerialNumber { get; set; }

        public decimal Total { get; set; }

        public int UserId { get; set; }
    }
}
