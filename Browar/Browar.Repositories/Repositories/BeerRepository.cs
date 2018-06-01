using Browar.Repositories.Database;
using Browar.Repositories.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Browar.Repositories.Repositories
{
    public class BeerRepository : IBeerRepository
    {
        private readonly DatabaseContext _context;

        public BeerRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void InsertBeer(Beer beer)
        {
            _context.Beers.Add(beer); //dodaj e do bazy browar
        }

        public Beer Get(long id)
        {
            return _context.Beers.FirstOrDefault(b => b.Id == id); // zwraca z bazy browar o danym id
        }
    }
}
