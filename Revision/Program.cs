internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine("Hi " + userName + " welcome to the " + "Big Lucky Winner");
        Console.Write("Select a number from 1, 2, 3, 4, 5, and 6 : ");
        string userNumber = Console.ReadLine();

        string message = "";

        if (userNumber == "1")
        {
            message = userName + " Congratulations you won 10,000 Ghana Cedis";
         
        } else if (userNumber == "2"){
            message = userName + " Congratulations you won 20,000 Ghana Cedis";
        }
        else if (userNumber == "3")
        {
            message = userName + " Congratulations you won 30,000 Ghana Cedis";
        }
        else if (userNumber == "4")
        {
            message = userName + " Congratulations you won 40,000 Ghana Cedis";
        }
        else if (userNumber == "5")
        {
            message = userName + " Congratulations you won 50,000 Ghana Cedis";
        }
        else if (userNumber == "6")
        {
            message = userName + " Congratulations you won 60,000 Ghana Cedis";
        } else
        {
            message = "Please select within the range of numbers you have been given!!!. ";
            message += "Sorry you lost";
        }
        Console.WriteLine(message);

    }
}