namespace IteratorPattern_Example
{
    class Aircraft
    {
        public string Brand;
        public string Model;
        public int releaseDate;
        public bool inService;

        public Aircraft(string _brand, string _model, int _releaseDate, bool _inService)
        {
            this.Brand = _brand;
            this.Model = _model;
            this.releaseDate = _releaseDate;
            this.inService = _inService;
        }
    }
}
