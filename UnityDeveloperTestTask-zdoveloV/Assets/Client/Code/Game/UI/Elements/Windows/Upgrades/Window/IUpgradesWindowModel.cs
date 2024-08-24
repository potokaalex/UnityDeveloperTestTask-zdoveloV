using System.Collections.Generic;
using Client.Code.Common.Data.Currency;
using Client.Code.Common.Data.Items;
using UniRx;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Window
{
    public interface IUpgradesWindowModel
    {
        ReactiveProperty<CurrencyData> Currency { get; }
        List<ItemType> AvailableItems { get; }
    }
}