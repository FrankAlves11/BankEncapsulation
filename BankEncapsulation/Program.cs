namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine(account.GetBalance());
            account.Deposit(34500);
            Console.WriteLine(account.GetBalance());
        }
    }
}
