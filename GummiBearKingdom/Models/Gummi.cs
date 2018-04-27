using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace GummiBearKingdom.Models
{
    [Table("Gummis")]
    public class Gummi
    {

        [Key]
        public int GummiId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public int? Id { get; internal set; }
    }
}
