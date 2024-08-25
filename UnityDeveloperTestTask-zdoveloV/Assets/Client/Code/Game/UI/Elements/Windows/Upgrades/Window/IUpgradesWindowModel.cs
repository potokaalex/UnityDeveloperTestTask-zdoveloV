using System.Collections.Generic;
using Client.Code.Common.Data.Currency;
using Client.Code.Common.Data.Items;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using UniRx;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Window
{
    public interface IUpgradesWindowModel
    {
        ReactiveCollection<ItemData> Items { get; }
    }
}