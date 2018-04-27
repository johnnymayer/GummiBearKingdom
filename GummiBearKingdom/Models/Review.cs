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

        public Review(string author, string content)
        {
            Author = author;
            Content = content;
            ReviewId = 0;
        }

        public Review()
        {
            
        }

		public override bool Equals(object otherReview)
        {
            if (!(otherReview is Review))
            {
                return false;
            }
            else
            {
                Review newReview = (Review)otherReview;
                return this.ReviewId.Equals(newReview.ReviewId);
            }
        }

		public override int GetHashCode()
		{
            return this.ReviewId.GetHashCode();
		}
	}
}