namespace doviz
{
    class Program
    {
        static void Main()
        {
            string yesOrno=(""); 
            do{
                        const decimal goldvalue1ginDollar=1983; //USD $
            Console.WriteLine("\nWelcome to exchanging program in .Net framework");
            Console.WriteLine("What do you have: \n1.Gold\n2.Dollor");
            int choosednumber= int.Parse(Console.ReadLine()!);
            
            switch(choosednumber)
            {
                case 1: 
                    Console.WriteLine("How much do you have");
                    decimal goldOfyou= Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Your gold is {goldOfyou*goldvalue1ginDollar}$ in USA dollar");
                    break;
                
                case 2:
                    Console.WriteLine("How much do you have");
                    decimal dollorOfyou= Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Your gold is {dollorOfyou/goldvalue1ginDollar}g in gram of Gold");
                    break;

                default:
                    Console.WriteLine("Sorry, you entered invalid input,\nTry again later");
                    break;
            }
            Console.Write("Do you want to continue [y/n]: "); 
            yesOrno=Console.ReadLine()!; 
            }while(yesOrno=="y");
        }
    }
}