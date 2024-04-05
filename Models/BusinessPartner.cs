using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class BusinessPartner
    {
        [Key]
        public string linerId{get;set;}
        public string linerCode {get;set;}
    }
}