using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using In = NBCC_WMAD_Console.Input;
using Out = NBCC_WMAD_Console.Output;

namespace NBCC_WMAD_Console
{
    class Program
    {
        /// <summary>
        /// Menu Items are added here
        /// </summary>
        private static void LoadMenu()
        {
            Menu.menuDictionary.Add(0, "Exit");
            Menu.menuDictionary.Add(1, "About the Console");
            Menu.menuDictionary.Add(2, "Car Builder");
        }

        static void Main(string[] args)
        {
            string choice = Init();

            while (choice.ToLower() == "y")
            {
                switch (In.Get<int>(Menu.CreateMenu(), ConsoleColor.Yellow))
                {
                    case 0:
                        choice = "n";
                        break;
                    case 1:
                        AboutThisApp();
                        break;
                    //Add more options in the menu here
                    case 2:
                        CarBuilder();
                        break;
                }
            }

            Out.P("Press any key to exit.");
            Console.ReadLine();
        }


        #region [My Functionality]

        /*
         * My methods will be added here for executing functionality within the console
         */
         //store the created cars in a List
        static List<Car> myCars = new List<Car>();

        private static void CarBuilder()
        {
            string userCarType = In.GetString("Provide a car type (ie Car, Truck, Van: \n");
            int userNumberOfDoors = In.GetInt("Provide the number of doors: \n");
            int userCarSpeed = In.GetInt("Provide the car speed: ");

            Car car = new Car();

            car.CarType = userCarType;
            car.NumberOfDoors = userNumberOfDoors;
            car.Speed = userCarSpeed;

            Out.P("------------- \n");

            Out.P($"The Car created is: \nType: {car.CarType} \nNumber of doors: {car.NumberOfDoors} \n" +
                $"Speed: {car.Speed}\nPrice: {car.Price.GetValueOrDefault()}\n");

            Out.P("------------- \n");

            myCars.Add(car);

            Out.P($"I have {myCars.Count} cars in my list.");

            string entry = In.GetString("Do you want to list all cars? y or n");
            if(entry == "y")
            {
                for(int i = 0; i<myCars.Count; i++)
                {
                    Out.P($"Car number: {i + 1} \nCar Type: {myCars[i].CarType}\nNumber of doors: {myCars[i].NumberOfDoors}\n" +
                        $"Speed: {myCars[i].Speed}\nPrice: {myCars[i].Price.GetValueOrDefault().ToString("c")}\n");
                }
            }
            else
            {
                return;
            }

        }

        #endregion

        /// <summary>
        /// The About this App
        /// </summary>
        private static void AboutThisApp()
        {
            Out.P("\n");
            Out.P("This app is the Console Root Application. Build on it by providing new menu items and adding to the switch statement");
            Out.P("\n");
        }
        
        /// <summary>
        /// Initialize the Console
        /// </summary>
        /// <returns></returns>
        private static string Init()
        {
            LoadMenu();
            string choice = "y";
            Logo.CreateLogo("The Root App");
            return choice;
        }
    }
}
