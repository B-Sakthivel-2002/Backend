using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Context;
using task.Interface;
using task.Models;

namespace task.Crud
{
    public class taskcrud : myInterface
    {  private readonly myContext myContext;
        public taskcrud(myContext _context)
        {
            myContext=_context;
        }

        public IEnumerable<BusinessPartner> GetBusinessPartner()
        {
            return myContext.BusinessPartner.ToList();
        }

        public IEnumerable<DepotDetail> GetDepotDetail()
        {
            return myContext.DepotDetail.ToList();
        }

        public IEnumerable<EquipmentDetails> GetEquipmentDetails()
        {
              return myContext.EquipmentDetails.ToList();
        }

   
        public IEnumerable<transportDetail> GetTransportDetails()
        {
             return myContext.transportDetail.ToList();
        }

        public void InsertEquip(EquipmentDetails newEquip)
        {
           myContext.EquipmentDetails.Add(newEquip);
           myContext.SaveChanges();
        }

        public void InsertTrans(transportDetail newTrans)
        {
             myContext.transportDetail.Add(newTrans);
             myContext.SaveChanges();
        }

        
    }
}