using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

       
        public int Age { get; set; }



        [Required(ErrorMessage = " FirstName is required ")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = " LastName  is required ")]
        public string LastName { get; set; }
        public string Position { get; set; }



        [ForeignKey(nameof(Project))]
        public Guid? ProjectId { get; set; }  /* Foregin Key */ 

        public Project Project { get; set; } /* Navigation Proprty */ 



    }
}

