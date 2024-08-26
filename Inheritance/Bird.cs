namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
        IsAlive = true;
        HasHair = true;
        LegCount = 2;
        LandAirWater = "Air";
    }
        public bool CanFly { get; set; }
        public double BeakSize { get; set; }
        public string HairColor { get; set; }
        public bool DoesMigrate { get; set; }
    }
