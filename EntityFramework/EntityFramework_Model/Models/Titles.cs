using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Model.Models
{
    public class Titles
    {
        [Key]
        public int isbn { get; set; }
        [Required]
        [MaxLength(45)]
        public string Title { get; set; }
        [Required]
       public string EditionNumber { get; set; }
        [Required]
        public string CopyRight { get; set; }
             

        [Required]
        [MinLength(45)]
        public string ImageFile { get; set; }
        [Required]
        public int Price { get; set; }

        [ForeignKey("Publishers")]
        public int Publisher_ID { get; set; }
        public Publishers Publishers { get; set; }



    }
}
