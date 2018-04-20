using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
    public class Gummi
    {
        [Key]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }
}
