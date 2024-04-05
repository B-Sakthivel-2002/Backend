using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using task.Interface;
using task.Models;

namespace task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class depoController : ControllerBase
    {
        private readonly myInterface _inter;

        public depoController(myInterface inter)
        {
            _inter = inter;
        }
        [HttpGet("equipment")]
        public ActionResult<IEnumerable<EquipmentDetails>> GetEquipmentDetails()
        {
            var equipment = _inter.GetEquipmentDetails();
            return Ok(equipment);
        }
        [HttpGet("transport")]
        public ActionResult<IEnumerable<EquipmentDetails>> GetTransportDetails()
        {
            var transport = _inter.GetTransportDetails();
            return Ok(transport);
        }
         [HttpPost("equipment")]
        public IActionResult InsertEquipmentDetail([FromBody] EquipmentDetails newequp)
        {
            try
            {
                _inter.InsertEquip(newequp);
                return Ok(newequp);
 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
       [HttpPost("transport")]
        public IActionResult InsertTransportDetail([FromBody] transportDetail newTrans)
        {
            try
            {
                _inter.InsertTrans(newTrans);
                return Ok(newTrans);
            
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
        [HttpGet("business")]
        public ActionResult<IEnumerable<EquipmentDetails>> GetBusiness()
        {
            var equipment = _inter.GetBusinessPartner();
            return Ok(equipment);
        }
         [HttpGet("depot")]
        public ActionResult<IEnumerable<EquipmentDetails>> Getdepot()
        {
            var equipment = _inter.GetDepotDetail();
            return Ok(equipment);
        }
    }
}