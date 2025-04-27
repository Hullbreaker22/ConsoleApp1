namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Big_carpet;
            int Small_carpet;
            double total;
            double Taxis;


            Console.WriteLine("*** Welcome in our project for washing Carpets!!");
            Console.WriteLine("NOTE, the price for small carpet is 25$ and  the big one is 35$\n");
            Console.WriteLine("Would you mind Enter how many Big carpets you would like to wash: ");
            Big_carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" what about the Small ones? ");
            Small_carpet = Convert.ToInt32(Console.ReadLine());

            Big_carpet = Big_carpet * 35;
            Small_carpet = Small_carpet * 25;

            total = Big_carpet + Big_carpet;
            Taxis = (total * 6 ) / 100;

            Console.WriteLine($"The total price for washing the carpets is:{total} and we are having Taxis for 6% so the Taxis will be {Taxis}");
            total = total + Taxis;
            Console.WriteLine($"The total Price after the Taxis is {total}\n");

            Console.WriteLine("***This Offer is Available just for 30 days only!!");

            Console.WriteLine("***It was a pleasure to Serivce you today wish to see you soon!");













        }
    }
}
