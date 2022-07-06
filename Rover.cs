namespace RoverControlCenter
{
    /*
    * extends Probe because we used superclass in the future when it comes to polymorphious use an interface instead 
    * that holds the wanted methods that we are going to loop over! 
    * And we have the IDirectable interface as a great example!
    */
    class Rover : Probe, IDirectable // Q7 implements the interface
    {
        public string Alias
        { get; private set; }

        public int YearLanded
        { get; private set; }

        public Rover(string alias, int yearLanded)
        {
            Alias = alias;
            YearLanded = yearLanded;
        }

        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}";
        }

        public override string Explore()
        {
            return "Rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}