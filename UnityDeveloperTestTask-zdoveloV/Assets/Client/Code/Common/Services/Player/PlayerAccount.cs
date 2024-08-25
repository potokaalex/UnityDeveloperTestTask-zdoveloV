using Client.Code.Common.Data.Currency;
using UniRx;

namespace Client.Code.Common.Services.Player
{
    public class PlayerAccount
    {
        public readonly ReactiveProperty<CurrencyData> GoldCurrency =
            new(new CurrencyData(CurrencyType.Gold, 70, CurrencyModifierType.Trillions));
    }
}