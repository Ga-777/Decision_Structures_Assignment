namespace Decision_Structures_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle;
            int time;
            Console.WriteLine("Hello, welcome to the Compass app");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter your angle: ");
                while (!double.TryParse(Console.ReadLine(), out angle))
                    Console.WriteLine("Invalid number, please try again:");
                angle = Math.Round(angle, 2);

                Console.WriteLine("Please press enter to continue: ");
                Console.ReadLine();
                Console.Clear();
                compass(angle);

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please press enter to continue: ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome to Garage Parking Cost calculator or GPCC!");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press enter to continue:");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please input your time parked: ");
                while (!Int32.TryParse(Console.ReadLine(), out time))
                    Console.WriteLine("Invalid number, please try again:");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue:");
                Console.ReadLine();
                Console.Clear();
                garageCost(time);
            }
            for (int i = 0; i < 10; i++)
            {
                int category;
                Console.Clear();
                Console.WriteLine("Hurricane Speed/Wind App or HSWA");
                Thread.Sleep(1000);
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Pick a category of the hurricane:");
                Console.WriteLine("");
                while (!Int32.TryParse(Console.ReadLine(), out category))
                    Console.WriteLine("Invalid number, please try again:");
                Thread.Sleep(1000);

                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                hurricaneCategory(category);
            }

        }


        static void compass(double compassAngle)
        {
            Thread.Sleep(3000);
            if (compassAngle <= 45 || compassAngle >= 315)
            {

                if (compassAngle > 360)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("INVALID, try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                else if (compassAngle < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("INVALID, try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("North");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
            }
            else if (compassAngle <= 135)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("East");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            else if (compassAngle <= 225)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("South");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            else if (compassAngle <= 315)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("West");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            else
            {

                Console.WriteLine("INVALID");
                Console.WriteLine("");

            }

        }
        static void garageCost(int garageCost)
        {
            double totalCost;
            Thread.Sleep(3000);
            if (garageCost <= 60)
            {
                totalCost = 4.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 60 && garageCost <= 120)
            {
                totalCost = 6.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 120 && garageCost <= 180)
            {
                totalCost = 8.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 180 && garageCost <= 200)
            {
                totalCost = 10.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 200 && garageCost <= 260)
            {
                totalCost = 12.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 260 && garageCost <= 320)
            {
                totalCost = 14.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 320 && garageCost <= 380)
            {
                totalCost = 16.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 380 && garageCost <= 440)
            {
                totalCost = 18.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (garageCost >= 440 && garageCost <= 500)
            {
                totalCost = 20.00;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You parked for " + garageCost + " mins so your cost will be " + totalCost.ToString("c"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID PARKING TIME, please try again.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void hurricaneCategory(int category)
        {
            Thread.Sleep(3000);

            switch (category)
            { 
            
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Category 1: Winds 74-95 mph or 64-82 Kt or 119-153 km/hr, Minimal damage.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Category 2: Winds 96-110 mph or 83-95 Kt or 154-177 km/hr, Moderate damage.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Category 3: Winds 111-129 mph or 96-113 Kt or 178-209 km/hr, Extensive damage!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Category 4: Winds 130-156 mph or 114-135 Kt or 210-249 km/hr, Extreme damage!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Category 5: Winds greater than 157 mph or 135 Kt or 249 km/hr, Catastrophic damage!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID CATEGORY, please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;



            }
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            

        }
    }
}
