using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models.Repositories
{
    public class EFReviewRepository : IReviewRepository
    {
        GummiBearKingdomDbContext db = new GummiBearKingdomDbContext();

        public IQueryable<Review> Reviews
        { get { return db.Reviews; }}

        public IQueryable<Gummi> Gummis
        { get { return db.Gummis; }}

        public Review Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
            return review;
        }

        public void Delete(int id)
        {
            Review thisReview = db.Reviews.FirstOrDefault(Reviews => Reviews.ReviewId == id);
            db.Reviews.Remove(thisReview);
            db.SaveChanges();
        }

        public Review Edit(Review review)
        {
            db.Entry(review).State = EntityState.Modified;
            db.SaveChanges();
            return review;
        }
    }
}
