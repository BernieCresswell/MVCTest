using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_IV_Test.Domain.Interfaces
{
    public interface ICustomerPricingQuery
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         string Email { get; set; }
         string Address1 { get; set; }
         string City { get; set; }
         string Postcode { get; set; }
         string Country { get; set; }
         string[] Products { get; set; }
         void Save();

    }
}
