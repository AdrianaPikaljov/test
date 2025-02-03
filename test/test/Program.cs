namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number control");

            int number = 180;

            //kontrollitakse kas arv on suurem 189-st
            if (number > 189)
            {
                //kui  if vastab tingimustele, siis naitab konsoolis seda arvu
                Console.WriteLine("number is bigger");

                //if ja esle testimine
                if (number >=190 && number <= 200)
                {
                    Console.WriteLine("number is between 190 to 200");
                }
                else
                {
                    Console.WriteLine("number is bigger than 200");
                }
            }
            else
            {
                Console.WriteLine("number is smaller");
            }
        }
    }
}
