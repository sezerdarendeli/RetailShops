using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Domain.Shared
{
    public class CreateInvoiceRequest
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public string InvoiceSerialNumber { get; set; }

        public decimal Total { get; set; }

        public int UserId { get; set; }
        public int OrderTotal { get; set; }

        public List<CreateInvoiceDetailRequest> InvoiceDetails {get;set;}
    }
}
