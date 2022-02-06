using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Domain
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
