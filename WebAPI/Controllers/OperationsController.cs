﻿using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        IOperationService _operationService;
        public OperationsController(IOperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpPost(template:"add")]
        public IActionResult Add(OperationClaim operation)
        {
            var result = _operationService.Add(operation);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost(template:"delete")]
        public IActionResult Delete(OperationClaim operation)
        {
            var result = _operationService.Delete(operation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPut(template:"update")]
        public IActionResult Update(OperationClaim operation)
        {
            var result = _operationService.Update(operation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet(template:"getall")]
        public IActionResult GetAll()
        {
            var result = _operationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}