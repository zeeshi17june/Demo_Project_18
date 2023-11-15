using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateOnly? EndDate { get;set; }
    }
}
