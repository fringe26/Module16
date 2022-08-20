using Module16.OpenClose;

public abstract class Account : ICalculator
{


    // баланс учетной записи
    public abstract double Balance { get; set; }

    // процентная ставка
    public abstract double Interest { get; set; }

    public abstract void CalculateInterest();
    
}