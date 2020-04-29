using System;

namespace IteratorPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Iterator Pattern Example - Thecodeprogram";

            //First create our aggregate class.
            //I created Aircrafts class for this purpose. This class will keep all 
            //Datas as you can see below.
            Aircrafts aircrafts = new Aircrafts();
            aircrafts.addAircraft(new Aircraft("Boeing", "787", 2011, true));
            aircrafts.addAircraft(new Aircraft("Boeing", "777", 1994, true));
            aircrafts.addAircraft(new Aircraft("Boeing", "747", 1974, true));
            aircrafts.addAircraft(new Aircraft("Boeing", "737", 1948, true));
            aircrafts.addAircraft(new Aircraft("Boeing", "707", 1927, false));
            aircrafts.addAircraft(new Aircraft("Airbus", "A320", 1975, true));
            aircrafts.addAircraft(new Aircraft("Airbus", "A330", 1995, true));
            aircrafts.addAircraft(new Aircraft("Airbus", "A340", 1980, true));
            aircrafts.addAircraft(new Aircraft("Airbus", "A350", 2000, true));

            //Now we have to create our iterator here
            //With this iterator we are going to write
            //all datas inside the aircrafts class which is our data pool.
            AircraftIterator ac_iterator = new AircraftIterator(aircrafts);
            while (ac_iterator.getNextAircraft() != null)
            {
                Console.WriteLine(
                    "Model: " + ac_iterator.getCurrentAircraft().Brand +
                    " Brand: " + ac_iterator.getCurrentAircraft().Model +
                    " Release Year: " + ac_iterator.getCurrentAircraft().releaseDate +
                    " In Service?: " + ac_iterator.getCurrentAircraft().inService);
            }

            Console.ReadLine();

        }
    }
}
