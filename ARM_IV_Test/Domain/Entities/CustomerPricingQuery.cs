using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ARM_IV_Test.Domain.Interfaces;
namespace ARM_IV_Test.Domain.Entities
{
    class CustomerPricingQuery:ICustomerPricingQuery
    {

        INotification notification = null;

        public CustomerPricingQuery(INotification _notification)  // inject the concrete class
        {
            this.notification = _notification;
        }

        public CustomerPricingQuery()
        {
            // TODO: Complete member initialization
        }
        
        public void Save()
        {
            //call the CustomerQueryRepository here when writing to db
            // mock save is sucessfull
            // then call notification
            
            notification.SendNotification(this);
            //throw new NotImplementedException();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public string[] Products { get; set; }
        

    }


}