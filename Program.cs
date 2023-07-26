namespace doviz
{
    class Program
    {
        static void Main()
        {
            const decimal goldvalue1ginDollar=1983; //USD $
            Console.WriteLine("\nWelcome to exchanging program in .Net framework");
            Console.WriteLine("What do you have: \n1.Gold\n2.Dollor"); // You should choose one that you have: Dollar or Gold
            int choosednumber= int.Parse(Console.ReadLine()!);
            
            switch(choosednumber)
            {
                case 1: 
                    Console.WriteLine("How much do you have");
                    decimal goldOfyou= Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\nConverting to gold...\n");
                    Console.WriteLine($"Your gold is {goldOfyou*goldvalue1ginDollar}$\n");
                    break;
                
                case 2:
                    Console.WriteLine("How much do you have");
                    decimal dollorOfyou= Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\nConverting to gold...\n");
                    Console.WriteLine($"Your dollar is {dollorOfyou/goldvalue1ginDollar}gram Gold\n");
                    break;
                default :
                    Console.WriteLine("Sorry , you entered invalid input\nTry again later");
                    break;
            };
        }
    }
}