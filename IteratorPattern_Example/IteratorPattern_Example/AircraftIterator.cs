//With this iterator class we are going to get the datas from our data pool
//which we mentioned as Aggregate class named as Aircrafts class.
//We ill look for the datas which located inside the Aircrafts class
//Via Iterator class.

namespace IteratorPattern_Example
{
    class AircraftIterator : IIterator
    {
        Aircrafts acs;
        int ac_index = 0;

        public AircraftIterator(Aircrafts _acs)
        {
            this.acs = _acs;
        }

        public Aircraft getCurrentAircraft()
        {
            return acs.getAircraft(ac_index);
        }

        public Aircraft getNextAircraft()
        {
            if (ac_index < acs.getAircraftCount())
            {
                ac_index++;
                return acs.getAircraft(ac_index);
            }
            else
                return null;
        }
    }
}
