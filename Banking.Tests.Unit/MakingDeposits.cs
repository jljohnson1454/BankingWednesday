

namespace Banking.Tests.Unit;

public class MakingDeposits
{
    [Fact]
    public void MakingDepositsIncreasesBalance()
    {
        // Given
        var account = new Account(new BonusCalculatorDummy());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        // When
        account.Deposit(amountToDeposit);
        // Then
        Assert.Equal(openingBalance + amountToDeposit,
            account.GetBalance());
    }
}
