using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HabitsQuadrants.Models
{
    public class AddATaskResponse
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required(ErrorMessage = "Please enter a valid task name.")]
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        [Required (ErrorMessage = "Please enter a valid Quadrant.")]
        public string Quadrant { get; set; }
        public bool Completed { get; set; }

        //build foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
