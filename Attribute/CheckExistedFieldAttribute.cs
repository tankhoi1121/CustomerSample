using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CustomerSample.Models;

namespace CustomerSample.Attribute
{
    //public class CheckExistedField
    //{
    //}

    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class CheckExistedFieldAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            CustomerHandleWithDB customerHandleWithDB = new CustomerHandleWithDB();

            AsusDBDataContext db = new AsusDBDataContext();
            var idByFullName = db.GetIdByFullName(value.ToString()).ToList();
            if (idByFullName.Count > 0)
            {
                this.CustomerID = idByFullName[0].CustomerID;
            }
            List<CheckExistedFieldResult> res = null;
            if (value != null)
            {
                res = customerHandleWithDB.CheckExistedField(CustomerID, value.ToString()).ToList();
            }
            if (res.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int CustomerID { get; set; }
    }
}