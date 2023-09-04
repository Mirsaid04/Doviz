namespace doviz
{
    class Program
    {
        static void Main()
        {
            try{
                string yesOrNo="";
            do{
                ShowMenu();
             int choosedNumber= int.Parse(Console.ReadLine()!);
            
            switch(choosedNumber)
            {
                case 1: 
                    GoldToDollorConverter();
                    break;
                
                case 2:
                    DollorToGoldConverter();
                    break;
                default :
                    LastReport();
                    break;
            };
            Console.Write("Do you want to continue [y/n]: "); 
            yesOrNo=Console.ReadLine()!; 
            }while(yesOrNo=="y");
            Reporter();
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

        public static void ShowMenu()
        {
            Console.WriteLine("\nWelcome to exchanging program in .Net framework");
            Console.WriteLine("What do you have: \n1.Gold\n2.Dollor"); 
            // You should choose one that you have: Dollar or Gold
        }

        public static void GoldToDollorConverter()
        {
            Console.WriteLine("How much do you have");
            decimal goldOfyou= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nConverting to gold...\n");
            const decimal GoldValue1gInDollar=1983; //USD $
            Console.WriteLine($"Your gold is {goldOfyou*GoldValue1gInDollar}$\n");
        }

        public static void DollorToGoldConverter()
        {
            Console.WriteLine("How much do you have");
            decimal dollorOfyou= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nConverting to gold...\n");
            const decimal GoldValue1gInDollar=1983; //USD $
            Console.WriteLine($"Your dollar is {dollorOfyou/GoldValue1gInDollar}g Gold\n");
        }

        public static void Reporter()
        {
            Console.WriteLine("Thank you for using my application");
        }

        public static void LastReport()
        {
            Console.WriteLine("Sorry , you entered invalid input\nTry again later");
        }
        
        
        

    }
}