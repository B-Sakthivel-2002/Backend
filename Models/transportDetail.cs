using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class transportDetail
    {
        public int transportId {get;set;} 
        public string transportCompany{get;set;} 
        public string licenseNo {get;set;} 
        public string driverName {get;set;}

        public int driverMobileNo{get;set;}
        public string driverEmail {get;set;}
    }
}