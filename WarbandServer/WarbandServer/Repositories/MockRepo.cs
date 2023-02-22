using WarbandServer.Models;

namespace WarbandServer.Repositories
{
    public class MockRepo
    {


        private List<Warband> Warbands { get; set; }

        private MockRepo()
        {
            Warbands = new List<Warband>();
        }

        public static MockRepo Instance { get; } = new MockRepo();

        public List<Warband> GetWarbands()
        {
            return Warbands;
        }
        public void AddWarband(Warband warband)
        {
            Warbands.Add(warband);
        }
    }
}
