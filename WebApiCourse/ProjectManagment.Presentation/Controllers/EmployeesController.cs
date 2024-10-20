﻿using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Presentation.Controllers
{

    [ApiController]
    [Route("api/projects/{projectId}/employees")]
    public class EmployeesController : ControllerBase
    {

        private readonly IServiceManager _servicemanager;

        public EmployeesController(IServiceManager servicemanager)
        {
            _servicemanager = servicemanager;
        }

        [HttpGet]
        public IActionResult GetAllEmployeeByProjectId(Guid  projectId)
        {
            try
            {
                var employeeList = _servicemanager.EmployeeService.GetAllEmployeesByProjectId(projectId, false);
                return Ok(employeeList);
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Internal Server Error : ");
            }
        }

        [HttpGet ("{id:guid}")]

        public IActionResult GetOneEmployeeByProjectId(Guid projectId , Guid id) {
            try
            {
                var employee =  _servicemanager.EmployeeService.GetOneEmployeeByProjectId(projectId , id , false);
                return Ok(employee);

            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal Server Error ! ");

            }
        }

  
    }
}
