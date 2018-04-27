using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models.Repositories
{
    public class EFGummiRepository : IGummiRepository
    {

        GummiBearKingdomDbContext db = new GummiBearKingdomDbContext();

        public IQueryable<Gummi> Gummis
        { get { return db.Gummis; } }

        public Gummi Create(Gummi gummi)
        {
            db.Gummis.Add(gummi);
            db.SaveChanges();
            return gummi;
        }

        public void Delete(int id)
        {
            var thisGummi = db.Gummis.FirstOrDefault(Gummis => Gummis.GummiId == id);
            db.Gummis.Remove(thisGummi);
            db.SaveChanges();
        }

        public void DeleteAll()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM Gummis;");
        }

        public Gummi Edit(Gummi gummi)
        {
            db.Entry(gummi).State = EntityState.Modified;
            db.SaveChanges();
            return gummi;
        }
    }
}
