﻿using System.ComponentModel.DataAnnotations;

namespace StudentInformationPage.Models
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage ="String input must be less than 30")]
        [MinLength(2, ErrorMessage ="String input should be greater than 2")]
        [Display(Name ="First Name")]
        public string? FirstName { get; set; }


        [MaxLength(30, ErrorMessage = "String input must be less than 30")]
        [MinLength(2, ErrorMessage = "String input should be greater than 2")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }


        [MaxLength(30, ErrorMessage = "String input must be less than 30")]
        [MinLength(2, ErrorMessage = "String input should be greater than 2")]
        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "String input must be less than 30")]
        public string? Course { get; set; }

        [Display(Name = "Year Level")]
        public int YearLevel { get; set; }
        [Required]

        public string? Gender { get; set; }
        [Required]

        public int Age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Display(Name = "Contact Number")]
        [RegularExpression(@"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Invalid phone number format.")]
        [DataType(DataType.PhoneNumber)]
        public string? ContactNumber { get; set; }

    }
}
