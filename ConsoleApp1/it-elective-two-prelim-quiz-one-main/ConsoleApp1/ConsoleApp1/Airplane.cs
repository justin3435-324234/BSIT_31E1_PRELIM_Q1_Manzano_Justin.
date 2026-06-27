namespace TransportChallenge
{
    public class Airplane : Vehicle, IFlyable
    {
        public override string Move() => "Flying in the sky.";
    }
}