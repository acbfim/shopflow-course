using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopflow.api.Extensions;
using shopflow.application.Contracts;
using shopflow.contract.Constants;
using shopflow.contract.Model.Entities.Customer;
using shopflow.contract.Model.Entities.Customer.Dtos;
using shopflow.contract.Model.Entities.Global;

namespace shopflow.api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerApplication _app;

        public CustomerController(ICustomerApplication app)
        {
            this._app = app;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<PagedList<Customer>>> GetAll(
            [FromQuery] [Range(1, int.MaxValue)] int page,
            [FromQuery] int itemsPerPage = PageConstants.MIN_ITEMS,
            [FromQuery] bool includeContacts = false,
            [FromQuery] bool includeDocuments = false,
            [FromQuery] bool includeAddresses = false
        )
        {
            var results = await _app.GetAll(page,itemsPerPage,includeContacts,includeDocuments,includeAddresses);

            if(results.Elements.Count() == 0)
                return NoContent();

            var response = results.Ok();

            return StatusCode(response.StatusCode,response);
        }

        [HttpGet("get-by-id")]
        public async Task<ActionResult<PagedList<Customer>>> GetAll(
            [FromQuery] long id,
            [FromQuery] bool includeContacts = false,
            [FromQuery] bool includeDocuments = false,
            [FromQuery] bool includeAddresses = false
        )
        {
            var results = await _app.GetById(id,includeContacts,includeDocuments,includeAddresses);

            var response = results.Ok();

            return StatusCode(response.StatusCode,response);
        }

        [HttpGet("get-by-name")]
        public async Task<ActionResult<PagedList<Customer>>> GetAll(
            [FromQuery] string name,
            [FromQuery] [Range(1, int.MaxValue)] int page,
            [FromQuery] int itemsPerPage = PageConstants.MIN_ITEMS,
            [FromQuery] bool includeContacts = false,
            [FromQuery] bool includeDocuments = false,
            [FromQuery] bool includeAddresses = false
        )
        {
            var results = await _app.GetByName(name,page,itemsPerPage,includeContacts,includeDocuments,includeAddresses);

            var response = results.Ok();

            return StatusCode(response.StatusCode,response);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Customer>> Create([FromBody] CreateCustomerDto customer)
        {
            var created = await _app.Create(customer);

            var response = created.Created();

            return StatusCode(response.StatusCode,response);
        }

        [HttpPut("update")]
        public async Task<ActionResult<Customer>> Update([FromBody] Customer customer)
        {
            var updated = await _app.Update(customer);

            var response = updated.Updated();

            return StatusCode(response.StatusCode,response);
        }

        [HttpDelete("detele")]
        public async Task<ActionResult<Customer>> Delete([FromQuery] long id)
        {
            var delete = await _app.Delete(id);

            var response = delete.Deleted();

            return StatusCode(response.StatusCode,response);
        }


    }
}