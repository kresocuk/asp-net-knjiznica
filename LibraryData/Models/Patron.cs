using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Models
{
    public class Patron
    {
        public int Id{ get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }


        [Required]
        [Display(Name = "Library Card")]
        public LibraryCard LibraryCard { get; set; }
        public LibraryBranch HomeLibraryBranch { get; set; }
    }
}
