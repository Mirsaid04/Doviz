namespace doviz
{
    class Program
    {
        static void Main()
        {
            try{
            string yesOrno="";
            do{
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
                    Console.WriteLine($"Your dollar is {dollorOfyou/goldvalue1ginDollar}g Gold\n");
                    break;
                default :
                    Console.WriteLine("Sorry , you entered invalid input\nTry again later");
                    break;
            };
            Console.Write("Do you want to continue [y/n]: "); 
            yesOrno=Console.ReadLine()!; 
            }while(yesOrno=="y");
            }
            catch(FormatException FormatException)
            {
                Console.WriteLine("Oops,We could not convert your input value.");
                Console.WriteLine("Looks like the value you provided is not integer");
            }
            catch(OverflowException OverflowException)
            {
                Console.WriteLine("Value you provided was either too large or too small. ");
            }
            catch(Exception exception)
            {
                Console.WriteLine("Opps,something went wrong , contact support");
            }
        }
    }
}