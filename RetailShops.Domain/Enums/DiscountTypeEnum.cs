using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RetailShops.Domain.Enums
{
    public enum DiscountTypeEnum
    {
        [Description("Customer")]
        Customer = 1,
        [Description("Employee")]
        Employee = 2,
        [Description("AffiliateStore")]
        AffiliateStore = 3,
        [Description("Price")]
        Price =4
    }
}
