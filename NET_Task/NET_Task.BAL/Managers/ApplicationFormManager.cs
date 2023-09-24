using NET_Task.BAL.Repository.Interfaces;
using NET_Task.BAL.Repository;
using NET_Task.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NET_Task.DAL.Data;
using NET_Task.BAL.DTOs;
using Microsoft.EntityFrameworkCore;
using NET_Task.DAL.Manager;

namespace NET_Task.BAL.Managers
{
    public class ApplicationFormManager : BaseRepo<ApplicationForm>, IApplicationFormRepo
    {
        private readonly MainDbContext context;
        private readonly IMapper mapper;

        public ApplicationFormManager(MainDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<ApplicationFormDto>> GetApplicationAsync()
        {
            var data = await context.ApplicationForms.ToListAsync();
            return mapper.Map<List<ApplicationFormDto>>(data);
        }

        public async Task<ApplicationFormDto> GetApplicationByIDAsync(int AppID)
        {
            var data = await GetByIdAsync(AppID);
            return mapper.Map<ApplicationFormDto>(data);
        }

        public async Task<ApplicationFormDto> UpdateApplicationAsync(ApplicationFormDto applicationFormDto)
        {
            if (applicationFormDto.CoverPhoto != null && applicationFormDto.ResumeFile != null)
            {
                applicationFormDto.Resume = await FileManager.UploadFileAsync(applicationFormDto.ResumeFile);
                applicationFormDto.CoverImage = await FileManager.UploadFileAsync(applicationFormDto.CoverPhoto);
            }
            var data = mapper.Map<ApplicationForm>(applicationFormDto);
            await UpdateAsync(data);
            return applicationFormDto;
        }
    }
}
