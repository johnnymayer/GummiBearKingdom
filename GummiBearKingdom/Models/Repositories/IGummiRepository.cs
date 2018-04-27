using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models.Repositories
{
    public interface IGummiRepository
    {
        IQueryable<Gummi> Gummis { get; }
        Gummi Create(Gummi gummi);
        Gummi Edit(Gummi gummi);
        void Delete(int id);
        void DeleteAll();
    }
}
