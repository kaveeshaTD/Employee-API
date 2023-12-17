using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.Services.Models
{
    public class UpdateEmployeeDto
    {
        [Required(ErrorMessage ="You Must Fill This Field")]
        public String FirstName { get; set; }

        public string LastName { get; set; }


        public string Email { get; set; }

        public string city { get; set; }
    }
}
