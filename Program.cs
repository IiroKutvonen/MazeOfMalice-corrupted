using System;

namespace MazeOfMalice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character chr = new Character();
            //Monster m1 = new Monster();
            //Character chr2 = new Monster();
            Room Room1 = new Room("Eka huone");
            Console.WriteLine(Room1.ToString());
            Console.ReadKey();
        }
    }
}
