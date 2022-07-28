namespace Banking.Domain;

public class BonusCalculator
{
    

    public decimal GetBonusForDepositOn(decimal balance, decimal amountofDesposit)
    {

        return balance switch
        {
            < 5_000 => 0,
            < 10_000 => amountofDesposit * .02M,
           _ => amountofDesposit * 0.1M
        };
        
       
    
}
}