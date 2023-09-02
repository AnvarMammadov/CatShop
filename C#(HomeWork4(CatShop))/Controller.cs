using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HomeWork4_CatShop__
{
    internal class App
    {
        public static void Start()
        {
            Cat c1 = new Cat("Mixed-Breed", 3);
            Cat c2 = new Cat("British-Shorthair", 5);
            Cat c3 = new Cat("Turkish-Van", 4.2);
            Cat c4 = new Cat("American-Wireahair", 5.3);
            Cat c5 = new Cat("Savannah", 3.6);

            CatHouse catHouse1 = new CatHouse(new Cat[] { c1, c3 });
            CatHouse catHouse2 = new CatHouse(new Cat[] { c2, c4, c5 });

            CatShop catShop = new CatShop("Miyoo Cat Shop", new CatHouse[] { catHouse1, catHouse2 });
            while (true)
            {
                MyClear();
                Console.WriteLine($"\t\t\t{catShop.Name}\n\n");
                Console.WriteLine("Cat       [1]");
                Console.WriteLine("Operation [2]");
                Console.WriteLine("Exit Shop [0]\n\n");
                int choice = Convert.ToInt16(Console.ReadLine());
                MyClear();
                if (choice == 1)
                {
                    while (true)
                    {
                        MyClear();
                        Console.WriteLine("\nShow Cat Condition  [1]");
                        Console.WriteLine("Show Cat Eating     [2]");
                        Console.WriteLine("Show Cat Playing    [3]");
                        Console.WriteLine("Show Cat Sleeping   [4]");
                        Console.WriteLine("Back                [0]");
                        int choos1 = Convert.ToInt16(Console.ReadLine());
                        MyClear();
                        if (choos1 == 1)
                        {
                            int id = 0;
                            foreach (var catHouse in catShop.CatHouses)
                            {
                                Console.Write($"\t\t{++id} . Cat House \n"); catHouse.ShowCats();
                                Console.WriteLine("\n\n");
                            }
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos1 == 2)
                        {
                            int idHouse = 0;
                            foreach (var catHouse in catShop.CatHouses)
                            {
                                int id = 0;
                                Console.WriteLine($"\t\t{++idHouse} Cat House\n");
                                foreach (var cat in catHouse.Cats)
                                {
                                    Console.WriteLine($"{++id} Cat : "); cat.Eat(); Console.WriteLine("\n");
                                    Console.WriteLine("Please wait..."); Thread.Sleep(1000);
                                }
                            }
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();

                        }
                        else if (choos1 == 3)
                        {
                            int idHouse = 0;
                            foreach (var catHouse in catShop.CatHouses)
                            {
                                int id = 0;
                                Console.WriteLine($"\t\t{++idHouse} Cat House\n");
                                foreach (var cat in catHouse.Cats)
                                {
                                    Console.WriteLine($"{++id} Cat : "); cat.Play(); Console.WriteLine("\n");
                                    Console.WriteLine("Please wait..."); Thread.Sleep(1000);
                                }
                            }
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos1 == 4)
                        {
                            int idHouse = 0;
                            foreach (var catHouse in catShop.CatHouses)
                            {
                                int id = 0;
                                Console.WriteLine($"\t\t{++idHouse} Cat House\n");
                                foreach (var cat in catHouse.Cats)
                                {
                                    Console.WriteLine($"{++id} Cat : "); cat.Sleep(); Console.WriteLine("\n");
                                    Console.WriteLine("Please wait..."); Thread.Sleep(1000);
                                }
                            }
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos1 == 0) { MyClear(); break; }
                        else
                        {
                            MyClear(); Console.WriteLine("This operation can not find..."); Console.Write("Please tap to any key : ");
                            Console.ReadLine(); break;
                        }
                    }
                }
                else if (choice == 2)
                {
                    while (true)
                    {
                        MyClear();
                        Console.WriteLine("Show All Cats                [1]");
                        Console.WriteLine("Show Cat Houses              [2]");
                        Console.WriteLine("Show All Cat Food Consumed   [3]");
                        Console.WriteLine("Show All Cat Mass            [4]");
                        Console.WriteLine("Add Cat to Cat House         [5]");
                        Console.WriteLine("Add CatHouse to CatShop      [6]");
                        Console.WriteLine("Back                         [0]");
                        int choos2 = Convert.ToInt16(Console.ReadLine());
                        MyClear();
                        if (choos2 == 1)
                        {
                            foreach (var catHouse in catShop.CatHouses)
                            {
                                catHouse.ShowCats();
                            }
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos2 == 2)
                        {
                            catShop.ShowCatHouse();
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos2 == 3)
                        {
                            catShop.ShowConsumes();
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos2 == 4)
                        {
                            Console.WriteLine($"All Cats Mass : {catShop.GetTotalMassAllCats()} ");
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos2 == 5)
                        {
                            Random randomIndex = new Random();
                            int rCat = randomIndex.Next(0, catShop.CatHousesCount);
                            Cat newCat = catShop.CatHouses[rCat].GetCat();
                            catShop.CatHouses[rCat].AddCat(newCat);
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos2 == 6)
                        {
                            CatHouse newCatHouse = catShop.GetCatHouse();
                            catShop.AddCatHouse(newCatHouse);
                            Console.Write("Please tap to any key : ");
                            Console.ReadLine();
                            MyClear();
                        }
                        else if (choos2 == 0) { MyClear(); break; }
                        else
                        {
                            MyClear();
                            Console.WriteLine("This operation can not find..."); Console.Write("Please tap to any key : ");
                            Console.ReadLine(); break;
                        }
                    }
                }
                else if (choice == 0) { MyClear(); break; }
                else
                {
                    MyClear(); Console.WriteLine("This operation can not find..."); Console.Write("Please tap to any key : ");
                    Console.ReadLine(); break;
                }
            }
        }
        public static void MyClear()
        {
            Console.Clear(); Console.WriteLine("\x1b[3J");
        }
    }
}
