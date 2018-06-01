using Browar.Repositories.Interfaces;
using Browar.Services.Interfaces;
using Models.Binding;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Browar.Services.Services
{
    public class BeerService : IBeerService
    {
        private readonly IBeerRepository _beerRepository;

        public BeerService(IBeerRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public void AddBeer(AddBeer addBeer)
        {
            var beer = new Beer //mapowanie na obiekt z bazy danych
            {
                Name = addBeer.Name,
                Brand = addBeer.Brand,
                Kind = addBeer.Kind,
                Country = addBeer.Country,
                Alcohol = addBeer.Alcohol,
                Description = addBeer.Description,
                Rate = addBeer.Rate,
                AddedAt = DateTime.Now,
                IsDeleted = false
            };

            _beerRepository.InsertBeer(beer);
        }
    }
}
