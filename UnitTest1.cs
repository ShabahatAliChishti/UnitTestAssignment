using System;

namespace UnitTestBankAccount
{
    public class UnitTest1
    {
        [Fact]
        public void TestNegativeAmount()
        {
            // ARRANGE
            BankAccount.Model.BankAccount b = new BankAccount.Model.BankAccount();
            decimal negativeValue = -1;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Amount = negativeValue);
        }

        [Fact]
        public void TestNegativeBalance()
        {
            // ARRANGE
            BankAccount.Model.BankAccount b = new BankAccount.Model.BankAccount();
            decimal negativeValue = -1;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Balance = negativeValue);
        }


        [Fact]
        public void TestNegativeBalanceAndAmount()
        {
            // ARRANGE
            BankAccount.Model.BankAccount b = new BankAccount.Model.BankAccount();
            decimal negativeValue = -12;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Balance = negativeValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Amount = negativeValue);

        }

        [Fact]
        public void TestOverdraft()
        {
            // ARRANGE
            BankAccount.Model.BankAccount b = new BankAccount.Model.BankAccount();

            //test case pass
            b.Balance = 102;
            b.Amount = 103;
            //test case failed
            //b.Balance = 103;
            //b.Amount = 102;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Withdraw());
        }

    }
}