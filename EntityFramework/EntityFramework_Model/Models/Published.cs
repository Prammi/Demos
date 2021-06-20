using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Model.Models
{
    public class Published
    {
        [Key]
        public int Publisher_id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
    }
}
