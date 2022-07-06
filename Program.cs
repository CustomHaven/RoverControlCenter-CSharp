// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-rover-control-center
using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            // Q1
            // Rover[] rovers = new Rover[] {lunokhod, apollo, sojourner};

            // Q3
            // DirectAll(rovers);

            // Q4
            // Object[] probes = {lunokhod, apollo, sojourner, sputnik};

            // Q5
            /*
            foreach (Object o in probes)
            {
              Console.WriteLine($"Tracking a {o.GetType()}...");
            }
            */

            // Q8 - its best to use interface as the polymorphious instead of superclass! IDirectable[] is the way to go!
            IDirectable[] directable = { lunokhod, apollo, sojourner, sputnik };
            // Q9
            DirectAll(directable);

            // Q10 - second challenge to use superclass instead of interface
            Probe[] probes = { lunokhod, apollo, sojourner, sputnik };
            Console.WriteLine();
            DirectProbes(probes);

        }

        // Q9 update Rover[] to IDirectable[] - interface is better to use as polymorphious!
        public static void DirectAll(IDirectable[] directable)
        { // Q2
            foreach (IDirectable d in directable)
            {
                Console.WriteLine(d.GetInfo());
                Console.WriteLine(d.Explore());
                Console.WriteLine(d.Collect());
            }
        }

        // Q10 using the superclass Probe[]
        public static void DirectProbes(Probe[] probes)
        {
            foreach (Probe p in probes)
            {
                Console.WriteLine(p.GetInfo());
                Console.WriteLine(p.Explore());
                Console.WriteLine(p.Collect());
            }
        }
    }
}
