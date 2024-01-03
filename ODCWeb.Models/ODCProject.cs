using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.Models
{
    public class ODCProject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public ICollection<Floor> FloorIds { get; } = new List<Floor>();

        [Display(Name = "User")]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        /*[ForeignKey(nameof(CategoryId))]  */       /* this is same as below*/
        
        [ValidateNever]
        public virtual ApplicationUser User { get; set; }
 
    }
}
