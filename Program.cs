namespace doviz
{
    class Program
    {
        static void Main()
        {
           const decimal goldvalue1ginDollar=1983; //USD $
            System.Console.WriteLine("\nWelcome to exchanging program in .Net framework");
            System.Console.WriteLine("What do you have: \n1.Gold\n2.Dollor");
            int choosednumber= int.Parse(Console.ReadLine()!);
            
            switch(choosednumber)
            {
                case 1: 
                    System.Console.WriteLine("How much do you have");
                    decimal goldOfyou= Convert.ToDecimal(Console.ReadLine());
                    System.Console.WriteLine($"Your gold is {goldOfyou*goldvalue1ginDollar}$ in USA dollar");break;
                
                case 2:
                    System.Console.WriteLine("How much do you have");
                    decimal dollorOfyou= Convert.ToDecimal(Console.ReadLine());
                    System.Console.WriteLine($"Your gold is {dollorOfyou/goldvalue1ginDollar}g in gram of Gold");break;
            }
            // System.Console.WriteLine("If you have Gold and do you want to change it to Korean won?\nLet's gooo--->\n ");
            // System.Console.Write("How much Gold do you have in gram :");
            // decimal goldQuantity=Convert.ToDecimal(Console.ReadLine());
            // decimal koreanwon1gGold=2516264;

            // System.Console.WriteLine(goldQuantity*koreanwon1gGold);
            // System.Console.WriteLine("<--Thank you for your attention-->");
        }
    }
}