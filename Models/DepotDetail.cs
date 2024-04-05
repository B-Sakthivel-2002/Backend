using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class DepotDetail
    {
        [Key]
        public string depotId{get;set;}
        public string depotCode {get;set;}
    }
}