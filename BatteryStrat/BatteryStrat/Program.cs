namespace BatteryStrat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool inputCorrect = false;
            int i=-1;

            while (!inputCorrect) 
            {
                Console.WriteLine("Please provide the battery percentage (integer between 0 and 100):");

                String? input = Console.ReadLine();
                try
                {
                    i = Convert.ToInt32(input);
                    if (i<0 || i > 100)
                    {
                        throw new Exception("Incorrect number");
                    }
                    inputCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (Exception)
                {
                  
                }
            }

            Context context = new Context();

            if (i<15)
            {
                context.SetStrategy(new LowBattery());

            }
            else if (i > 85)
            {
                context.SetStrategy(new HighBattery());
            }
            else
            {
                context.SetStrategy(new MediumBattery());
            }

            context.PerformOperations();





        }
    }
}
