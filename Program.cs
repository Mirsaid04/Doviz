using doviz.Classes;

namespace doviz
{
    class Program
    {
        static void Main()
        {
            try{
                string yesOrNo="";
                Calculator calculator = new Calculator();
                Information information = new Information();
            do{
                information.ShowMenu();
                int choosedNumber= int.Parse(Console.ReadLine()!);
            
            switch(choosedNumber)
            {
                case 1: 
                    calculator.GoldToDollorConverter();
                    break;
                
                case 2:
                    calculator.DollorToGoldConverter();
                    break;
                default :
                    information.LastReport();
                    break;
            };
            Console.Write("Do you want to continue [y/n]: "); 
            yesOrNo=Console.ReadLine()!; 
            }while(yesOrNo=="y");
            information.Reporter();
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