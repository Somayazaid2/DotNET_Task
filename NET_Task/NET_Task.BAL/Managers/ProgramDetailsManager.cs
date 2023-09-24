using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NET_Task.BAL.DTOs;
using NET_Task.BAL.Repository;
using NET_Task.BAL.Repository.Interfaces;
using NET_Task.DAL.Data;
using NET_Task.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Managers
{
    public class ProgramDetailsManager : BaseRepo<ProgramDetails>, IProgramDetailsRepo
    {
        private readonly MainDbContext context;
        private readonly IMapper mapper;

        public ProgramDetailsManager(MainDbContext context , IMapper mapper) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<ProgramDetailsDTO> CreateProgramAsync(ProgramDetailsDTO programDetailsDTO)
        {
            var data = mapper.Map<ProgramDetails>(programDetailsDTO);
            await AddAsync(data);
            return programDetailsDTO;
        }

        public async Task<List<ProgramDetailsDTO>> GetProgramAsync()
        {
            var data = await context.ProgramDetails.ToListAsync();
            return mapper.Map<List<ProgramDetailsDTO>>(data);
        }
        public async Task<ProgramDetailsDTO> GetProgramByIDAsync(int ProgID)
        {
            var data = await GetByIdAsync(ProgID);
            return mapper.Map<ProgramDetailsDTO>(data);
        }
        public async Task<ProgramDetailsDTO> UpdateProgramAsync(ProgramDetailsDTO programDetailsDTO)
        {
            var data = mapper.Map<ProgramDetails>(programDetailsDTO);
            await UpdateAsync(data);
            return programDetailsDTO;
        }
    }
}
