using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LanzhouBeefNoodles.Models
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "pls write down your name")]
        [StringLength(50, ErrorMessage = "You name must be less than 50")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is good")]
        [StringLength(50,ErrorMessage = "email is not that long")]
        [DataType(DataType.EmailAddress, ErrorMessage = "your email is wrong")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "pls type in the right email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "pls, we need your feedback")]
        [StringLength(400, ErrorMessage = "cannot exceed 400 characters")]
        public string Message { get; set; }

        public DateTime CreateDateUTC { get; set; }
    }

}
