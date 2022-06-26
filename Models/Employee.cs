using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileuploadMVC.Models
{
    public class Employee
    {
     

 
        public HttpPostedFileBase Resume { get; set; }
        public string Skills { get; internal set; }
    }

}