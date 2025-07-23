using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInformationPage.Models;

namespace StudentInformationPage.Data
{
    public class StudentInformationPageContext : DbContext
    {
        public StudentInformationPageContext (DbContextOptions<StudentInformationPageContext> options)
            : base(options)
        {
        }

        public DbSet<StudentInformationPage.Models.Student> Student { get; set; } = default!;
    }
}
