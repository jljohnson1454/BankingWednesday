namespace Banking.Domain;

public class Account
{
    private decimal _balance = 5000M;
    private ICalculateBonusesForAccounts _bonusCalculator;

    public Account(ICalculateBonusesForAccounts bonusCalculator)
    {
        _bonusCalculator = bonusCalculator;
    }

    
    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = _bonusCalculator.AccountDepositOf(_balance, amountToDeposit);
        _balance += amountToDeposit + bonus;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {

            throw new OverdraftException();
        }
        else
        {
            _balance -= amountToWithdraw;
        }
    }
}

public class OverdraftException : ArgumentOutOfRangeException { }