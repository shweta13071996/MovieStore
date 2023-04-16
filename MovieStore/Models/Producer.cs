using MovieStore.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full name Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biograpghy is Required")]
        public string Bio { get; set; }
        //relationship
        public List<Movie> Movies{ get; set; }

    }
}
