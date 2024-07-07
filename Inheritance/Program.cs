namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            // Instantiate Account Class
            Account myAccount = new Account();
            double currentAmount = 0.0;

            //save money in current account
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine("current amount : {0}", currentAmount);

            //withdraw 200.00
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine("current amount : {0}", currentAmount);

            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine("current amount : {0}", currentAmount);
            Console.ReadLine();
        }
    }
}
