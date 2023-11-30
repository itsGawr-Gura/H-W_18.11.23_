namespace Homework
{
    public class Creator
    {
        private static Dictionary<int, Building> _buildings = new Dictionary<int, Building>();

        private Creator() { }

        public static Building CreateBuilding(int id, double square, int floors, string address)
        {
            Building building = new Building(id, square, floors, address);
            _buildings.Add(id, building);
            return building;
        }

        public static bool DeleteBuilding(int id)
        {
            return _buildings.Remove(id);
        }
    }
}
