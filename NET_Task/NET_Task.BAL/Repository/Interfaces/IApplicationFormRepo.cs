using NET_Task.BAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.Repository.Interfaces
{
    public interface IApplicationFormRepo
    {
        Task<List<ApplicationFormDto>> GetApplicationAsync();
        Task<ApplicationFormDto> GetApplicationByIDAsync(int AppID);
        Task<ApplicationFormDto> UpdateApplicationAsync(ApplicationFormDto applicationFormDto);
    }
}
