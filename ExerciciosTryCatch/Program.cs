using ExerciciosTryCatch.Entities;
using ExerciciosTryCatch.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int numberAccount = int.Parse(Console.ReadLine());

        Console.Write("Holder Account: ");
        string holder = Console.ReadLine();

        Console.Write("Initial balance: ");
        double balanceInitial = double.Parse(Console.ReadLine());

        Console.Write("Withdraw limit: ");
        double withDrawLimit = double.Parse(Console.ReadLine());

        // instantiate a new class Account with parametres
        Account Account = new Account(numberAccount, holder, balanceInitial, withDrawLimit);

        Console.Write("Enter amount for withdraw: ");
        double Amount = double.Parse(Console.ReadLine());

        Account.WithDraw(Amount);



    }
}