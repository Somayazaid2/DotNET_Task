using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET_Task.BAL.DTOs;
using NET_Task.BAL.Repository.Interfaces;

namespace NET_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramDetailsController : ControllerBase
    {
        private readonly IProgramDetailsRepo programDetailsRepo;

        public ProgramDetailsController(IProgramDetailsRepo programDetailsRepo)
        {
            this.programDetailsRepo = programDetailsRepo;
        }

        [HttpGet(Name = "GetAllPrograms")]
        public async Task<IActionResult> Index()
        {
            var data = await programDetailsRepo.GetProgramAsync();
            if (data.Count == 0)
                return Ok("No Programs found yet!");
            return Ok(data);
        }


        [HttpPost(Name = "CreateProgram")]
        public async Task<IActionResult> Create(ProgramDetailsDTO programDetailsDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //if (await programDetailsRepo.FindRestaurantByAdminID(restaurantDto.ResAdminID))
            //    return BadRequest("Request is rejected as already registered a restaurant to the system");
            var data = await programDetailsRepo.CreateProgramAsync(programDetailsDTO);
            return Ok(data);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditProgramDetails(int id,[FromForm] ProgramDetailsDTO programDetailsDTO)
        {
            if (id != programDetailsDTO.ID)
                return BadRequest("Request not valid!");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (await programDetailsRepo.GetProgramByIDAsync(id) == null)
                return NotFound("Program not found!");
            var data = await programDetailsRepo.UpdateProgramAsync(programDetailsDTO);
            return Ok(data);
        }
    }
}
