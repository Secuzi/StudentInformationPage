using System.ComponentModel.DataAnnotations;

namespace StudentInformationPage.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string? Course { get; set; }
        [Display(Name = "Year Level")]
        public int YearLevel { get; set; }

    }
}
