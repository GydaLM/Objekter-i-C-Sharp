//using ObjekterFraJSiCSharp;
//This line has to be above the code.
//Main();
//static void Main()
//{
//    var Pikachu = new PikachuStats { };
//    Console.WriteLine($"Pikachu's Health: {Pikachu.Health} and Pikachu's Level: {Pikachu.Level}");
//}
//Either way works, as long as the two files are connected.

namespace ObjekterFraJSiCSharp
{
    class Program
    {
        //This method has to be named Main()
        static void Main()
        {
            //This is the ObjekterFraJSiCSharp code
            var Pikachu = new PikachuStats();
            Console.WriteLine($"Pikachu's Health: {Pikachu.Health} and Pikachu's Level: {Pikachu.Level}");

            //This is the KlasserOgProperties code
                //Pokemon is a data type we create to let the compiler know exactly what information is in the variable
                //when you use var the compiler guesses, can see if you hoover over in Visual Studio
            Pokemon Pokemon1 = new Pokemon("Charmander", 55, 19);
            var Pokemon2 = new Pokemon("Bulbasaur", 33, 10);
            //This way if there is no constructor, the constructor is the "Pokemon()" method in the pokemon class
            //myPokemon.Name = "Charmander";
            //myPokemon.Health = 55;
            //myPokemon.Level = 19;
            Console.WriteLine($"Pokemon: {Pokemon1.Name}\nHealth: {Pokemon1.Health}\nLevel: {Pokemon1.Level}");
            Console.WriteLine($"Pokemon: {Pokemon2.Name}\nHealth: {Pokemon2.Health}\nLevel: {Pokemon2.Level}");
        }
    }
}


