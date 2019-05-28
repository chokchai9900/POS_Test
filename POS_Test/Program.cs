using System;

namespace Pos_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var @Interface = new @Interface();
            var Addproduct = new Addproduct();
            string continus = "";
            do
            {
                @Interface.ModeMenu();
                Console.Write("Enter number for Your Choose : ");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("\nYou Choose Mode " + input);
                if (input == 1)
                {
                    Console.Clear();
                    @Interface.CheckbillMenu();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Addproduct.Add();
                }
                Console.Write("Do you want to continus ? (y / n)");
                continus = Console.ReadLine();
            } while (continus == "y");
            Console.WriteLine("GoodBye !!");


        }
    }
}
