namespace doviz.Classes;

public class Calculator
{
    public void GoldToDollorConverter()
    {
        Console.WriteLine("How much do you have");
        decimal goldOfyou= Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("\nConverting to gold...\n");
        const decimal GoldValue1gInDollar=1983; //USD $
        Console.WriteLine($"Your gold is {goldOfyou*GoldValue1gInDollar}$\n");
    }
    
    public void DollorToGoldConverter()
    {
        Console.WriteLine("How much do you have");
        decimal dollorOfyou= Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("\nConverting to gold...\n");
        const decimal GoldValue1gInDollar=1983; //USD $
        Console.WriteLine($"Your dollar is {dollorOfyou/GoldValue1gInDollar}g Gold\n");
    }
}