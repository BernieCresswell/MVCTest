using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM_IV_Test.Domain.Repository
{
    public class CustomerQueryRepository
    {
        public bool Save()
        {
            // save to database using unit of work 
            // but for now just say it has happened
            // so always true
            return true;
        }

    }
}