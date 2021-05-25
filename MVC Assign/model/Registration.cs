using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public enum MeetingStatus
    {
        Yes,
        Maybe,
        No
    }
    public class Registration
    {
       internal string MeetingStatus;

        [Required(ErrorMessage = "Name is compulsary feild")]  
        public int? Name { get; set; }

        [Required(ErrorMessage = "Email name is compulsary")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone no is compulsary")]
        public double? Phone { get; set; }

        [Required(ErrorMessage = "Will Attend is compulsary")]
        
        public MeetingStatus Options { get; internal set; }
        
    }
    
}
