using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RetailShops.Domain.Entities
{
    [Table("UserType")]
    public class UserTypeEntity:EntityBase
    {
        public string TypeName { get; set; }
    }
}
