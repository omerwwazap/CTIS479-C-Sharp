using System.Linq;

namespace LeventDurdali_HW2.Models
{
    public interface IHelicopterRepository
    {
        IQueryable<Helicopter> Helicopters { get; }
    }
}