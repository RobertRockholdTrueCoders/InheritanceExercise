namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        IsAlive = true;
        HasHair = false;
        LegCount = 4;
        LandAirWater = "Water";
    }
    public bool CanRegenerate { get; set; }
    public string Habitat { get; set; }
    public bool HasScales { get; set; }
    public bool LivesLong { get; set; }
}