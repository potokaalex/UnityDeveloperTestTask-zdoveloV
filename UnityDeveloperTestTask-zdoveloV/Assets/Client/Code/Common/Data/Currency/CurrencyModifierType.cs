namespace Client.Code.Common.Data.Currency
{
    public enum CurrencyModifierType
    {
        //The values of the elements are exponential.
        None = 1,
        Thousands = 3,
        Millions = 6,
        Billions = 9,
        Trillions = 12,
        Quadrillions = 15,
        Quintillions = 18,
        Sextillions = 21
    }
}