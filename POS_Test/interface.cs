using System;
using System.Collections.Generic;
using System.Text;

namespace Pos_Test
{
    class @Interface
    {
        public void ModeMenu()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nPOS Program ...\n");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nPlease Choose Mode ! ");
            Console.WriteLine("\n\n  1.Check bill");
            Console.WriteLine("  2.Add Product");
            Console.WriteLine("-----------------------");
        }

        public void CheckbillMenu()
        {

            var products1 = new Product()
            {
                id = "P01",
                name = "iPad Pro 11-inch",
                price = 23900
            };

            var products2 = new Product()
            {
                id = "P02",
                name = "Apple Watch Series 4",
                price = 14400
            };

            var products3 = new Product()
            {
                id = "P03",
                name = "MacBook Pro with Touch Bar",
                price = 47900
            };

            var products4 = new Product()
            {
                id = "P04",
                name = "Apple TV 4K",
                price = 8500
            };
            var products5 = new Product()
            {
                id = "P05",
                name = "iPhone XS",
                price = 39900
            };

            var products6 = new Product()
            {
                id = "P06",
                name = "iPhone XS Max",
                price = 43900
            };
            var products7 = new Product()
            {
                id = "P07",
                name = "iPhone XR",
                price = 29900
            };

            var products8 = new Product()
            {
                id = "P08",
                name = "MacBook Air 13-inch",
                price = 42900
            };
            var products9 = new Product()
            {
                id = "P09",
                name = "Mac Mini 2018",
                price = 27900
            };
            var newproduct = new Addproduct();

            string chooseProduce = "";
            string exit = "no";
            string name = "";
            double subtotal = 0.00;
            double discount = 0.00;
            double total = 0.00;
            int count = 1;
            int countx = 0;

            do
            {
                Console.WriteLine("\n Product List");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("SKU  | Name                       | Price");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products1.id, products1.name) + "| " + products1.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products2.id, products2.name) + "| " + products2.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products3.id, products3.name) + "| " + products3.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products4.id, products4.name) + "| " + products4.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products5.id, products5.name) + "| " + products5.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products6.id, products6.name) + "| " + products6.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products7.id, products7.name) + "| " + products7.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products8.id, products8.name) + "| " + products8.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", products9.id, products9.name) + "| " + products9.price);
                Console.WriteLine(string.Format("{0,-4} | {1,-26} ", newproduct.id, newproduct.name) + "| " + newproduct.price);
                Console.WriteLine("-----------------------------------------------------------");



                Console.WriteLine("\n Product in your cart are ");
                Console.WriteLine(name);
                Console.WriteLine(" ---");
                Console.WriteLine(" Subtotal : " + subtotal + "  Bath");
                Console.WriteLine(" Discount : " + discount + "  Bath");
                Console.WriteLine(" Total due : " + total + "  Bath");
                Console.Write("Please input a product key (Enter 'no' for exit program ): ");
                chooseProduce = Console.ReadLine();
                if (chooseProduce == "p01")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products1.name + "    " + products1.price;
                    Console.Write("." + products1.name);
                    subtotal = subtotal + products1.price;
                    total = total + products1.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products1.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p02")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products2.name + "    " + products2.price;
                    Console.WriteLine(products2.price);
                    subtotal = subtotal + products2.price;
                    total = total + products2.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products2.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p03")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products3.name + "    " + products3.price;
                    Console.WriteLine("." + products3.name);
                    subtotal = subtotal + products3.price;
                    total = total + products3.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products3.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p04")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products4.name + "    " + products4.price;
                    Console.WriteLine("." + products4.name);
                    subtotal = subtotal + products4.price;
                    total = total + products4.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products4.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p05")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products5.name + "    " + products5.price;
                    Console.WriteLine("." + products5.name);
                    subtotal = subtotal + products5.price;
                    total = total + products5.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products5.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p06")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products6.name + "    " + products6.price;
                    Console.WriteLine("." + products6.name);
                    subtotal = subtotal + products6.price;
                    total = total + products6.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products6.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p07")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products7.name + "    " + products7.price;
                    Console.WriteLine("." + products7.name);
                    subtotal = subtotal + products7.price;
                    total = total + products7.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products7.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p08")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products8.name + "    " + products8.price;
                    Console.WriteLine("." + products8.name);
                    subtotal = subtotal + products8.price;
                    total = total + products8.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products8.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce == "p09")
                {
                    Console.Write(count);
                    name = name + "\n" + count + "." + products9.name + "    " + products9.price;
                    Console.WriteLine("." + products9.name);
                    subtotal = subtotal + products9.price;
                    total = total + products9.price;
                    count++;
                    countx++;
                    if (countx == 4)
                    {
                        countx = 1;
                        discount = discount + products9.price;
                        total = subtotal - discount;
                    }
                }
                else if (chooseProduce != products1.id || chooseProduce != products2.id || chooseProduce != products3.id || chooseProduce != products4.id || chooseProduce != products5.id || chooseProduce != products6.id || chooseProduce != products7.id || chooseProduce != products8.id || chooseProduce != products9.id || chooseProduce != exit)
                {
                    Console.WriteLine("Error !!");
                    Console.WriteLine("Not have this item !");
                    Console.Write("Please Enter any key to continus");
                    string i = Console.ReadLine();
                }
                Console.Clear();
            } while (chooseProduce != exit);

        }


    }
}
