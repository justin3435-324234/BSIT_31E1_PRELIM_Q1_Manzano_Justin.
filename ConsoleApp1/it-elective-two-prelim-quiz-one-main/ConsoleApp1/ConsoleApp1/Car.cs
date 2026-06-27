namespace TransportChallenge
{
    public class Car : Vehicle, IDriveable
    {
        public override string Move() => "Driving on the road.";
    }
}