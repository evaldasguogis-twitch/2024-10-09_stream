// From https://learn.microsoft.com/en-us/visualstudio/debugger/debugging-absolute-beginners?view=vs-2022&tabs=csharp

// Expected Output:
//  Tadpole  400,  Spiral
//  Pinwheel  25,  Spiral
//  Cartwheel, 500,  Lenticular
//  Small Magellanic Cloud 0.2,  Irregular
//  Andromeda  3,  Spiral
//  Maffei 1,  11,  Elliptical

//NOTES: Quick Watch, Add Watch
namespace _02_galaxies_debugging
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Galaxy> theGalaxies = new List<Galaxy>();

            theGalaxies.Add(new Galaxy("Tadpole", 400, new GType('S')));
            theGalaxies.Add(new Galaxy("Pinwheel", 25, new GType('L')));
            theGalaxies.Add(new Galaxy("Small Magellanic Cloud", 0.2, new GType('I')));
            theGalaxies.Add(new Galaxy("Andromeda", 3, new GType('S')));
            theGalaxies.Add(new Galaxy("Maffei 1", 11, new GType('E')));

            Console.WriteLine("Welcome to Galaxy News!");
            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType);
            }
            Console.ReadKey();
        }
    }

    public class Galaxy
    {
        public string Name { get; set; }

        public double MegaLightYears { get; set; }
        public object GalaxyType { get; set; }

        public Galaxy(string name, double megaLightYears, object galaxyType)
        {
            Name = name;
            MegaLightYears = megaLightYears;
            GalaxyType = galaxyType;
        }
    }

    public enum Type { Spiral, Elliptical, Irregular, Lenticular }

    public class GType
    {
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'l':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }
        public object MyGType { get; set; }

    }
}
