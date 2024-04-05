using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Models;

namespace task.Interface
{
    public interface myInterface
    {
         IEnumerable<EquipmentDetails> GetEquipmentDetails();
         IEnumerable<transportDetail> GetTransportDetails();
         IEnumerable<BusinessPartner> GetBusinessPartner();
         IEnumerable<DepotDetail> GetDepotDetail();
         public void InsertEquip(EquipmentDetails newEquip);
        public void InsertTrans(transportDetail newTrans); 
    }
}