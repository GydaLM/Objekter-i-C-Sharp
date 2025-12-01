
namespace ObjekterFraJSiCSharp
{
    public class Pokemon
    {
        public string Name;
        public int Health;
        public int Level;

        //Don't really know the difference between this and the one above yet
        //public string Name { get; set; }
        //public int Health { get; set; }
        //public int Level { get; set; }

        //This is the constructoren
        public Pokemon(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }
    }
}
