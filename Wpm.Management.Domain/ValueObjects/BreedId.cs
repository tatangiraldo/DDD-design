using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpm.Management.Domain.ValueObjects
{
    public record class BreedId
    {
        private readonly IBreedService breedService;

        public Guid Value { get; init; }
        public BreedId(Guid value, IBreedService breedService) {
            this.breedService = breedService;
            validateBreed(value);
            Value = value;
        }

        private void validateBreed(Guid value)
        {
            if (breedService.GetBred(value) == null)
            {
                throw new ArgumentException("Invalid breed");
            }
            throw new NotImplementedException();
        }
    }
}
