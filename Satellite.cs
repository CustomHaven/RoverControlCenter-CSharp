namespace RoverControlCenter
{
    /*
     * extends Probe because we used superclass in the future when it comes to polymorphious use an interface instead 
     * that holds the wanted methods that we are going to loop over!
     * And we have the IDirectable interface as a great example!
     */
    class Satellite : Probe, IDirectable // Q7 implements the interface
    {
        public string Alias
        { get; private set; }

        public int YearLaunched
        { get; private set; }

        public Satellite(string alias, int yearLaunched)
        {
            Alias = alias;
            YearLaunched = yearLaunched;
        }

        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
        }

        public override string Explore()
        {
            return "Satellite is exploring the far reaches of space!";
        }

        public override string Collect()
        {
            return "Satellite is collecting photographic evidence!";
        }
    }
}