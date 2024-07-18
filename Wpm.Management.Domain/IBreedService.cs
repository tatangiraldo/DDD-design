using Wpm.Management.Domain.ValueObjects;

namespace Wpm.Management.Domain
{
    public interface IBreedService
    {
        Breed? GetBred(Guid id);
    }
    public class FakeBreedService : IBreedService
    {
        public readonly List<Breed> breeds = 
        [
            new Breed(Guid.NewGuid(), "Beaggle", new WeightRange(10m, 11m), new WeightRange(9, 10)),
            new Breed(Guid.NewGuid(), "Beaggle x", new WeightRange(10m, 11m), new WeightRange(9, 10))
        ];

        public Breed GetBred(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("Invalid Id");
        
            var result = breeds.Find(b => b.Id == id);
            return result ?? throw new ArgumentException("Breed not found");
        }
    }

}
