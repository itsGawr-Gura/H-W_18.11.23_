namespace Homework
{
    public class Building
    {
        protected int _id;
        protected double _square;
        protected int _floors;
        protected string _address;

        public Building(int id, double square, int floors, string address)
        {
            _id = id;
            _square = square;
            _floors = floors;
            _address = address;
        }

        public int GetId()
        {
            return _id;
        }

        public double GetSquare()
        {
            return _square;
        }

        public int GetFloors()
        {
            return _floors;
        }

        public string GetAddress()
        {
            return _address;
        }
    }
}