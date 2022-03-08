using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraVPN.DataLayer.Entities
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage = "Please insert a valid email address !")]
        public string EmailAddress { get; set; }
    }
}
