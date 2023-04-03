using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Models;
using TravelerAPI.Models.Repositories;
using TravelerAPI.Models.ViewModel;

namespace TravelerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsController : ControllerBase
    {

        private readonly IServiceRepository<Travel> travelRepo;
        public TravelsController(IServiceRepository<Travel> _travelRepo)
        {
            travelRepo = _travelRepo;
        }

        [HttpGet("get-travels")]
        public IActionResult GetItems()
        {
            var travels = travelRepo.List();
            return Ok(travels);
        }

        [HttpGet("get-travel/{id}")]
        public IActionResult GetItem(int id)
        {
            var travel = travelRepo.GetById(id);
            return Ok(travel);
        }

        [HttpPost("add-travel")]
        public IActionResult AddItem(TravelViewModel model)
        {
            var travelToAdd = new Travel
            {
                TravelNo = model.TravelNo,
                TravelName = model.TravelName,
                TravelDesc = model.TravelDesc,
                From = model.From,
                To = model.To,
                Price = model.Price,
                IsActive = true,
                IsDeleted = false,
                CreationDate = DateTime.Now,
                ModifacationDate = DateTime.Now
            };
            var result = travelRepo.Add(travelToAdd);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPut("update-travel/{id}")]
        public IActionResult UpdateItem(int id, TravelViewModel model)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var travelToUpdate = new Travel
            {
                TravelNo = model.TravelNo,
                TravelName = model.TravelName,
                TravelDesc = model.TravelDesc,
                From = model.From,
                To = model.To,
                Price = model.Price,
                IsActive = true,
                IsDeleted = false,
                CreationDate = DateTime.Now,
                ModifacationDate = DateTime.Now
            };

            var result = travelRepo.Update(id, travelToUpdate);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }


        [HttpDelete("delete-travel/{id}")]
        public IActionResult DeleteTravel(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var result = travelRepo.DeleteById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }

}
