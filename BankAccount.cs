namespace BankAccount.Model
{
    public class BankAccount
    {
        private decimal _balance;
        private decimal _amount;

        private int accountNumber;

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }

        public void Withdraw()
        {
            if (_amount > _balance)
            {
                throw new ArgumentOutOfRangeException("Amount of $" + _amount + " will overdraft your account.");
            }
            _balance -= _amount;
        }

        public void Deposit()
        {
            _balance = (_balance + _amount);
        }

        //public decimal Balance
        //{
        //    get { return _balance; }
        //    set
        //    {
        //        if (!decimal.TryParse(value.ToString(), out decimal balance))
        //        {
        //            throw new ArgumentException("Invalid Balance value");
        //        }

        //        if (balance < 0)
        //        {
        //            throw new ArgumentOutOfRangeException(nameof(value), "Balance cannot be negative");
        //        }

        //        _balance = balance;
        //    }
        //}

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be positive.");
                }
                _balance = value;
            }
        }
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (!decimal.TryParse(value.ToString(), out decimal amount))
                {
                    throw new ArgumentException("Invalid Amount value");
                }

                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Amount cannot be negative");
                }

                _amount = amount;
            }
        }
       
    }
}
