namespace Decision_Structures_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle;
            int time;
            Console.WriteLine("Hello, welcome to the Compass app");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Please enter your angle: ");
                while (!double.TryParse(Console.ReadLine(), out angle))
                    Console.WriteLine("Invalid number, please try again:");
                angle = Math.Round(angle, 2);
              
                Console.WriteLine("Please press enter to contune: ");
                Console.ReadLine();
                Console.Clear();
                compass(angle);

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please press enter to contune: ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Welcome to Garage Parking Cost calculator or GPCC!");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press enter to contune:");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please input your time parked: ");
                while (!Int32.TryParse(Console.ReadLine(), out time))
                    Console.WriteLine("Invalid number, please try again:");
                Console.WriteLine();
                Console.WriteLine("Press enter to contune:");
                Console.ReadLine();
                Console.Clear();
                garageCost(time);
            }

        }


        static void compass(double compassAngle)
        {
            if (compassAngle <= 45 || compassAngle >= 315)
            {
                
                if (compassAngle > 360)
                {
                    Console.WriteLine("INVALID, try again!");
                }
                else
                {
                    Console.WriteLine("North");
                }
            }
            else if (compassAngle <= 135)
            {
                Console.WriteLine("East");
            }
            else if (compassAngle <= 225)
            {
                Console.WriteLine("South");
            }
            
            else
            {
                Console.WriteLine("West");
            }

        }
        static void garageCost(int garageCost)
        {
            double totalCost;
            Thread.Sleep(3000);
            if (garageCost <= 60)
            {
                totalCost = 4.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 60 && garageCost < 120)
            {
                totalCost = 6.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 120 && garageCost < 180)
            {
                totalCost = 8.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 180 && garageCost < 200)
            {
                totalCost = 10.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 200 && garageCost < 260)
            {
                totalCost = 12.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 260 && garageCost < 320)
            {
                totalCost = 14.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 320 && garageCost < 380)
            {
                totalCost = 16.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 380 && garageCost < 440)
            {
                totalCost = 18.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else if (garageCost > 440 && garageCost < 500)
            {
                totalCost = 20.00;
                Console.WriteLine("You parked for " + garageCost + " so your cost will be " + totalCost.ToString("c"));

            }
            else
            {

            }
        }
    }
}
