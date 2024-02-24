namespace TravelTimeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            string YorN = "y";
            decimal miles;
            decimal milesPerHour;
            decimal travelTime;
            int hours;
            decimal fractionMinutes;
            int minutes;
            YorN = YorN.ToUpper();
            while (YorN.Equals("Y"))
                {
                Console.Write("Enter Miles: ");
                string MILES = Console.ReadLine();
                Console.WriteLine();
                miles = Convert.ToDecimal(MILES);
                Console.Write("Enter miles per hour: ");
                string MilesPerHr = Console.ReadLine();
                milesPerHour = Convert.ToDecimal(MilesPerHr);
                Console.WriteLine();

                travelTime = (miles * 60) / milesPerHour;
                int Hours = (int)(travelTime / 60);

                minutes = (int)(travelTime % 60);
                Console.WriteLine("Hours :" + Hours);
                Console.WriteLine($"Minutes are : {minutes} ");
                Console.WriteLine("Continue Y/N ?");
                string choice = Console.ReadLine();
                choice = choice.ToUpper();
                Boolean success = false;
                while (!success)
                {
                    if (choice.Equals("Y"))
                        {
                        success = true;
                        YorN = choice;
                        }
                    else if (choice.Equals("N")) {
                        success = true;
                        YorN = choice;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N");
                        choice = Console.ReadLine();
                        choice = choice.ToUpper();
                    }
                }

            }
            Console.WriteLine("Bye!");
        }
    }
}