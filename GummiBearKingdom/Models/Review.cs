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
        public Review()
        {
            this.Gummis = new HashSet<Gummi>();
        }

        public int AuthorId { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public virtual ICollection<Gummi> Gummis { get; set; }

    }
}