using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models.Repositories
{
    public interface IReviewRepository
    {
        IQueryable<Review> Reviews { get; }
        IQueryable<Gummi> Gummis { get; }
        Review Create(Review review);
        Review Edit(Review review);
        void Delete(int id);
    }
}
