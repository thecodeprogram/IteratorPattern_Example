using System.Collections.Generic;

namespace IteratorPattern_Example
{
    //This class is the collection class. We are going to keep all datas
    //inside this Aircrafts class. 
    //You can call this class as Aggregate class as term.
    //As you can see here we have a List and add merhod to the list.
    //Also we have another methods to make operations on a list array like get and count.
    class Aircrafts : IAggregate
    {
        List<Aircraft> aircrafts = new List<Aircraft>();
        int AircraftCount = 0;

        public void addAircraft(Aircraft _aircraft)
        {
            aircrafts.Add(_aircraft);
            //Always remember to start arrays from 0
            AircraftCount = aircrafts.Count-1;
        }

        public Aircraft getAircraft(int index)
        {
            return aircrafts[index];
        }

        public int getAircraftCount()
        {
            return AircraftCount;
        }

        public IIterator initializeIterator()
        {
            return new AircraftIterator(this);
        }
    }
}
