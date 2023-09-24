using Microsoft.AspNetCore.Http;
using NET_Task.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.BAL.DTOs
{
    public class ApplicationFormDto
    {
        public int ID { get; set; }

        [MaxLength(256)]
        public string FirstName { get; set; }

        [MaxLength(256)]
        public string LastName { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Phone { get; set; }

        [MaxLength(256)]
        public string Nationality { get; set; }

        [MaxLength(256)]
        public string CurrentResidence { get; set; }

        [MaxLength(256)]
        public string IDNumber { get; set; }


        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        public byte[]? CoverImage { get; set; }
        public IFormFile? CoverPhoto { get; set; }

        [MaxLength(256)]
        public string Education { get; set; }

        [MaxLength(256)]
        public string Experience { get; set; }
        public byte[]? Resume { get; set; }
        public IFormFile? ResumeFile { get; set; }
    }
}
