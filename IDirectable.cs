namespace RoverControlCenter
{
    /*
     * For the future if I want achieve Polymorphious use interface as the bundle Array[] type with the wanted methods
     * to then nicely use them in a foreach! Do not use a superclass for polymorphious!
     */
    interface IDirectable
    { // Q6
        string GetInfo();
        string Explore();
        string Collect();
    }
}