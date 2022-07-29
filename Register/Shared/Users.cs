using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Shared
{
    public class Users
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EMail { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "The Password do not match")]
        public int ConfirmPassword { get; set; }
        public DateTime RegDate { get; } = DateTime.Now;
        public DateTime LoginDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
    }
}
