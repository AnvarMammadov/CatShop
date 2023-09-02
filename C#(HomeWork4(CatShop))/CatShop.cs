using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HomeWork4_CatShop__
{
    internal class CatShop
    {
        public CatShop() { }
        public CatShop(string name, CatHouse[]? catHouses)
        {
            Name = name;
            CatHouses = catHouses;
            if (catHouses != null) { CatHousesCount = catHouses.Length; }
            else { CatHousesCount = 0; }
        }
        public string Name { get; set; } = "No Name";
        public CatHouse[]? CatHouses { get; set; } = default;
        public int CatHousesCount { get; set; } = default;
        private double TotalMassAllCats = default;
        private double TotalConsumeAllCats = default;


        public void AddCatHouse(CatHouse catHouse)
        {
            CatHouse[] temp = new CatHouse[++CatHousesCount];
            if (CatHouses != null)
            {
                CatHouses.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = catHouse;
            CatHouses = temp;
        }

        public double GetTotalMassAllCats()
        {
            foreach (var catHouse in CatHouses)
            {
                TotalMassAllCats += catHouse.TotalMass;
            }
            return TotalMassAllCats;
        }

        public double GetTotalConsumeAllCats()
        {
            foreach (var catHouse in CatHouses)
            {
                TotalConsumeAllCats += catHouse.TotalConsume;
            }
            return TotalConsumeAllCats;
        }

        public CatHouse GetCatHouse()
        {
            Cat[] cats = new Cat[0];
            Console.WriteLine("Cat House added successfully...");
            return new CatHouse(cats);
        }

        public void ShowConsumes()
        {
            Console.WriteLine("\t\t = = = All Food Consume in Cat Houses = = =\n\n");
            int id = 0;
            foreach (var catHouse in CatHouses)
            {
                Console.WriteLine($"\t= = ={++id} . Cat House = = =\n");
                Console.Write($"Consume Food in Cat House : "); catHouse.ShowConsumes();
                Console.WriteLine("\n\n");
            }
            Console.WriteLine($"Energy value of consumed foods in all cat houses : {GetTotalConsumeAllCats()}\n\n");
        }
        public void ShowCatHouse()
        {
            Console.WriteLine("\t\t = = = All Cat Houses = = = \n\n");
            int id = 0;
            foreach (var catHouse in CatHouses)
            {
                Console.WriteLine($"\t= = ={++id} . Cat House = = =\n");
                if (catHouse.CatCount > 0) { catHouse.ShowCats(); }
                else { Console.WriteLine("This cat house is empty..."); }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
