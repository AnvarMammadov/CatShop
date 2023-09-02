using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HomeWork4_CatShop__
{
    internal class Cat
    {
        public Cat() { }
        public Cat(string? breed, double mass)
        {
            Breed = breed;
            Mass = mass;
        }

        public string? Breed { get; set; } = "Mixed-Breed";
        public double Mass { get; set; } = default;
        public int Energy { get; set; } = 30;

        public double FoodConsume { get; set; } = default;

        private bool iAte = false;
        private bool iSlept = false;

        public bool isHungry()
        {
            if (Energy >= 50 && Energy < 75) return true;
            return false;
        }

        public bool isSleepless()
        {
            if (Energy < 50) return true;
            return false;
        }

        public void Eat()
        {

            if (isHungry())
            {
                int maxEnergy;
                if (iSlept) { maxEnergy = 100; }
                else { maxEnergy = 65; }
                while (true)
                {
                    if (Energy >= maxEnergy || Energy + 7 > 100) break;
                    Console.Clear();
                    Console.WriteLine($"{Breed} cat eating food ... ");
                    Energy += 7;
                    Mass += 0.009;
                    FoodConsume += 17.5;
                    Console.WriteLine($"Energy and Mass value gained by the {Breed} cat while EATING ...\n" +
                        $"Energy : {Energy} / 100 %\nMass :  {Mass.ToString("C3")} kg");
                    Thread.Sleep(400);
                }
                iAte = true;
                iSlept = false;
                Console.WriteLine($"{Breed} cat ate food");
            }
            else { Console.WriteLine($"{Breed} cat is full and cannot eat right now"); }
        }

        public void Sleep()
        {
            if (isSleepless())
            {
                int maxEnergy;
                if (iAte) { maxEnergy = 100; }
                else { maxEnergy = 70; }
                while (true)
                {
                    if (Energy >= maxEnergy || Energy + 4 > 100) break;
                    Console.Clear();
                    Console.WriteLine($"{Breed} cat sleeping ... ");
                    Energy += 4;
                    Mass -= 0.002;
                    Console.WriteLine($"Energy and Mass value gained by the {Breed} cat while SLEEPING ...\n" +
                        $"Energy : {Energy} / 100 %\nMass : {Mass.ToString("C3")} kg");
                    Thread.Sleep(400);
                }
                iSlept = true;
                iAte = false;
                Console.WriteLine($"{Breed} cat slept");
            }
            else { Console.WriteLine($"{Breed} cat is energetic and doesn't want to sleep"); }
        }

        public void Play()
        {
            if (isHungry() || isSleepless())
            {
                if (isHungry()) { Console.WriteLine($"{Breed} cat is HUNGRY right now, so it doesn't want to play"); }
                if (isSleepless()) { Console.WriteLine($"{Breed} cat is SLEEPLESS right now, so it doesn't want to play"); }
            }
            else
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"{Breed} cat is playing right now ...");
                    Energy -= 10;
                    Mass -= 0.008;
                    Console.WriteLine($"Energy and Mass value gained by the {Breed} cat while PLAYING ...\n" +
                       $"Energy : {Energy} / 100 %\nMass : {Mass.ToString("C3")} kg");
                    Thread.Sleep(700);
                    if (Energy <= 30 || Energy - 10 < 30) { Console.WriteLine($"{Breed} cat is TIRED and wants to SLEEP now "); break; }
                }
            }
            iSlept = false;
            iAte = false;
            Console.WriteLine($"{Breed} played");
        }

        public void ShowCatCondition()
        {
            Console.WriteLine("\t\t\t___Cat Condition___\n\n");
            Console.WriteLine($"Cat Breed  : {Breed}");
            Console.WriteLine($"Cat Mass   : {Mass.ToString("C3")} kg");
            Console.WriteLine($"Cat Energy : {Energy} %");  
            Console.WriteLine($"Cat energy value of the food consumed : {FoodConsume} kcal");
        }
    }
}
