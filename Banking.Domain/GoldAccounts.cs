

namespace Banking.Domain;

public class GoldAccounts : Account
{
    public override void Deposit(decimal amountToDeposit)
    {
        //base.Deposit(amountToDeposit * 1.10M);
        base._balance += amountToDeposit * 1.10M;
    }

}
