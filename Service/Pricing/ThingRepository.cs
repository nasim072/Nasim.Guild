using Domain.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Pricing
{
    public interface IThingRepository
    {
        void Add(Thing thing);
        Thing GetBy(int id);
        Thing GetAll();
        void SaveChange();

    }
}
