using System;

namespace BusinessLayer
{
    public class User
    {
        [Required]
        [Key]
        public int ID {get;set;}
        
        [Required]
        [Range(3, 20, ErrorMessage="First name must be between 3 and 20 charachters")]
        public string Fname{get ;set;}
        
        [Required]        
        [Range(3, 20, ErrorMessage="Middle name must be between 3 and 20 charachters")]
        public string Mname{get; set;}
        
        [Required]        
        [Range(3, 20, ErrorMessage="Last name must be between 3 and 20 charachters")]
        public string Lname{get; set;}
        
        [Required]
        [Unique]
        [[StringLength(10, Minimumlength = 10)]
        public int EGN{get; set;}
        
        [Required]
        [StringLength(9, Minimumlength = 9)]
        public int IDcardnumber {get; set;}
        
        [Required]
        public DateTime birthdaydate{get; set;}
        
        [Required]
        public string Town{get; set;}
        
        [Required]
        public string Address{get; set;}
        
        [Required]
        public string Email{get; set;}
        
        [Required]
        public string Username{get; set;}
        
        [Required]
        public string Password{get; set;}
        
        [Required]
        public string Telephone{get; set;}
        
    }
}
