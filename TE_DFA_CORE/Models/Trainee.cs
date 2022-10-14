using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TE_DFA_CORE.Models
{
    public partial class Trainee
    {
        [Key]
        public int Tid { get; set; }

        [Required(ErrorMessage ="Enter the Trainee Name")]
        [RegularExpression(@"^([a-zA-Z]+)$", ErrorMessage ="Name should contain only alphabets")]
        public string? Tname { get; set; }
        [Required(ErrorMessage ="Enter the Trainee age")]
        [Range(21,45,ErrorMessage ="Not Elligible")]
        public int? Tage { get; set; }
        [Required(ErrorMessage ="Enter the Trainee Designation")]
        public string? Tdesignation { get; set; }
    }
}
