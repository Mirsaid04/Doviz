namespace doviz.Classes;

public class Calculator
{
    public void GoldToDollorConverter()
    {
        Console.WriteLine("How much do you have"); // Here you should write the Gold that you have 
        decimal goldOfYou= Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("\nConverting to gold...\n");
        decimal goldValue1gInDollar=1983; //USD $
        Console.WriteLine($"Your gold is {goldOfYou*goldValue1gInDollar}$\n");
    }
    
    public void DollorToGoldConverter()
    {
        Console.WriteLine("How much do you have"); // Here you should write the Dollor that you want to change
        decimal usdOfYou= Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("\nConverting to gold...\n");
        const decimal goldValue1gInDollar=1983; //USD $
        Console.WriteLine($"Your dollar is {usdOfYou/goldValue1gInDollar}g Gold\n");
    }
}