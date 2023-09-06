namespace doviz.Classes;

public class Information
{
    public void ShowMenu()
    {
        Console.WriteLine("\nWelcome to exchanging program in .Net framework");
        Console.WriteLine("What do you have: \n1.Gold\n2.Dollor"); 
        // You should choose one that you have: Dollar or Gold
    }
    public void Reporter()
    {
        Console.WriteLine("Thank you for using my application");
    }
    public void LastReport()
    {
        Console.WriteLine("Sorry , you entered invalid input\nTry again later");
    }
}