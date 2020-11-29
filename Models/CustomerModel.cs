using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerSample.Attribute;
using System.ComponentModel.DataAnnotations;

namespace CustomerSample.Models
{
    public class CustomerModel
    {
        int id = 0;

        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Required")]
        [CheckExistedField(ErrorMessage = "Is Existed")]
        public string FullName { get; set; }
    }
}