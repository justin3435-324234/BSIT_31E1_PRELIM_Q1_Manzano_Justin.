namespace TransportChallenge
{
    public static class TransportResolver
    {
        public static Vehicle? Resolve(string transportType)
        {
            if (string.IsNullOrWhiteSpace(transportType)) return null;

            return transportType.ToLower().Trim() switch
            {
                "car" => new Car(),
                "plane" => new Airplane(),
                "boat" => new Boat(),
                "helicopter" => new Helicopter(),
                _ => null
            };
        }
    }
}