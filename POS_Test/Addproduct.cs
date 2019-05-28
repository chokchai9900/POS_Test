using System;
using System.Collections.Generic;
using System.Text;

namespace Pos_Test
{
    class Addproduct
    {
        public string id;
        public string name;
        public int price;

        public void Add()
        {
            {
                Console.WriteLine("Please Enter SKU , Name And Price for add product");
                var products10 = new Addproduct()
                {
                    id = "",
                    name = "",
                    price = 0
                };
                Console.Write("Enter SKU : ");
                products10.id = Console.ReadLine();
                Console.Write("Enter Name : ");
                products10.name = Console.ReadLine();
                Console.Write("Enter Price : ");
                products10.price = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("Your Product is : ");
                Console.Write("SKU : ");
                Console.WriteLine(products10.id);
                Console.Write("Name : ");
                Console.WriteLine(products10.name);
                Console.Write("Price : ");
                Console.WriteLine(products10.price);
            }

        }
    }
}
