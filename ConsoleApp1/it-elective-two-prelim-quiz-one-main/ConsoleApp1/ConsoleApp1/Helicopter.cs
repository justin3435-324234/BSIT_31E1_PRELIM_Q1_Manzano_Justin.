namespace TransportChallenge
{
    public class Helicopter : Vehicle, IFlyable, IDriveable
    {
        public override string Move() => "Flying in the sky.";
    }
}