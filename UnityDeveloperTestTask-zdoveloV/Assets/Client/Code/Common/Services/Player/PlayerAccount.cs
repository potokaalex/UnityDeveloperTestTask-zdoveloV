using Client.Code.Common.Data.Currency;
using UniRx;

namespace Client.Code.Game.UI
{
    public class PlayerAccount
    {
        public ReactiveProperty<CurrencyData> GoldCurrency => new(new CurrencyData(CurrencyType.Gold, 70, CurrencyModifierType.Trillions));
    }
}