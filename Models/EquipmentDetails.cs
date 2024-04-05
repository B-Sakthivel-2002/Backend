using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class EquipmentDetails
    {
        public int equipmentId{get;set;}
        public string equipmentNo {get;set;}
        public int equipmentSize {get;set;}
        public string equipmentLinerId {get;set;}
        public string depotId{get;set;}

        public string conTrackingNo {get;set;} 
        public DateTime gateInDateTime{get;set;}  
        public string ReferenceNo{get;set;}
    }
}