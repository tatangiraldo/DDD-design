using Wpm.Management.Domain.ValueObjects;

namespace Wpm.Management.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Pet_should_be()
    {
        var id = Guid.NewGuid();

        var pet1 = new Pet(id, "nina", 22, "red", new Weight(20.5m), Sex.Male);

        var pet2 = new Pet(id, "dovbre", 20, "bluye", new Weight(20.5m), Sex.Male);

        Assert.True(pet1 == pet2);
    }

    [Fact]
    public void ValidateWeight()
    {
        var w1 = new Weight(20.5m);
        var w2 = new Weight(20.5m);
        Assert.True(w1 == w2);
    }

    [Fact]
    public void Weight_range_must_be (){
        var h1 = new WeightRange(10.5m, 20.5m);
        var h2 = new WeightRange(10.5m, 20.5m);
        Assert.True(h1 == h2);
    }

    [Fact]
    public void Breeed_Id_must_be_valid()
    {
        var breedService = new FakeBreedService();
        var Id = breedService.breeds[0].Id;
        var breedId = new BreedId(Id, breedService);
        Assert.NotNull(breedId);
    }

    [Fact]
    public void Breed_Id_must_be_invalid()
    {
        var breedService = new FakeBreedService();
        var id = Guid.NewGuid();

        Assert.Throws<ArgumentException>(() =>
        {
            var breedId = new BreedId(id, breedService);
        });
    }
}