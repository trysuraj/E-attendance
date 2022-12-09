using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class AttendeesVM
    {
        
        [Required]
        public string FirstName { get; set; }
        public string? lastName { get; set; }
        [Required]
        public int Gender { get; set; }
        public int Stack { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public DateTime Arival { get; set; } = DateTime.Now;
        public string Departure { get; set; }
    }
}
