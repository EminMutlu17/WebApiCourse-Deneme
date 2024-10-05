using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Project
    {




        [Column("ProjectId")]
        public Guid ID { get; set; }



        [Required(ErrorMessage = "Project Name is Required !")]
        [MaxLength(60, ErrorMessage = " You have exceeded the length value  : (Max 60 character")]
        public string Name { get; set; }



        public string ? Description { get; set; }

        public string? Field { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}

