namespace RoverControlCenter
{
    /*
     * The superclass we used its good works but its better to use an interface instead!
     * we are using the superclass as the bundling Array[] type 
     * instead of using superclass which forces us to change some methods on the childrens class ie making override
     * and as well as using either virtual or abstract for the methods here it would be better to use interface instead
     * so then we do not have to make any changes to our methods.
     */
    abstract class Probe
    {
        public abstract string GetInfo();
        public abstract string Explore();
        public abstract string Collect();
    }
}