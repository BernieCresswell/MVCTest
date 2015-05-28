using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_IV_Test.Domain.Interfaces
{
    public interface INotification
    {
          void SendNotification(ICustomerPricingQuery messageobject);
    }
}
