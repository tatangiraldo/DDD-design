using Wpm.Management.Domain.ValueObjects;

namespace Wpm.Management.Domain;

public class Pet : Entity
{
    public string Name { get; init; }
    public int Age { get; init; }

    public string Color { get; init; }
    public Weight Weight { get; init; }
    public Sex Sex { get; init; }
    public BreedId BreedId { get; set; }


    public Pet(Guid id, string name, int age, string color, Weight weight, Sex sex)
    {
        Id = id;
        Name = name;
        Age = age;
        Color = color;
        Weight = weight;
        Sex = sex;
    }
}

public enum Sex
{
    Male,
    Female
}
