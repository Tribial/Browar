using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Browar.Repositories.Interfaces
{
    public interface IBeerRepository
    {
        void InsertBeer(Beer beer);
    }
}
