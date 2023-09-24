using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET_Task.BAL.DTOs;
using NET_Task.BAL.Repository.Interfaces;

namespace NET_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFormController : ControllerBase
    {
        private readonly IApplicationFormRepo repo;

        public ApplicationFormController(IApplicationFormRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet(Name = "GetAllApplicants")]
        public async Task<IActionResult> Index()
        {
            var data = await repo.GetApplicationAsync();
            if (data.Count == 0)
                return Ok("No Applicants found yet!");
            return Ok(data);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditApplication(int id, [FromForm] ApplicationFormDto dto)
        {
            if (id != dto.ID)
                return BadRequest("Request not valid!");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (await repo.GetApplicationByIDAsync(id) == null)
                return NotFound("Application not found!");
            var data = await repo.UpdateApplicationAsync(dto);
            return Ok(data);
        }

    }
}
