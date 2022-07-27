
namespace Banking.Tests.Unit;

public class GoldAccountsGetBonus
{
    [Fact]

    public void GoldAccountsGetBonusOnDeposit()
    {

        //Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }
}
