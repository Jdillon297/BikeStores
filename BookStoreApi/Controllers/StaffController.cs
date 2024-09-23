﻿using BookStoreApi.Entities;
using BookStoreApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService service;
        public StaffController(IStaffService service)
        {
             this.service = service;
        }


        [HttpGet]
        public ActionResult GetStaff()
        {
            return Ok(this.service.GetAllStaff());
        }

        [HttpGet("GetManagers")]
        public ActionResult<IEnumerable<Staff>> GetManagers()
        {
            return Ok(this.service.GetManagers());  
        }


    }

}
