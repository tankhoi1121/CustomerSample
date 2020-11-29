using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSample.Models
{
    public class CustomerHandleWithDB
    {
        public List<CheckExistedFieldResult> CheckExistedField(int customerID, string fullName)
        {
            AsusDBDataContext db = new AsusDBDataContext();
            List<CheckExistedFieldResult> res = db.CheckExistedField(customerID, fullName, 1).ToList();

            return res;
        }
    }
}