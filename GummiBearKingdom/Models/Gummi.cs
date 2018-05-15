using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public Gummi(string name, string description, int price, int id = 0)
        {
            Name = name;
            Description = description;
            Price = price;
            GummiId = id;
        }

        public Gummi()
        {
        }

        public override bool Equals(object otherGummi)
		{
            if (!(otherGummi is Gummi))
            {
                return false;
            }
            else
            {
                Gummi newGummi = (Gummi)otherGummi;
                return this.GummiId.Equals(newGummi.GummiId);
            }
		}

		public override int GetHashCode()
		{
            return this.GummiId.GetHashCode();
		}
	}
}
