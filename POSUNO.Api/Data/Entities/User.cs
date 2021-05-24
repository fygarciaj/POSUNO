using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSUNO.Api.Data.Entities
{
    public class User
    {

        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [MaxLength(50)]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public String LastName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public String Password { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
