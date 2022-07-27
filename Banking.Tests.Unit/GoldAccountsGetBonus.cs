
namespace Banking.Tests.Unit;

internal class GoldAccountsGetBonus
{
    [Fact]

    public void GoldAccountsGetBonusOnDepost()
    {

        //Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        account.Status = AccountStatus.Gold;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }
}
