using NET_Task.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Task.DAL.Models
{
    public class ProgramDetails
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(256)]
        public string Summary { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        [MaxLength(256)]
        public string keySkills { get; set; }

        [MaxLength(256)]
        public string ProgramBenfits { get; set; }

        [MaxLength(256)]
        public string ProgramCriteria { get; set; }

        [EnumDataType(typeof(ProgramType))]
        public ProgramType ProgramType { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ProgramStart { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime AppOpen { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime AppClose { get; set; }

        [MaxLength(256)]
        public string Duration { get; set; }

        [MaxLength(256)]
        public string ProgramLocation { get; set; }

        [EnumDataType(typeof(Qualification))]
        public Qualification Qualification { get; set; }

        [MaxLength(256)]
        public string MaxNumberOfApp { get; set; }
    }
}
