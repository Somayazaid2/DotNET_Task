using NET_Task.BAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Repository.Interfaces
{
    public interface IProgramDetailsRepo
    {
        Task<ProgramDetailsDTO> CreateProgramAsync(ProgramDetailsDTO programDetailsDTO);
        Task<List<ProgramDetailsDTO>> GetProgramAsync();
        Task<ProgramDetailsDTO> GetProgramByIDAsync( int ProgID );
        Task<ProgramDetailsDTO> UpdateProgramAsync(ProgramDetailsDTO programDetailsDTO);
    }
}
