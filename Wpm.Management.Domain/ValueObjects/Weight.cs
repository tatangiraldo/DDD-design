using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Wpm.Management.Domain.ValueObjects
{
    public record Weight
    {
        public decimal Value { get; init; }

        public Weight(decimal id)
        {
            if (id < 0) throw new ArgumentException("Invalid Weight");
            Value = id;
        }
    }
}
