namespace TransportChallenge
{
    public class Boat : Vehicle, ISailable
    {
        public override string Move() => "Sailing on the water.";
    }
}