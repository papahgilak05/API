using API.Models;
using System;
using System.Collections.Generic;
namespace Client.ViewModel
{
    public class MasterDataVM
    {
        public string NIK { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public int Educations { get; set; }
        public string GPA { get; set; }
        public string UniversityName { get; set; }
        public List<Role> RoleName { get; set; }
    }
}
