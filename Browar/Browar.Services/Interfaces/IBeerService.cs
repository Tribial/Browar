using Models.Binding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Browar.Services.Interfaces
{
    public interface IBeerService
    {
        void AddBeer(AddBeer addBeer);
    }
}
