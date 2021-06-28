using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Model.Models
{
    public class Publishers
    {
        [Key]
        public int PublisherID { get; set; }
        [Required]
        public int PublisherName { get; set; }
        
    }
}
