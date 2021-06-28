using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Model.Models
{
   public  class Authors
    {
        [Key]
        public int AuthorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
}
