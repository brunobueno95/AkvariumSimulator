using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AkvariumSimulator
{
    internal class App
    {
        

        public App()
        {



        }



        public void RunApp()
        {
            User user = new User();

            Greetings();
            user.UserAquarium = MakeAquarium(ValidateChosenAquarium());
            GetSomeFishes(user.UserAquarium);
            GetSomePlants(user.UserAquarium);
            GetAFilter(user.UserAquarium);
            
        }

        public void Running()
        {
            while (true)
            {
                
            }
        }

        public void Greetings()
        {
            Console.WriteLine("Welcome to Aquarium Simulator");
            Console.WriteLine("Start choosing your aquarium dimensions");
            Console.WriteLine("1 - Height: 30cm Width 50 cm Depth: 20 cm out budget option");
            Console.WriteLine("2 - Height: 60cm Width 1 meter Depth: 60 cm our pro option");
            Console.WriteLine("3 OCEAN SIZE! 50M Width 100M Depth: 62M Out most expensive option!");
          
        }

        public int ValidateChosenAquarium() // could generelize this so that any text input choice could easily be made
        {
            while (true)
            {
               // try
               // {
               //     var userInput = Convert.ToInt32(Console.ReadLine());

               //         if(userInput >= 1 && userInput <= 3)
               //     {
               //         return userInput;
               //     }
               //         else
               //     {
               //         Console.WriteLine("Invalid Input, try again");
               //         continue;
               //     }
               // }
               //catch
               // {
               //     Console.WriteLine("Invalid Input, try again");
               //     continue;
               // }





                ConsoleKeyInfo UserInput = Console.ReadKey(true);
                if (Char.IsNumber(UserInput.KeyChar))
                {
                    string userInt = Convert.ToString(UserInput.KeyChar);
                    var converted = Convert.ToInt32(userInt);
                    if (converted >= 1 && converted <= 3)
                    {
                        return converted;
                    }
                }
                Console.WriteLine("Invalid Input, try again");

            }

        }

        private Aquarium MakeAquarium(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("making aquarium 1");
                    return new Aquarium(30, 50, 20);
                    //break;
                case 2:
                    Console.WriteLine("making aquarium 2");
                    return new Aquarium(60, 100, 50);
                default:
                    Console.WriteLine("making aquarium 3");
                    return new Aquarium(50000, 100000, 62000);

            }

            
                //if (input == 1)
                //{
                //Console.WriteLine("making aquarium");
                //    return new Aquarium(30, 50, 20);
                //}
                //else if (input == 2)
                //{
                //    return new Aquarium(60, 100, 50);
                //}
                //return new Aquarium(50000, 100000, 62000);

        }

        public void GetSomeFishes(Aquarium userAqua)
        {
            Console.WriteLine("You will get a random selection of fish by default");
            userAqua.AddFish(new VegetarianFish());
            userAqua.AddFish(new CarnivourFish());
            userAqua.AddFish(new CleanerFish());
            Console.ReadKey(true);

        }

        public void GetSomePlants(Aquarium userAqua)
        {
            Console.WriteLine("You get 3 plants by default");
            userAqua.addaPLant(new Plant(2, false));
            userAqua.addaPLant(new Plant(2, true));
            userAqua.addaPLant(new Plant(2, false));
            Console.ReadKey(true);
        }

        public void GetAFilter(Aquarium userAqua)
        {
            Console.WriteLine("You get one filter by default");
            userAqua.AddFilter(new Filter(5, 3));
            Console.ReadKey(true);
        }
        

      





    }
}
