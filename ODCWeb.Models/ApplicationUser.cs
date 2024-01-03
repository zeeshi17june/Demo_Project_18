using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [DefaultValue(false)]
        public bool Approved {  get; set; }
        [AllowNull]
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int SubscriptionDaysLeft { get; set; }
        public bool SubscriptionStatus { get; set; }
    }
}
