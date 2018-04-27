using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace GummiBearKingdom.Models
{
    [Table("Reviews")]
    public class Review
    {

        [Key]
        public int ReviewId { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }
        public int Id { get; set; }
        public virtual Gummi Gummi { get; set; }

    }
}