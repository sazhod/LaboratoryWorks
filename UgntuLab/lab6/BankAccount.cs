namespace lab6_dll
{
    public class BankAccount
    {
        public string Customer { get; private set; }
        public double Balance { get; private set; }
        public BankAccount(string customer, double balance)
        {
            this.Customer = customer;
            this.Balance = balance;
        }
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Количество не может быть отрицательным!");
            }
            Balance += amount;
        }
    }
}