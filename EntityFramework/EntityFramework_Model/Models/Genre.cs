﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Model.Models
{
    [Table("tbl_Genre")]
   public  class Genre
    {
        public int GenreId { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public int  DisplayOrder { get; set; }

    }
}
