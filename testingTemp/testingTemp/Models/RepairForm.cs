using System;
using System.ComponentModel.DataAnnotations;


namespace testingTemp.Models
{
    public class RepairForm
    {
        [Required]
        [StringLength(20, MinimumLength =5, ErrorMessage ="Not valid name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="No notes taken")]
        public string Notes { get; set;}
        [Required(ErrorMessage ="Trade not selected")]
        public string Trade { get; set; }
        [Required]
        [Range(0.05, 12, ErrorMessage ="Not valid amount of time")]
        public string Hours { get; set; }

    }
}
