using AutoMapper;
using NET_Task.BAL.DTOs;
using NET_Task.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.AutoMapper
{
    public class DomainProfile :Profile
    {
        public DomainProfile()
        {
            CreateMap<ProgramDetails, ProgramDetailsDTO>().ReverseMap();
        }
    }
}
