using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HomeWork4_CatShop__
{
   internal  class CatHouse
    {
        public CatHouse() { }
        public CatHouse(Cat[]? cats)
        {
            Cats = cats;
            if (cats != null) { CatCount = cats.Length; }
            else CatCount = 0;
        }

        public Cat[]? Cats { get; set; } = default;
        public double TotalMass { get; set; } = default;
        public double TotalConsume { get; set; } = default;
        public int CatCount { get; set; } = default;

        public void AddCat(Cat cat)
        {
            Cat[] temp = new Cat[++CatCount];
            if (Cats != null)
            {
                Cats.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = cat;
            Cats = temp;
            Console.WriteLine("Cat Added Successfully...");
        }
        public double GetTotalMass()
        {
            foreach (var cat in Cats)
            {
                TotalMass += cat.Mass;
            }
            return TotalMass;
        }
        public double GetTotalConsume()
        {
            foreach (var cat in Cats)
            {
                TotalConsume += cat.FoodConsume;
            }
            return TotalConsume;
        }
        public void ShowCats()
        {
            int id = 0;
            Console.WriteLine("\t\t= = = Cats = = =\n\n");
            foreach (var cat in Cats)
            {
                Console.WriteLine($"{++id} . Cat Info ");
                cat.ShowCatCondition();
                Console.WriteLine("\n\n");
            }
            Console.WriteLine();
        }

        public Cat GetCat()
        {
            Console.Write("Enter cat breed : ");
            string? breed = Console.ReadLine();
            Console.Write("Enter cat mass : ");
            double mass = Convert.ToDouble(Console.ReadLine());
            return new Cat(breed, mass);
        }

        public void ShowConsumes()
        {
            int id = 0;
            Console.WriteLine("\t\t = = = Cats Consumes = = =\n\n");
            foreach (var cat in Cats)
            {
                Console.WriteLine($"{++id} . {cat.Breed} Cat Food Consume : {cat.FoodConsume} kcal");
            }
        }
    }
}
