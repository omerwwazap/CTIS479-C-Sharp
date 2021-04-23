using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Models
{
    public interface IHelicopterRepository
    {
        IQueryable<Helicopter> Helicopters { get; }
    }
}
